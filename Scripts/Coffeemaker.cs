using UnityEngine;
using System.Collections;

public class Coffeemaker : MonoBehaviour {

    public GameObject coffeemachine;
    public GameObject waterglass;
    public GameObject glassplace;
    public ParticleSystem water;
    private int taptimer;
    private AudioSource source;
    public static bool wateron = false;

    void Awake()
    {
        source = GetComponent<AudioSource>();
    }


    void Start () {

        //---objects---\\
        coffeemachine = GameObject.Find("Coffeemachine");
        waterglass = GameObject.Find("waterglass");
        glassplace = GameObject.Find("glassplace");

        //----add coffee machine, water glass in proper pos-----\\
        waterglass.transform.position = new Vector3(Position.xtr, -3.67f, 10.5F);
        coffeemachine.transform.position = new Vector3(Position.xtl, -3.76f, 10.5F);
        glassplace.transform.position = new Vector3(Position.xtr, -3.74f, 10.5f);

    }
	

	void Update () {
        if (taptimer > 0)
        {
            taptimer--;
        }
    }


    void OnCollisionEnter (Collision col)
    {
        if (col.gameObject.name == "palm" && taptimer==0 && col.gameObject.transform.childCount == 0)
        {
            
                taptoggle();
                taptimer = 200;
        }
    }



    void taptoggle()
    {
        if (water.isPlaying)
        {

            source.Stop();
            wateron = false;
            water.Stop();
            water.transform.GetComponent<Collider>().enabled = false;
        }
        else
        {
            wateron = true;
            source.Play();
            water.Play();
            water.transform.GetComponent<Collider>().enabled = true;
        }
    }

}
