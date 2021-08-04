using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class LevelControl : MonoBehaviour
{
    public GameObject player;
    public Rigidbody rb;
    public Ease movement;
    public int levelpainted;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("level") == 1)
        {
            levelpainted = 43;
        }
        if (PlayerPrefs.GetInt("level") == 2)
        {
            levelpainted = 38;
        }
        if (PlayerPrefs.GetInt("level") == 3)
        {
            levelpainted = 42;
        }
        if (PlayerPrefs.GetInt("level") == 4)
        {
            levelpainted = 46;
        }
        if (PlayerPrefs.GetInt("level") == 5)
        {
            levelpainted = 47;
        }
        if (PlayerPrefs.GetInt("level") == 6)
        {
            levelpainted = 44;
        }
        rb = player.GetComponent<Rigidbody>();
        transform.GetChild(0).gameObject.SetActive(false);
        transform.GetChild(1).gameObject.SetActive(false);
        transform.GetChild(2).gameObject.SetActive(false);
        transform.GetChild(3).gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Win();
    }
    public void Win()
    {
        if (PlayerPrefs.GetInt("painted") == levelpainted && PlayerPrefs.GetInt("level") == 1)
        {
            Debug.Log("KAZANDIN");
            PlayerPrefs.SetInt("painted", 0);
            PlayerPrefs.SetInt("level", PlayerPrefs.GetInt("level") + 1);
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
            player.transform.DOMoveZ(+3.5f, 0.1f);


        }
        if (PlayerPrefs.GetInt("painted") == levelpainted && PlayerPrefs.GetInt("level") == 2)
        {
            Debug.Log("KAZANDIN");
            PlayerPrefs.SetInt("painted", 0);
            PlayerPrefs.SetInt("level", PlayerPrefs.GetInt("level") + 1);
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
            player.transform.DOMoveZ(2.5f, 0.1f);


        }
        if (PlayerPrefs.GetInt("painted") == levelpainted && PlayerPrefs.GetInt("level") == 3)
        {
            Debug.Log("KAZANDIN");
            PlayerPrefs.SetInt("painted", 0);
            PlayerPrefs.SetInt("level", PlayerPrefs.GetInt("level") + 1);
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
            player.transform.DOMoveZ(6.5f, 0.1f);


        }
        if (PlayerPrefs.GetInt("painted") == levelpainted && PlayerPrefs.GetInt("level") == 4)
        {
            Debug.Log("KAZANDIN");
            PlayerPrefs.SetInt("painted", 0);
            PlayerPrefs.SetInt("level", PlayerPrefs.GetInt("level") + 1);
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
            player.transform.DOMoveZ(4.5f, 0.1f);


        }
        if (PlayerPrefs.GetInt("painted") == levelpainted && PlayerPrefs.GetInt("level") == 5)
        {
            Debug.Log("OYUN BİTTİ");
            PlayerPrefs.SetInt("painted", 0);
            PlayerPrefs.SetInt("level", PlayerPrefs.GetInt("level") + 1);
            rb.constraints = RigidbodyConstraints.FreezePosition;
            transform.GetChild(0).gameObject.SetActive(true);
            transform.GetChild(1).gameObject.SetActive(true);
            transform.GetChild(2).gameObject.SetActive(true);
            transform.GetChild(3).gameObject.SetActive(true);
            player.transform.DOMoveY(4f, 0.5f).SetEase(movement).OnComplete(() =>
            {
                player.transform.DOMoveY(0.5f, 0.5f).SetEase(movement).OnComplete(() =>
                {
                    Debug.Log("çalıştı");
                    StartCoroutine(ExampleCoroutine5());
                });


            });
            player.transform.DOMoveZ(6.5f, 0.1f);
            

        }
        if (PlayerPrefs.GetInt("painted") == levelpainted && PlayerPrefs.GetInt("level") == 6)
        {
            Debug.Log("OYUN BİTTİ");
            PlayerPrefs.SetInt("painted", 0);
            PlayerPrefs.SetInt("level", PlayerPrefs.GetInt("level") + 1);
            rb.constraints = RigidbodyConstraints.FreezePosition;
            transform.GetChild(0).gameObject.SetActive(true);
            transform.GetChild(1).gameObject.SetActive(true);
            transform.GetChild(2).gameObject.SetActive(true);
            transform.GetChild(3).gameObject.SetActive(true);
            player.transform.DOMoveY(4f, 0.5f).SetEase(movement).OnComplete(() =>
            {
                player.transform.DOMoveY(0.5f, 0.5f).SetEase(movement).OnComplete(() =>
                {
                    //StartCoroutine(ExampleCoroutine5());
                });


            });
            player.transform.DOMoveZ(4.5f, 0.1f);


        }
    }
    //public void ChangeScene()
    //{
    //    if (PlayerPrefs.GetInt("level") == 2)
    //    {
    //        SceneManager.LoadScene("Level2");
    //    }
    //    if (PlayerPrefs.GetInt("level") == 3)
    //    {
    //        SceneManager.LoadScene("Level2");
    //    }
    //    if (PlayerPrefs.GetInt("level") == 4)
    //    {
    //        SceneManager.LoadScene("Level2");
    //    }
    //    if (PlayerPrefs.GetInt("level") == 5)
    //    {
    //        SceneManager.LoadScene("Level2");
    //    }

    //}

    IEnumerator ExampleCoroutine()
    {

        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Level2");
    }
    IEnumerator ExampleCoroutine2()
    {

        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Level3");
    }
    IEnumerator ExampleCoroutine3()
    {

        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Level4");
    }
    IEnumerator ExampleCoroutine4()
    {

        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Level5");
    }
    IEnumerator ExampleCoroutine5()
    {

        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Level6");
    }
}
