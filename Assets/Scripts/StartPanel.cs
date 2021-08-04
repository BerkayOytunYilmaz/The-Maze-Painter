using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartPanel : MonoBehaviour
{

    public float duration;
    public string mytext;
    public Text txtui;
    string txt = "";
    public string mytext1;
    public Text txtui1;
    string txt2 = "";

    public GameObject play;
    // Start is called before the first frame update
    void Start()
    {
        play.SetActive(false);
        DOTween.To(() => txt, x => txt = x, mytext, duration).OnUpdate(() => txtui.text = txt).OnComplete(() =>
        {

            DOTween.To(() => txt2, x => txt2 = x, mytext1, duration).OnUpdate(() => txtui1.text = txt2).OnComplete(() =>
            {

                play.SetActive(true);

            });




        });

        if (!PlayerPrefs.HasKey("level"))
        {
            PlayerPrefs.SetInt("level", 1);
        }
    }

    // Update is called once per frame
    public void Changescene()
    {
        if (PlayerPrefs.GetInt("level")==1)
        {
            SceneManager.LoadScene("Level1");
        }
        if (PlayerPrefs.GetInt("level") == 2)
        {
            SceneManager.LoadScene("Level2");
        }
        if (PlayerPrefs.GetInt("level") == 3)
        {
            SceneManager.LoadScene("Level3");
        }
        if (PlayerPrefs.GetInt("level") == 4)
        {
            SceneManager.LoadScene("Level4");
        }
        Debug.Log("tıkladı");
        Debug.Log(PlayerPrefs.GetInt("level"));

    }
}