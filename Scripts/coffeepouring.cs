using UnityEngine;
using System.Collections;

public class coffeepouring : MonoBehaviour {

    // Use this for initialization
    public float touched = 0.0f;
    public static bool cupisfull = false;
    public float watercollider = 1.0f;
    public bool morewater = true;
    public GameObject liquid;
    public GameObject liquid2;
    public ParticleSystem coff2;
    private AudioSource source;
    public bool set = true;


    // Use this for initialization
    void Start()
    {
        //liquid = GameObject.Find("liquid");
    }


    void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionStay(Collision col)
    {
        if (col.gameObject.name == "cup" && presscofbutton.coffeerecfilled == true)
        {
            touched += watercollider * Time.deltaTime;
            if (touched <= 5 && morewater == true)
            {
                liquid.transform.localScale -= new Vector3(0, 0.001f, 0);
                liquid2.transform.localScale += new Vector3(0, 0.001f, 0);
                coff2.Play();
            }

            if (touched > 5)
            {
                morewater = false;
                cupisfull = true;
                coff2.Stop();
                if (set == true)
                {
                    next.lvl1Score += 10;
                    set = false;
                }
            }
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "cup" && presscofbutton.coffeerecfilled == true && cupisfull == false)
        {
            source.Play();
        }

   }

    void OnCollisionExit(Collision col)
    {
        if (col.gameObject.name == "cup")
        {
            source.Stop();
        }

    }




}
