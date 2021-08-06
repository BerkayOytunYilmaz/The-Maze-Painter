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
    public Vector3 direction;

    public float playerSpeed=25f;

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

        mousePos = Input.mousePosition;

        float h = horizontalSpeed * Input.GetAxis("Mouse X");
        float v = verticalSpeed * Input.GetAxis("Mouse Y");
        rb.velocity = direction * playerSpeed;

        if (Input.GetMouseButton(0))
        {


            if (v > 0.5f && speed < 1f)
            {

                direction = Vector3.forward;
                if (forsound == false)
                {
                    forsound = true;
                    StartCoroutine(ExampleCoroutine());
                }




            }
            if (h > 0.5f && speed < 1f)
            {

                direction = Vector3.right;
                if (forsound == false)
                {
                    forsound = true;
                    StartCoroutine(ExampleCoroutine());
                }

            }
            if (h < -0.5f && speed < 1f)
            {

                direction = Vector3.left;
                if (forsound == false)
                {
                    forsound = true;
                    StartCoroutine(ExampleCoroutine());
                }


            }
            if (v < -0.5f && speed < 1f)
            {

                direction = Vector3.back;
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

        yield return new WaitForSeconds(0.2f); // watersound doesn't work all the time
        forsound = false;
    }

}
