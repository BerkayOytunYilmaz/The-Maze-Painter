using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PanelManager : MonoBehaviour
{

    public GameObject level;
    public Text leveltext;


    // Start is called before the first frame update
    void Start()
    {
        leveltext = level.GetComponent<Text>();
        leveltext.text = "Level " + PlayerPrefs.GetInt("fakelevel");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
