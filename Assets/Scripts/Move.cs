using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Move : MonoBehaviour
{


    //Rigidbody rb;
    //public float speed;
    //public float x1;
    //public float x2;
    //public float y1;
    //public float y2;
    //public Vector3 mousePos;


    //float horizontalSpeed = 2.0f;
    //float verticalSpeed = 2.0f;

    //public Vector3 direction;

    //public float playerSpeed = 25f;

    //// Start is called before the first frame update
    //void Start()
    //{
    //    rb = GetComponent<Rigidbody>();

    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    speed = rb.velocity.magnitude;

    //    mousePos = Input.mousePosition;

    //    float h = horizontalSpeed * Input.GetAxis("Mouse X");
    //    float v = verticalSpeed * Input.GetAxis("Mouse Y");
    //    rb.velocity = direction * playerSpeed;

    //    if (h != 0)
    //    {
    //        Debug.Log("x " + h);
    //    }
    //    if (v != 0)
    //    {
    //        Debug.Log("y " + v);
    //    }


    //    if (Input.GetMouseButton(0))
    //    {


    //        if (v > 1f && speed < 1f)
    //        {

    //            direction = Vector3.forward;
    //            if (forsound == false)
    //            {
    //                forsound = true;
    //                StartCoroutine(ExampleCoroutine());
    //            }




    //        }
    //        if (h > 1f && speed < 1f)
    //        {

    //            direction = Vector3.right;
    //            if (forsound == false)
    //            {
    //                forsound = true;
    //                StartCoroutine(ExampleCoroutine());
    //            }

    //        }
    //        if (h < -1f && speed < 1f)
    //        {

    //            direction = Vector3.left;
    //            if (forsound == false)
    //            {
    //                forsound = true;
    //                StartCoroutine(ExampleCoroutine());
    //            }


    //        }
    //        if (v < -1f && speed < 1f)
    //        {

    //            direction = Vector3.back;
    //            if (forsound == false)
    //            {
    //                forsound = true;
    //                StartCoroutine(ExampleCoroutine());
    //            }

    //        }

    //    }


    //}

    //IEnumerator ExampleCoroutine()
    //{


    //    watersound.Play();

    //    yield return new WaitForSeconds(0.2f); // watersound doesn't work all the time
    //    forsound = false;
    //}


    public bool isMoving;
    public bool isReachTheCorner;
    public float speed = 50f;
    public float speedy;
    public Rigidbody rb;
    public AudioSource watersound;
    public bool forsound;
    public int minSwipeRange = 500;
    Vector3 direction;
    Vector3 nextWallPos;

    Vector2 swipePosFirst;
    Vector2 swipePosSecond;
    Vector2 currentSwipe;




    void Start()
    {
        watersound = GetComponent<AudioSource>();
        rb = gameObject.GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (!isMoving && PlayerPrefs.GetInt("finished") == 0)
        {
            rb.velocity = speed * direction;
            StartCoroutine("TimeDelay");



        }
        if (nextWallPos != Vector3.zero)
        {
            if (Vector3.Distance(transform.position, nextWallPos) < 0.5)
            {
                isMoving = false;
                direction = Vector3.zero;
                nextWallPos = Vector3.zero;
            }
        }
    }


    // Update is called once per frame
    void Update()
    {
        speedy = rb.velocity.magnitude;


        if (Input.GetMouseButton(0) && speedy < 1)
        {
            swipePosFirst = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

 
            if (swipePosSecond != Vector2.zero)
            {

                currentSwipe = swipePosFirst - swipePosSecond;
                if (currentSwipe.sqrMagnitude < minSwipeRange)
                {
                    return;
                }




                //Forward and Back
                if (currentSwipe.x > -10f && currentSwipe.x < 10f)
                {

                    if (currentSwipe.y > 4f)
                    {
                        setDirection(Vector3.forward);
                        if (forsound==false)
                        {
                            forsound = true;
                           StartCoroutine("SoundManager");
                        }


                    }
                    if (currentSwipe.y < -4f)
                    {
                        setDirection(Vector3.back);
                        StartCoroutine("TimeDelay");
                        if (forsound == false)
                        {
                            forsound = true;
                            StartCoroutine("SoundManager");
                        }
                    }
                }

                // Right and Left
                else if (currentSwipe.y > -10f && currentSwipe.y < 10f)
                {
                    if (currentSwipe.x > 4f)
                    {
                        setDirection(Vector3.right);
                        StartCoroutine("TimeDelay");
                        if (forsound == false)
                        {
                            forsound = true;
                            StartCoroutine("SoundManager");
                        }
                    }
                    if (currentSwipe.x < -4f)
                    {
                        setDirection(Vector3.left);
                        StartCoroutine("TimeDelay");
                        if (forsound == false)
                        {
                            forsound = true;
                            StartCoroutine("SoundManager");
                        }
                    }
                }
            }
            swipePosSecond = swipePosFirst;

        }

        if (Input.GetMouseButtonUp(0))
        {
            swipePosSecond = Vector2.zero;
        }
    }

    public void setDirection(Vector3 forSetDirection)
    {
        direction = forSetDirection;
        RaycastHit hit;
        if (Physics.Raycast(transform.position, forSetDirection, out hit, 100f))
        {
            nextWallPos = hit.point;
        }
        isMoving = false;
    }

    public IEnumerator TimeDelay()
    {
        yield return new WaitForSeconds(5f);
    }

    public IEnumerator SoundManager()
    {

        
            watersound.Play();
        
        yield return new WaitForSeconds(0.2f); // watersound doesn't work all the time

        forsound = false;
    }

}


