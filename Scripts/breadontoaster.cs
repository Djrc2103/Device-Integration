using UnityEngine;
using System.Collections;

public class breadontoaster : MonoBehaviour {

    public Colliding takeslices;
    public float touched = 0.0f;
    public float toastcoll = 1.0f;
    public bool breadon = false;
    public static GameObject slicenumber;
    public Material donecolor;
    public Material burncolor;
    public static bool burnt = false;
    public bool burnt2 = false;
    public bool done2 = false;
    public AudioSource[] sounds;
    public AudioSource source;
    public AudioSource source2;
    public bool set = true;
    public int i = 0;


    void Awake()
    {
        sounds = GetComponents<AudioSource>();
        source = sounds[0];
        source2 = sounds[1];
    }


    // Update is called once per frame
    void Update () {

        if ( breadon == true && toasterbutton.toasbtn == true)
        {
            touched += toastcoll * Time.deltaTime;
            if (touched >= 5)
            {
                slicenumber.GetComponent<Renderer>().material = donecolor;
                burnt = false;
                
                if (done2 == false)
                {
                    source2.Play();
                    done2 = true;
                }
            }
            if (touched >= 15)
            {
                
                slicenumber.GetComponent<Renderer>().material = burncolor;
                burnt = true;
                
                if (set == true)
                {
                    next.lvl3Score -= 10;
                    set = false;
                }
                
                if (burnt2 == false)
                {
                    source.Play();
                    burnt2 = true;
                }
                
            }
            
        }
       
    }

    void OnCollisionEnter(Collision col)
    {
        if (takeslices.inputobjects.Contains(col.gameObject) && Colliding.coltimer == 0 && col.gameObject.name != "breadknife" && breadon == false)
        {
            slicenumber = col.gameObject;
            col.gameObject.transform.parent = null;
            col.gameObject.transform.position = new Vector3(Position.xtr, -3.64f, 10.5F);
            col.gameObject.transform.eulerAngles = new Vector3(0, 0, 90);
            Colliding.coltimer = 100;
            breadon = true;
            i++;
            if (i < 5)
            {
                next.lvl3Score += 10;
            }
        }


    
    }

    void OnCollisionExit(Collision col)
    {
        if (col.gameObject == slicenumber)
        {
            breadon = false;
            touched = 0.0f;
            burnt2 = false;
            done2 = false;
            set = true;
        }
        source.Stop();
    }
}
