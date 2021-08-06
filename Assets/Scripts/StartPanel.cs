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
    public Button level2;
    public Button level3;
    public Button level4;
    public Button level5;
    public Button level6;
    public Button level7;
    public Button level8;
    public Button level9;
    public Button level10a;
    public Button level10b;
    public Button level11a;
    public Button level11b;
    public Button level12a;
    public Button level12b;

    public GameObject play;
    public GameObject level1starmanager;
    public GameObject level2starmanager;
    public GameObject level3starmanager;
    public GameObject level4starmanager;
    public GameObject level5starmanager;
    public GameObject level6starmanager;
    public GameObject level7starmanager;
    public GameObject level8starmanager;
    public GameObject level9starmanager;
    public GameObject level10starmanager;
    public GameObject level11starmanager;
    public GameObject level12starmanager;

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

        RealStarPlayerPrebs();

        if (!PlayerPrefs.HasKey("level"))
        {
            PlayerPrefs.SetInt("level", 1);
        }


        PlayerPrefs.SetInt("fakelevel", 1);
        //FakeLevel = When Player want to play old level, It been sets because of orj level is not be forgotten.

        PanelSetactive();
        StartSceneStars();

    }

    // Update is called once per frame
    public void Level1()
    {
        PlayerPrefs.SetInt("fakelevel", 1);
        SceneManager.LoadScene("Level1");
        

    }
    public void Level2()
    {
        if (PlayerPrefs.GetInt("level") > 1)
        {
            PlayerPrefs.SetInt("fakelevel", 2);
            SceneManager.LoadScene("Level2");
        }

    }
    public void Level3()
    {
        if (PlayerPrefs.GetInt("level") > 2)
        {
            PlayerPrefs.SetInt("fakelevel", 3);
            SceneManager.LoadScene("Level3");
        }

    }
    public void Level4()
    {
        if (PlayerPrefs.GetInt("level") > 3)
        {
            PlayerPrefs.SetInt("fakelevel", 4);
            SceneManager.LoadScene("Level4");
        }

    }
    public void Level5()
    {
        if (PlayerPrefs.GetInt("level") > 4)
        {
            PlayerPrefs.SetInt("fakelevel", 5);
            SceneManager.LoadScene("Level5");
        }

    }
    public void Level6()
    {
        if (PlayerPrefs.GetInt("level") > 5)
        {
            PlayerPrefs.SetInt("fakelevel", 6);
            SceneManager.LoadScene("Level6");
        }

    }
    public void Level7()
    {
        if (PlayerPrefs.GetInt("level") > 6)
        {
            PlayerPrefs.SetInt("fakelevel", 7);
            SceneManager.LoadScene("Level7");
        }

    }
    public void Level8()
    {
        if (PlayerPrefs.GetInt("level") > 7)
        {
            PlayerPrefs.SetInt("fakelevel", 8);
            SceneManager.LoadScene("Level8");
        }

    }
    public void Level9()
    {
        if (PlayerPrefs.GetInt("level") > 8)
        {
            PlayerPrefs.SetInt("fakelevel", 9);
            SceneManager.LoadScene("Level9");
        }

    }
    public void Level10()
    {
        if (PlayerPrefs.GetInt("level") > 9)
        {
            PlayerPrefs.SetInt("fakelevel", 10);
            SceneManager.LoadScene("Level10");
        }

    }
    public void Level11()
    {
        if (PlayerPrefs.GetInt("level") > 10)
        {
            PlayerPrefs.SetInt("fakelevel", 11);
            SceneManager.LoadScene("Level11");
        }

    }
    public void Level12()
    {
        if (PlayerPrefs.GetInt("level") > 11)
        {
            PlayerPrefs.SetInt("fakelevel", 12);
            SceneManager.LoadScene("Level12");
        }

    }

    public void PanelSetactive()
    {
        if (PlayerPrefs.GetInt("level") > 1)
        {
            level2.interactable = true;
        }
        if (PlayerPrefs.GetInt("level") > 2)
        {
            level3.interactable = true;
        }
        if (PlayerPrefs.GetInt("level") > 3)
        {
            level4.interactable = true;
        }
        if (PlayerPrefs.GetInt("level") > 4)
        {
            level5.interactable = true;
        }
        if (PlayerPrefs.GetInt("level") > 5)
        {
            level6.interactable = true;
        }
        if (PlayerPrefs.GetInt("level") > 6)
        {
            level7.interactable = true;
        }
        if (PlayerPrefs.GetInt("level") > 7)
        {
            level8.interactable = true;
        }
        if (PlayerPrefs.GetInt("level") > 8)
        {
            level9.interactable = true;
        }
        if (PlayerPrefs.GetInt("level") > 9)
        {
            level10a.interactable = true;
            level10b.interactable = true;
        }
        if (PlayerPrefs.GetInt("level") > 10)
        {
            level11a.interactable = true;
            level11b.interactable = true;
        }
        if (PlayerPrefs.GetInt("level") > 11)
        {
            level12a.interactable = true;
            level12b.interactable = true;
        }


    }
    public void RealStarPlayerPrebs()
    {
        if (!PlayerPrefs.HasKey("level1star"))
        {
            PlayerPrefs.SetInt("level1star", 0);
        }
        if (!PlayerPrefs.HasKey("level2star"))
        {
            PlayerPrefs.SetInt("level2star", 0);
        }
        if (!PlayerPrefs.HasKey("level3star"))
        {
            PlayerPrefs.SetInt("level3star", 0);
        }
        if (!PlayerPrefs.HasKey("level4star"))
        {
            PlayerPrefs.SetInt("level4star", 0);
        }
        if (!PlayerPrefs.HasKey("level5star"))
        {
            PlayerPrefs.SetInt("level5star", 0);
        }
        if (!PlayerPrefs.HasKey("level6star"))
        {
            PlayerPrefs.SetInt("level6star", 0);
        }
        if (!PlayerPrefs.HasKey("level7star"))
        {
            PlayerPrefs.SetInt("level7star", 0);
        }
        if (!PlayerPrefs.HasKey("level8star"))
        {
            PlayerPrefs.SetInt("level8star", 0);
        }
        if (!PlayerPrefs.HasKey("level9star"))
        {
            PlayerPrefs.SetInt("level9star", 0);
        }
        if (!PlayerPrefs.HasKey("level10star"))
        {
            PlayerPrefs.SetInt("level10star", 0);
        }
        if (!PlayerPrefs.HasKey("level11star"))
        {
            PlayerPrefs.SetInt("level11star", 0);
        }
        if (!PlayerPrefs.HasKey("level12star"))
        {
            PlayerPrefs.SetInt("level12star", 0);
        }

    }

    public void StartSceneStars()
    {
        if (PlayerPrefs.GetInt("level1star")>0)
        {
            level1starmanager.transform.GetChild(3).gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("level1star") > 1)
        {
            level1starmanager.transform.GetChild(5).gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("level1star") > 2)
        {
            level1starmanager.transform.GetChild(4).gameObject.SetActive(false);
        }


        if (PlayerPrefs.GetInt("level2star") > 0)
        {
            level2starmanager.transform.GetChild(3).gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("level2star") > 1)
        {
            level2starmanager.transform.GetChild(5).gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("level2star") > 2)
        {
            level2starmanager.transform.GetChild(4).gameObject.SetActive(false);
        }


        if (PlayerPrefs.GetInt("level3star") > 0)
        {
            level3starmanager.transform.GetChild(3).gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("level3star") > 1)
        {
            level3starmanager.transform.GetChild(5).gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("level3star") > 2)
        {
            level3starmanager.transform.GetChild(4).gameObject.SetActive(false);
        }


        if (PlayerPrefs.GetInt("level4star") > 0)
        {
            level4starmanager.transform.GetChild(3).gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("level4star") > 1)
        {
            level4starmanager.transform.GetChild(5).gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("level4star") > 2)
        {
            level4starmanager.transform.GetChild(4).gameObject.SetActive(false);
        }


        if (PlayerPrefs.GetInt("level5star") > 0)
        {
            level5starmanager.transform.GetChild(3).gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("level5star") > 1)
        {
            level5starmanager.transform.GetChild(5).gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("level5star") > 2)
        {
            level5starmanager.transform.GetChild(4).gameObject.SetActive(false);
        }


        if (PlayerPrefs.GetInt("level6star") > 0)
        {
            level6starmanager.transform.GetChild(3).gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("level6star") > 1)
        {
            level6starmanager.transform.GetChild(5).gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("level6star") > 2)
        {
            level6starmanager.transform.GetChild(4).gameObject.SetActive(false);
        }


        if (PlayerPrefs.GetInt("level7star") > 0)
        {
            level7starmanager.transform.GetChild(3).gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("level7star") > 1)
        {
            level7starmanager.transform.GetChild(5).gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("level7star") > 2)
        {
            level7starmanager.transform.GetChild(4).gameObject.SetActive(false);
        }


        if (PlayerPrefs.GetInt("level8star") > 0)
        {
            level8starmanager.transform.GetChild(3).gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("level8star") > 1)
        {
            level8starmanager.transform.GetChild(5).gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("level8star") > 2)
        {
            level8starmanager.transform.GetChild(4).gameObject.SetActive(false);
        }


        if (PlayerPrefs.GetInt("level9star") > 0)
        {
            level9starmanager.transform.GetChild(3).gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("level9star") > 1)
        {
            level9starmanager.transform.GetChild(5).gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("level9star") > 2)
        {
            level9starmanager.transform.GetChild(4).gameObject.SetActive(false);
        }


        if (PlayerPrefs.GetInt("level10star") > 0)
        {
            level10starmanager.transform.GetChild(3).gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("level10star") > 1)
        {
            level10starmanager.transform.GetChild(5).gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("level10star") > 2)
        {
            level10starmanager.transform.GetChild(4).gameObject.SetActive(false);
        }


        if (PlayerPrefs.GetInt("level11star") > 0)
        {
            level11starmanager.transform.GetChild(3).gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("level11star") > 1)
        {
            level11starmanager.transform.GetChild(5).gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("level11star") > 2)
        {
            level11starmanager.transform.GetChild(4).gameObject.SetActive(false);
        }


        if (PlayerPrefs.GetInt("level12star") > 0)
        {
            level12starmanager.transform.GetChild(3).gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("level12star") > 1)
        {
            level12starmanager.transform.GetChild(5).gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("level12star") > 2)
        {
            level12starmanager.transform.GetChild(4).gameObject.SetActive(false);
        }
    }

}
