using UnityEngine;
using System.Collections;

public class fillglass : MonoBehaviour {
    
    public float touched = 0.0f;
    public float watercollider = 1.0f;
    public GameObject liquid;
    public static bool glassisfull = false;
    public bool morewater = true;
    public bool set = true;

    //public AudioClip waterpour;
    // Use this for initialization
    private AudioSource source;

    void Start () {
        liquid = GameObject.Find("liquid");

    }


    void Update()
    {


    }

    void Awake()
    {
        source = GetComponent<AudioSource>();
    }


    void OnCollisionStay(Collision col)
    {
        if (col.gameObject.name == "waterflow" && Coffeemaker.wateron == true)
        {
            //source.Play();
            touched += watercollider * Time.deltaTime;
            
            if (touched <= 5 && morewater == true)
            {
                liquid.transform.localScale += new Vector3(0, 0.002f, 0);
            }

            if (touched >5)
            {
                morewater = false;
                glassisfull = true;
                if (set == true)
                {
                    next.lvl1Score += 10;
                    set = false;
                }

            }
        }

        //---fill glass after 5 sec---\\

    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "waterflow" && Coffeemaker.wateron == true && glassisfull == false)
        {
            source.Play();
        }
    }

    void OnCollisionExit(Collision col)
    {
        if (col.gameObject.name == "waterflow" && Coffeemaker.wateron == true)
        {
            source.Stop();
        }
    }

}
