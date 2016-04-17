using UnityEngine;
using System.Collections;

public class waterpouring : MonoBehaviour {

    public float touched = 0.0f;
    public static bool machineisfull = false;
    public float watercollider = 1.0f;
    public bool morewater = true;
    public GameObject liquid;
    public ParticleSystem water2;
    private AudioSource source;
    public bool set = true;



    // Use this for initialization
    void Start () {
        //liquid = GameObject.Find("liquid");
    }
	
	// Update is called once per frame
	void Update () {


    }

    void Awake()
    {
        source = GetComponent<AudioSource>();
    }


    void OnCollisionStay(Collision col)
    {
        if (col.gameObject.name == "waterglass" && fillglass.glassisfull == true && closelid.closedlid == false)
        {
            touched += watercollider * Time.deltaTime;
            if (touched <= 5 && morewater == true)
            {
                liquid.transform.localScale -= new Vector3(0, 0.002f, 0);
                water2.Play();
            }

            if (touched > 5)
            {
                morewater = false;
                machineisfull = true;
                water2.Stop();
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
        if (col.gameObject.name == "waterglass" && fillglass.glassisfull == true && closelid.closedlid == false && machineisfull == false)
        {
            source.Play();
        }
    }


    void OnCollisionExit(Collision col)
    {
        if (col.gameObject.name == "waterglass")
        {
            water2.Stop();
            source.Stop();
        }
    }

}
