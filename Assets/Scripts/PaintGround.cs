using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;


public class PaintGround : MonoBehaviour
{


    public Material currentcolor;
    public Material nextcolor;

    public ParticleSystem part;


    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("painted")) { 
            PlayerPrefs.SetInt("painted", 0); 
        }
        PlayerPrefs.SetInt("painted", 0);

        
        currentcolor = GetComponent<MeshRenderer>().material;
        part = GetComponentInChildren<ParticleSystem>();



    }

    // Update is called once per frame
    void Update()
    {

        

    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag=="player"&& currentcolor!=nextcolor)
        {
            currentcolor.DOColor(nextcolor.color, 0.1f);
            currentcolor = nextcolor;
            PlayerPrefs.SetInt("painted", PlayerPrefs.GetInt("painted") + 1);

        }
        if (other.gameObject.tag == "player")
        {

            part.Play();

        }

    }

 
    


}
