using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.UI;


public class LevelControl : MonoBehaviour
{
    public GameObject player;
    public Rigidbody rb;
    public Ease movement;
    public int levelpainted;
    public float time = 0f;
    public bool timefinished = false;
    public int inttime = 0;

    public GameObject timeobject;
    public Text timetext;
    public GameObject starsmanager;
    public int starTime1 =15;
    public int starTime2 =10;
    public int starTime3 = 7;

    public AudioSource stareffect;


    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("fakelevel") == 1)
        {
            levelpainted = 43;
        }
        if (PlayerPrefs.GetInt("fakelevel") == 2)
        {
            levelpainted = 38;
        }
        if (PlayerPrefs.GetInt("fakelevel") == 3)
        {
            levelpainted = 42;
        }
        if (PlayerPrefs.GetInt("fakelevel") == 4)
        {
            levelpainted = 46;
        }
        if (PlayerPrefs.GetInt("fakelevel") == 5 || PlayerPrefs.GetInt("fakelevel") == 10)
        {
            levelpainted = 47;
        }
        if (PlayerPrefs.GetInt("fakelevel") == 6)
        {
            levelpainted = 44;
        }
        if (PlayerPrefs.GetInt("fakelevel") == 7 || PlayerPrefs.GetInt("fakelevel") == 8)
        {
            levelpainted = 69;
        }
        if (PlayerPrefs.GetInt("fakelevel") == 9)
        {
            levelpainted = 56;
        }
        if (PlayerPrefs.GetInt("fakelevel") == 11)
        {
            levelpainted = 61;
        }
        if (PlayerPrefs.GetInt("fakelevel") == 12)
        {
            levelpainted = 55;
        }
        rb = player.GetComponent<Rigidbody>();

        //FIREWORKS
        transform.GetChild(0).gameObject.SetActive(false); 
        transform.GetChild(1).gameObject.SetActive(false);
        transform.GetChild(2).gameObject.SetActive(false);
        transform.GetChild(3).gameObject.SetActive(false);


        timetext = timeobject.GetComponent<Text>();

        starsmanager.SetActive(false);
        stareffect = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timefinished == false)
        {
            time += Time.deltaTime;

        }
        inttime = (int)Math.Round(time);
   
        timetext.text = "" + inttime;


        Win();
    }
    public void Win()
    {
        if (PlayerPrefs.GetInt("painted") == levelpainted && PlayerPrefs.GetInt("fakelevel") == 1)
        {
            timefinished = true;
            PlayerPrefs.SetInt("painted", 0);
            if (PlayerPrefs.GetInt("fakelevel")== PlayerPrefs.GetInt("level"))
            {
                PlayerPrefs.SetInt("level", PlayerPrefs.GetInt("level") + 1);
            }
            Stars();


            if (PlayerPrefs.GetInt("fakestar")> PlayerPrefs.GetInt("level1star"))
            {
                PlayerPrefs.SetInt("level1star", PlayerPrefs.GetInt("fakestar"));
            }

            PlayerPrefs.SetInt("fakelevel", PlayerPrefs.GetInt("fakelevel") + 1);

            rb.constraints = RigidbodyConstraints.FreezePosition;
            transform.GetChild(0).gameObject.SetActive(true);
            transform.GetChild(1).gameObject.SetActive(true);
            transform.GetChild(2).gameObject.SetActive(true);
            transform.GetChild(3).gameObject.SetActive(true);
            

            player.transform.DOMoveY(4f, 0.5f).SetEase(movement).OnComplete(() =>
            {
                player.transform.DOMoveY(0.5f, 0.5f).SetEase(movement).OnComplete(() =>
                {
                    StartCoroutine(ExampleCoroutine());
                });


            });




        }
        if (PlayerPrefs.GetInt("painted") == levelpainted && PlayerPrefs.GetInt("fakelevel") == 2)
        {
            timefinished = true;
            PlayerPrefs.SetInt("painted", 0);
            if (PlayerPrefs.GetInt("fakelevel") == PlayerPrefs.GetInt("level"))
            {
                PlayerPrefs.SetInt("level", PlayerPrefs.GetInt("level") + 1);
            }
            PlayerPrefs.SetInt("fakelevel", PlayerPrefs.GetInt("fakelevel") + 1);

            Stars();


            if (PlayerPrefs.GetInt("fakestar") > PlayerPrefs.GetInt("level2star"))
            {
                PlayerPrefs.SetInt("level2star", PlayerPrefs.GetInt("fakestar"));
            }

            rb.constraints = RigidbodyConstraints.FreezePosition;
            transform.GetChild(0).gameObject.SetActive(true);
            transform.GetChild(1).gameObject.SetActive(true);
            transform.GetChild(2).gameObject.SetActive(true);
            transform.GetChild(3).gameObject.SetActive(true);
            player.transform.DOMoveY(4f, 0.5f).SetEase(movement).OnComplete(() =>
            {
                player.transform.DOMoveY(0.5f, 0.5f).SetEase(movement).OnComplete(() =>
                {
                    StartCoroutine(ExampleCoroutine2());
                });


            });



        }
        if (PlayerPrefs.GetInt("painted") == levelpainted && PlayerPrefs.GetInt("fakelevel") == 3)
        {
            timefinished = true;
            PlayerPrefs.SetInt("painted", 0);
            if (PlayerPrefs.GetInt("fakelevel") == PlayerPrefs.GetInt("level"))
            {
                PlayerPrefs.SetInt("level", PlayerPrefs.GetInt("level") + 1);
            }
            PlayerPrefs.SetInt("fakelevel", PlayerPrefs.GetInt("fakelevel") + 1);

            Stars();


            if (PlayerPrefs.GetInt("fakestar") > PlayerPrefs.GetInt("level3star"))
            {
                PlayerPrefs.SetInt("level3star", PlayerPrefs.GetInt("fakestar"));
            }

            rb.constraints = RigidbodyConstraints.FreezePosition;
            transform.GetChild(0).gameObject.SetActive(true);
            transform.GetChild(1).gameObject.SetActive(true);
            transform.GetChild(2).gameObject.SetActive(true);
            transform.GetChild(3).gameObject.SetActive(true);
            player.transform.DOMoveY(4f, 0.5f).SetEase(movement).OnComplete(() =>
            {
                player.transform.DOMoveY(0.5f, 0.5f).SetEase(movement).OnComplete(() =>
                {
                    StartCoroutine(ExampleCoroutine3());
                });


            });



        }
        if (PlayerPrefs.GetInt("painted") == levelpainted && PlayerPrefs.GetInt("fakelevel") == 4)
        {
            timefinished = true;

            PlayerPrefs.SetInt("painted", 0);
            if (PlayerPrefs.GetInt("fakelevel") == PlayerPrefs.GetInt("level"))
            {
                PlayerPrefs.SetInt("level", PlayerPrefs.GetInt("level") + 1);
            }
            PlayerPrefs.SetInt("fakelevel", PlayerPrefs.GetInt("fakelevel") + 1);

            Stars();


            if (PlayerPrefs.GetInt("fakestar") > PlayerPrefs.GetInt("level4star"))
            {
                PlayerPrefs.SetInt("level4star", PlayerPrefs.GetInt("fakestar"));
            }

            rb.constraints = RigidbodyConstraints.FreezePosition;
            transform.GetChild(0).gameObject.SetActive(true);
            transform.GetChild(1).gameObject.SetActive(true);
            transform.GetChild(2).gameObject.SetActive(true);
            transform.GetChild(3).gameObject.SetActive(true);
            player.transform.DOMoveY(4f, 0.5f).SetEase(movement).OnComplete(() =>
            {
                player.transform.DOMoveY(0.5f, 0.5f).SetEase(movement).OnComplete(() =>
                {
                    StartCoroutine(ExampleCoroutine4());
                });


            });



        }
        if (PlayerPrefs.GetInt("painted") == levelpainted && PlayerPrefs.GetInt("fakelevel") == 5)
        {
            timefinished = true;
            PlayerPrefs.SetInt("painted", 0);
            if (PlayerPrefs.GetInt("fakelevel") == PlayerPrefs.GetInt("level"))
            {
                PlayerPrefs.SetInt("level", PlayerPrefs.GetInt("level") + 1);
            }
            PlayerPrefs.SetInt("fakelevel", PlayerPrefs.GetInt("fakelevel") + 1);

            Stars();


            if (PlayerPrefs.GetInt("fakestar") > PlayerPrefs.GetInt("level5star"))
            {
                PlayerPrefs.SetInt("level5star", PlayerPrefs.GetInt("fakestar"));
            }

            rb.constraints = RigidbodyConstraints.FreezePosition;
            transform.GetChild(0).gameObject.SetActive(true);
            transform.GetChild(1).gameObject.SetActive(true);
            transform.GetChild(2).gameObject.SetActive(true);
            transform.GetChild(3).gameObject.SetActive(true);
            player.transform.DOMoveY(4f, 0.5f).SetEase(movement).OnComplete(() =>
            {
                player.transform.DOMoveY(0.5f, 0.5f).SetEase(movement).OnComplete(() =>
                {
                    StartCoroutine(ExampleCoroutine5());
                });


            });

            

        }
        if (PlayerPrefs.GetInt("painted") == levelpainted && PlayerPrefs.GetInt("fakelevel") == 6)
        {
            timefinished = true;
            PlayerPrefs.SetInt("painted", 0);
            if (PlayerPrefs.GetInt("fakelevel") == PlayerPrefs.GetInt("level"))
            {
                PlayerPrefs.SetInt("level", PlayerPrefs.GetInt("level") + 1);
            }
            PlayerPrefs.SetInt("fakelevel", PlayerPrefs.GetInt("fakelevel") + 1);

            Stars();


            if (PlayerPrefs.GetInt("fakestar") > PlayerPrefs.GetInt("level6star"))
            {
                PlayerPrefs.SetInt("level6star", PlayerPrefs.GetInt("fakestar"));
            }

            rb.constraints = RigidbodyConstraints.FreezePosition;
            transform.GetChild(0).gameObject.SetActive(true);
            transform.GetChild(1).gameObject.SetActive(true);
            transform.GetChild(2).gameObject.SetActive(true);
            transform.GetChild(3).gameObject.SetActive(true);
            player.transform.DOMoveY(4f, 0.5f).SetEase(movement).OnComplete(() =>
            {
                player.transform.DOMoveY(0.5f, 0.5f).SetEase(movement).OnComplete(() =>
                {
                    StartCoroutine(ExampleCoroutine6());
                });


            });


        }
        if (PlayerPrefs.GetInt("painted") == levelpainted && PlayerPrefs.GetInt("fakelevel") == 7)
        {
            timefinished = true;
            PlayerPrefs.SetInt("painted", 0);
            if (PlayerPrefs.GetInt("fakelevel") == PlayerPrefs.GetInt("level"))
            {
                PlayerPrefs.SetInt("level", PlayerPrefs.GetInt("level") + 1);
            }
            PlayerPrefs.SetInt("fakelevel", PlayerPrefs.GetInt("fakelevel") + 1);

            Stars();


            if (PlayerPrefs.GetInt("fakestar") > PlayerPrefs.GetInt("level7star"))
            {
                PlayerPrefs.SetInt("level7star", PlayerPrefs.GetInt("fakestar"));
            }

            rb.constraints = RigidbodyConstraints.FreezePosition;
            transform.GetChild(0).gameObject.SetActive(true);
            transform.GetChild(1).gameObject.SetActive(true);
            transform.GetChild(2).gameObject.SetActive(true);
            transform.GetChild(3).gameObject.SetActive(true);
            player.transform.DOMoveY(4f, 0.5f).SetEase(movement).OnComplete(() =>
            {
                player.transform.DOMoveY(0.5f, 0.5f).SetEase(movement).OnComplete(() =>
                {
                    StartCoroutine(ExampleCoroutine7());
                });


            });



        }
        if (PlayerPrefs.GetInt("painted") == levelpainted && PlayerPrefs.GetInt("fakelevel") == 8)
        {
            timefinished = true;
            PlayerPrefs.SetInt("painted", 0);
            if (PlayerPrefs.GetInt("fakelevel") == PlayerPrefs.GetInt("level"))
            {
                PlayerPrefs.SetInt("level", PlayerPrefs.GetInt("level") + 1);
            }
            PlayerPrefs.SetInt("fakelevel", PlayerPrefs.GetInt("fakelevel") + 1);

                 starTime1 = 20;
                 starTime2 = 18;
                 starTime3 = 15;

                 Stars();


            if (PlayerPrefs.GetInt("fakestar") > PlayerPrefs.GetInt("level8star"))
            {
                PlayerPrefs.SetInt("level8star", PlayerPrefs.GetInt("fakestar"));
            }

            rb.constraints = RigidbodyConstraints.FreezePosition;
            transform.GetChild(0).gameObject.SetActive(true);
            transform.GetChild(1).gameObject.SetActive(true);
            transform.GetChild(2).gameObject.SetActive(true);
            transform.GetChild(3).gameObject.SetActive(true);
            player.transform.DOMoveY(4f, 0.5f).SetEase(movement).OnComplete(() =>
            {
                player.transform.DOMoveY(0.5f, 0.5f).SetEase(movement).OnComplete(() =>
                {
                    StartCoroutine(ExampleCoroutine8());
                });


            });



        }
        if (PlayerPrefs.GetInt("painted") == levelpainted && PlayerPrefs.GetInt("fakelevel") == 9)
        {
            timefinished = true;
            PlayerPrefs.SetInt("painted", 0);
            if (PlayerPrefs.GetInt("fakelevel") == PlayerPrefs.GetInt("level"))
            {
                PlayerPrefs.SetInt("level", PlayerPrefs.GetInt("level") + 1);
            }
            PlayerPrefs.SetInt("fakelevel", PlayerPrefs.GetInt("fakelevel") + 1);

            Stars();


            if (PlayerPrefs.GetInt("fakestar") > PlayerPrefs.GetInt("level9star"))
            {
                PlayerPrefs.SetInt("level9star", PlayerPrefs.GetInt("fakestar"));
            }

            rb.constraints = RigidbodyConstraints.FreezePosition;
            transform.GetChild(0).gameObject.SetActive(true);
            transform.GetChild(1).gameObject.SetActive(true);
            transform.GetChild(2).gameObject.SetActive(true);
            transform.GetChild(3).gameObject.SetActive(true);
            player.transform.DOMoveY(4f, 0.5f).SetEase(movement).OnComplete(() =>
            {
                player.transform.DOMoveY(0.5f, 0.5f).SetEase(movement).OnComplete(() =>
                {
                    StartCoroutine(ExampleCoroutine9());
                });


            });



        }
        if (PlayerPrefs.GetInt("painted") == levelpainted && PlayerPrefs.GetInt("fakelevel") == 10)
        {
            timefinished = true;
            PlayerPrefs.SetInt("painted", 0);
            if (PlayerPrefs.GetInt("fakelevel") == PlayerPrefs.GetInt("level"))
            {
                PlayerPrefs.SetInt("level", PlayerPrefs.GetInt("level") + 1);
            }
            PlayerPrefs.SetInt("fakelevel", PlayerPrefs.GetInt("fakelevel") + 1);

            Stars();


            if (PlayerPrefs.GetInt("fakestar") > PlayerPrefs.GetInt("level10star"))
            {
                PlayerPrefs.SetInt("level10star", PlayerPrefs.GetInt("fakestar"));
            }

            rb.constraints = RigidbodyConstraints.FreezePosition;
            transform.GetChild(0).gameObject.SetActive(true);
            transform.GetChild(1).gameObject.SetActive(true);
            transform.GetChild(2).gameObject.SetActive(true);
            transform.GetChild(3).gameObject.SetActive(true);
            player.transform.DOMoveY(4f, 0.5f).SetEase(movement).OnComplete(() =>
            {
                player.transform.DOMoveY(0.5f, 0.5f).SetEase(movement).OnComplete(() =>
                {
                    StartCoroutine(ExampleCoroutine10());
                });


            });



        }
        if (PlayerPrefs.GetInt("painted") == levelpainted && PlayerPrefs.GetInt("fakelevel") == 11)
        {
            timefinished = true;
            PlayerPrefs.SetInt("painted", 0);
            if (PlayerPrefs.GetInt("fakelevel") == PlayerPrefs.GetInt("level"))
            {
                PlayerPrefs.SetInt("level", PlayerPrefs.GetInt("level") + 1);
            }
            PlayerPrefs.SetInt("fakelevel", PlayerPrefs.GetInt("fakelevel") + 1);

            Stars();


            if (PlayerPrefs.GetInt("fakestar") > PlayerPrefs.GetInt("level11star"))
            {
                PlayerPrefs.SetInt("level11star", PlayerPrefs.GetInt("fakestar"));
            }

            rb.constraints = RigidbodyConstraints.FreezePosition;
            transform.GetChild(0).gameObject.SetActive(true);
            transform.GetChild(1).gameObject.SetActive(true);
            transform.GetChild(2).gameObject.SetActive(true);
            transform.GetChild(3).gameObject.SetActive(true);
            player.transform.DOMoveY(4f, 0.5f).SetEase(movement).OnComplete(() =>
            {
                player.transform.DOMoveY(0.5f, 0.5f).SetEase(movement).OnComplete(() =>
                {
                    StartCoroutine(ExampleCoroutine11());
                });


            });



        }
        if (PlayerPrefs.GetInt("painted") == levelpainted && PlayerPrefs.GetInt("fakelevel") == 12)
        {
            timefinished = true;
            PlayerPrefs.SetInt("painted", 0);
            if (PlayerPrefs.GetInt("fakelevel") == PlayerPrefs.GetInt("level"))
            {
                PlayerPrefs.SetInt("level", PlayerPrefs.GetInt("level") + 1);
            }
            PlayerPrefs.SetInt("fakelevel", PlayerPrefs.GetInt("fakelevel") + 1);

            Stars();


            if (PlayerPrefs.GetInt("fakestar") > PlayerPrefs.GetInt("level12star"))
            {
                PlayerPrefs.SetInt("level12star", PlayerPrefs.GetInt("fakestar"));
            }

            rb.constraints = RigidbodyConstraints.FreezePosition;
            transform.GetChild(0).gameObject.SetActive(true);
            transform.GetChild(1).gameObject.SetActive(true);
            transform.GetChild(2).gameObject.SetActive(true);
            transform.GetChild(3).gameObject.SetActive(true);
            player.transform.DOMoveY(4f, 0.5f).SetEase(movement).OnComplete(() =>
            {
                player.transform.DOMoveY(0.5f, 0.5f).SetEase(movement).OnComplete(() =>
                {
                    StartCoroutine(ExampleCoroutine12());
                });


            });



        }
    }


    IEnumerator ExampleCoroutine()
    {
        starsmanager.SetActive(true);
        yield return new WaitForSeconds(0.4f);
        if (PlayerPrefs.GetInt("fakestar")>0)
        {
             starsmanager.transform.GetChild(3).gameObject.SetActive(false);
            stareffect.Play();
        }
        yield return new WaitForSeconds(0.4f);
        if (PlayerPrefs.GetInt("fakestar") > 1)
        {
            starsmanager.transform.GetChild(4).gameObject.SetActive(false);
            stareffect.Play();
        }
        yield return new WaitForSeconds(0.4f);
        if (PlayerPrefs.GetInt("fakestar") > 2)
        {
            starsmanager.transform.GetChild(5).gameObject.SetActive(false);
            stareffect.Play();
        }
        // We are waiting here for the fireworks to be finished
        yield return new WaitForSeconds(1.3f);
        SceneManager.LoadScene("Level2");
    }
    IEnumerator ExampleCoroutine2()
    {
        starsmanager.SetActive(true);
        yield return new WaitForSeconds(0.4f);
        if (PlayerPrefs.GetInt("fakestar") > 0)
        {
            starsmanager.transform.GetChild(3).gameObject.SetActive(false);
            stareffect.Play();
        }
        yield return new WaitForSeconds(0.4f);
        if (PlayerPrefs.GetInt("fakestar") > 1)
        {
            starsmanager.transform.GetChild(4).gameObject.SetActive(false);
            stareffect.Play();
        }
        yield return new WaitForSeconds(0.4f);
        if (PlayerPrefs.GetInt("fakestar") > 2)
        {
            starsmanager.transform.GetChild(5).gameObject.SetActive(false);
            stareffect.Play();
        }
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Level3");
    }
    IEnumerator ExampleCoroutine3()
    {
        starsmanager.SetActive(true);
        yield return new WaitForSeconds(0.4f);
        if (PlayerPrefs.GetInt("fakestar") > 0)
        {
            starsmanager.transform.GetChild(3).gameObject.SetActive(false);
            stareffect.Play();
        }
        yield return new WaitForSeconds(0.4f);
        if (PlayerPrefs.GetInt("fakestar") > 1)
        {
            starsmanager.transform.GetChild(4).gameObject.SetActive(false);
            stareffect.Play();
        }
        yield return new WaitForSeconds(0.4f);
        if (PlayerPrefs.GetInt("fakestar") > 2)
        {
            starsmanager.transform.GetChild(5).gameObject.SetActive(false);
            stareffect.Play();
        }
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Level4");
    }
    IEnumerator ExampleCoroutine4()
    {
        starsmanager.SetActive(true);
        yield return new WaitForSeconds(0.4f);
        if (PlayerPrefs.GetInt("fakestar") > 0)
        {
            starsmanager.transform.GetChild(3).gameObject.SetActive(false);
            stareffect.Play();

        }
        yield return new WaitForSeconds(0.4f);
        if (PlayerPrefs.GetInt("fakestar") > 1)
        {
            starsmanager.transform.GetChild(4).gameObject.SetActive(false);
            stareffect.Play();

        }
        yield return new WaitForSeconds(0.4f);
        if (PlayerPrefs.GetInt("fakestar") > 2)
        {
            starsmanager.transform.GetChild(5).gameObject.SetActive(false);
            stareffect.Play();

        }
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Level5");
    }
    IEnumerator ExampleCoroutine5()
    {
        starsmanager.SetActive(true);
        yield return new WaitForSeconds(0.4f);
        if (PlayerPrefs.GetInt("fakestar") > 0)
        {
            starsmanager.transform.GetChild(3).gameObject.SetActive(false);
            stareffect.Play();

        }
        yield return new WaitForSeconds(0.4f);
        if (PlayerPrefs.GetInt("fakestar") > 1)
        {
            starsmanager.transform.GetChild(4).gameObject.SetActive(false);
            stareffect.Play();

        }
        yield return new WaitForSeconds(0.4f);
        if (PlayerPrefs.GetInt("fakestar") > 2)
        {
            starsmanager.transform.GetChild(5).gameObject.SetActive(false);
            stareffect.Play();

        }
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Level6");
    }
    IEnumerator ExampleCoroutine6()
    {
        starsmanager.SetActive(true);
        yield return new WaitForSeconds(0.4f);
        if (PlayerPrefs.GetInt("fakestar") > 0)
        {
            starsmanager.transform.GetChild(3).gameObject.SetActive(false);
            stareffect.Play();

        }
        yield return new WaitForSeconds(0.4f);
        if (PlayerPrefs.GetInt("fakestar") > 1)
        {
            starsmanager.transform.GetChild(4).gameObject.SetActive(false);
            stareffect.Play();

        }
        yield return new WaitForSeconds(0.4f);
        if (PlayerPrefs.GetInt("fakestar") > 2)
        {
            starsmanager.transform.GetChild(5).gameObject.SetActive(false);
            stareffect.Play();

        }
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Level7");
    }
    IEnumerator ExampleCoroutine7()
    {
        starsmanager.SetActive(true);
        yield return new WaitForSeconds(0.4f);
        if (PlayerPrefs.GetInt("fakestar") > 0)
        {
            starsmanager.transform.GetChild(3).gameObject.SetActive(false);
            stareffect.Play();

        }
        yield return new WaitForSeconds(0.4f);
        if (PlayerPrefs.GetInt("fakestar") > 1)
        {
            starsmanager.transform.GetChild(4).gameObject.SetActive(false);
            stareffect.Play();

        }
        yield return new WaitForSeconds(0.4f);
        if (PlayerPrefs.GetInt("fakestar") > 2)
        {
            starsmanager.transform.GetChild(5).gameObject.SetActive(false);
            stareffect.Play();

        }
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Level8");
    }

    IEnumerator ExampleCoroutine8()
    {
        starsmanager.SetActive(true);
        yield return new WaitForSeconds(0.4f);
        if (PlayerPrefs.GetInt("fakestar") > 0)
        {
            starsmanager.transform.GetChild(3).gameObject.SetActive(false);
            stareffect.Play();

        }
        yield return new WaitForSeconds(0.4f);
        if (PlayerPrefs.GetInt("fakestar") > 1)
        {
            starsmanager.transform.GetChild(4).gameObject.SetActive(false);
            stareffect.Play();

        }
        yield return new WaitForSeconds(0.4f);
        if (PlayerPrefs.GetInt("fakestar") > 2)
        {
            starsmanager.transform.GetChild(5).gameObject.SetActive(false); 
            stareffect.Play();

        }
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Level9");
    }

    IEnumerator ExampleCoroutine9()
    {
        starsmanager.SetActive(true);
        yield return new WaitForSeconds(0.4f);
        if (PlayerPrefs.GetInt("fakestar") > 0)
        {
            starsmanager.transform.GetChild(3).gameObject.SetActive(false);
            stareffect.Play();

        }
        yield return new WaitForSeconds(0.4f);
        if (PlayerPrefs.GetInt("fakestar") > 1)
        {
            starsmanager.transform.GetChild(4).gameObject.SetActive(false);
            stareffect.Play();

        }
        yield return new WaitForSeconds(0.4f);
        if (PlayerPrefs.GetInt("fakestar") > 2)
        {
            starsmanager.transform.GetChild(5).gameObject.SetActive(false);
            stareffect.Play();

        }
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Level10");
    }
    IEnumerator ExampleCoroutine10()
    {
        starsmanager.SetActive(true);
        yield return new WaitForSeconds(0.4f);
        if (PlayerPrefs.GetInt("fakestar") > 0)
        {
            starsmanager.transform.GetChild(3).gameObject.SetActive(false);
            stareffect.Play();

        }
        yield return new WaitForSeconds(0.4f);
        if (PlayerPrefs.GetInt("fakestar") > 1)
        {
            starsmanager.transform.GetChild(4).gameObject.SetActive(false);
            stareffect.Play();

        }
        yield return new WaitForSeconds(0.4f);
        if (PlayerPrefs.GetInt("fakestar") > 2)
        {
            starsmanager.transform.GetChild(5).gameObject.SetActive(false);
            stareffect.Play();

        }
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Level11");
    }
    IEnumerator ExampleCoroutine11()
    {
        starsmanager.SetActive(true);
        yield return new WaitForSeconds(0.4f);
        if (PlayerPrefs.GetInt("fakestar") > 0)
        {
            starsmanager.transform.GetChild(3).gameObject.SetActive(false);
            stareffect.Play();

        }
        yield return new WaitForSeconds(0.4f);
        if (PlayerPrefs.GetInt("fakestar") > 1)
        {
            starsmanager.transform.GetChild(4).gameObject.SetActive(false);
            stareffect.Play();

        }
        yield return new WaitForSeconds(0.4f);
        if (PlayerPrefs.GetInt("fakestar") > 2)
        {
            starsmanager.transform.GetChild(5).gameObject.SetActive(false);
            stareffect.Play();

        }
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Level12");
    }
    IEnumerator ExampleCoroutine12()
    {
        starsmanager.SetActive(true);
        yield return new WaitForSeconds(0.4f);
        if (PlayerPrefs.GetInt("fakestar") > 0)
        {
            starsmanager.transform.GetChild(3).gameObject.SetActive(false);
            stareffect.Play();

        }
        yield return new WaitForSeconds(0.4f);
        if (PlayerPrefs.GetInt("fakestar") > 1)
        {
            starsmanager.transform.GetChild(4).gameObject.SetActive(false);
            stareffect.Play();

        }
        yield return new WaitForSeconds(0.4f);
        if (PlayerPrefs.GetInt("fakestar") > 2)
        {
            starsmanager.transform.GetChild(5).gameObject.SetActive(false);
            stareffect.Play();

        }
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("StartScene");
    }

    public void Stars()
    {
        PlayerPrefs.SetInt("fakestar", 0);
        if (inttime < starTime1)
        {
            PlayerPrefs.SetInt("fakestar", 1);
        }
        if (inttime < starTime2)
        {
            PlayerPrefs.SetInt("fakestar", 2);
        }
        if (inttime < starTime3)
        {
            PlayerPrefs.SetInt("fakestar", 3);
        }
    }
}
