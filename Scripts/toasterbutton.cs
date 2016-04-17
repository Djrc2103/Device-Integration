using UnityEngine;
using System.Collections;

public class toasterbutton : MonoBehaviour {

    public Material changebutton;
    public Material initialcolor;
    public int coltimer;
    public static bool toasbtn = false;

    // Use this for initialization
    void Start () {
        initialcolor = gameObject.GetComponent<Renderer>().material;
    }
	

	// Update is called once per frame
	void Update () {
	
        if (coltimer > 0)
        {
            coltimer--;
        }
	}


    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "palm" && coltimer == 0 && col.gameObject.transform.childCount == 0)
        {
            buttontoggle();
            coltimer = 200;
        }

    }

    void buttontoggle()
    {
        if (gameObject.GetComponent<Renderer>().material == initialcolor)
        {
            gameObject.GetComponent<Renderer>().material = changebutton;
            toasbtn = true;
        }

        else
        {
            gameObject.GetComponent<Renderer>().material = initialcolor;
            toasbtn = false;
        }
    }

}
