using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Move : MonoBehaviour
{


    Rigidbody rb;
    public float speed;
    public float x1;
    public float x2;
    public float y1;
    public float y2;
    public Vector3 mousePos;
    public bool forsound;

    float horizontalSpeed = 2.0f;
    float verticalSpeed = 2.0f;
    public AudioSource watersound;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        watersound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        speed = rb.velocity.magnitude;
        //Debug.Log("speed= "+speed);

        mousePos = Input.mousePosition;

        float h = horizontalSpeed * Input.GetAxis("Mouse X");
        float v = verticalSpeed * Input.GetAxis("Mouse Y");
        //Debug.Log("x değeri " + h + (" y değeri " + v));

        //if (Input.GetMouseButtonDown(0))
        //{

        //    x1 = mousePos.x;
        //    y1 = mousePos.y;
        //    x2 = mousePos.x;
        //    y2 = mousePos.y;
        //}
        //if (Input.GetMouseButtonUp(0))
        //{
        //    x2 = mousePos.x;
        //    y2 = mousePos.y;
        //}


        //if (y2-y1>400f&& speed<25f)
        //{

        //    rb.velocity = new Vector3(0, 0, 50);
        //    y1 = 0f;
        //    y2 = 0f;
        //}
        //if (x2-x1>400f && speed < 25f)
        //{

        //    rb.velocity = new Vector3(50, 0, 0);
        //    x1 = 0f;
        //    x2 = 0f;
        //}
        //if (x1-x2>400 && speed < 25f)
        //{

        //    rb.velocity = new Vector3(-50, 0, 0);

        //    x1 = 0f;
        //    x2 = 0f;
        //}
        //if (y1 - y2 > 400f && speed < 25f)
        //{

        //    rb.velocity = new Vector3(0, 0, -50);
        //    y1 = 0f;
        //    y2 = 0f;
        //}




        if (Input.GetMouseButton(0))
        {


            if (v > 0.5f && speed < 25f)
            {

                rb.velocity = new Vector3(0, 0, 50);
                if (forsound==false)
                {
                    forsound = true;
                    StartCoroutine(ExampleCoroutine());
                }




            }
            if (h > 0.5f && speed < 25f)
            {

                rb.velocity = new Vector3(50, 0, 0);
                if (forsound == false)
                {
                    forsound = true;
                    StartCoroutine(ExampleCoroutine());
                }

            }
            if (h < -0.5f && speed < 25f)
            {

                rb.velocity = new Vector3(-50, 0, 0);
                if (forsound == false)
                {
                    forsound = true;
                    StartCoroutine(ExampleCoroutine());
                }


            }
            if (v < -0.5f && speed < 25f)
            {

                rb.velocity = new Vector3(0, 0, -50);
                if (forsound == false)
                {
                    forsound = true;
                    StartCoroutine(ExampleCoroutine());
                }

            }
        }


    }

    IEnumerator ExampleCoroutine()
    {


        watersound.Play();

        yield return new WaitForSeconds(0.2f);
        forsound = false;
    }

}
