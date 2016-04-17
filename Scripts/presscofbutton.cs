using UnityEngine;
using System.Collections;

public class presscofbutton : MonoBehaviour {

    public Material changebutton;
    public Material initialcolor;
    private int btntimer;
    public static bool fillwithcoffee = false;
    public GameObject liquid;
    public float touched = 0.0f;
    public float watercollider = 1.0f;
    public static bool coffeerecfilled = false;
    public bool morewater = true;
    public ParticleSystem coffee;
    public bool set = true;



    // Use this for initialization
    void Start() {
        liquid = GameObject.Find("coffeeliquid");
        initialcolor = gameObject.GetComponent<Renderer>().material;
    }


    // Update is called once per frame
    void Update() {
        if (btntimer > 0)
        {
            btntimer--;
        }

        if (fillwithcoffee == true && closelid.closedlid == true && waterpouring.machineisfull == true)
        {
            
            touched += watercollider * Time.deltaTime;
            if (touched <= 5 && morewater == true)
            {
                
                liquid.transform.localScale += new Vector3(0, 0.001f, 0);
                coffee.Play();
            }

            if (touched > 5)
            {
                morewater = false;
                coffeerecfilled = true;
                coffee.Stop();

                if (set == true)
                {
                    GameObject.Find("coffeerec").GetComponent<Collider>().enabled = true;
                    next.lvl1Score += 10;
                    set = false;
                }
            }

        }



        
    }



    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "palm" && btntimer==0 && col.gameObject.transform.childCount == 0)
        {
            buttontoggle();
            btntimer = 200;

         }

    }

    void buttontoggle()
    {
        if (gameObject.GetComponent<Renderer>().material == initialcolor)
        {
            gameObject.GetComponent<Renderer>().material = changebutton;
            fillwithcoffee = true;
        }

        else
        {
            gameObject.GetComponent<Renderer>().material = initialcolor;
            fillwithcoffee = false;
            
        }

    }




}
