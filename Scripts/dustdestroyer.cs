using UnityEngine;
using System.Collections;

public class dustdestroyer : MonoBehaviour {

    public float thiscollider = 1.0f;
    public float touched1 = 0.0f;
    // Use this for initialization
    public int cutup;
    public int oldpos;
    public int fivechanges;
    public int anotherflag;

    void Start () {
        anotherflag = 0;
        fivechanges = 0;
        oldpos = 0;
    }
	
	// Update is called once per frame
	void Update () {

       /* if (cutup== 1)
        { print("leftie");
        }

        if (cutup == -1)
        {
            print("rightie");
        }
        //print(cutup);*/
        if (gameObject.name == "Dust(Clone)")
        {
            if (fivechanges == 5)
            {
                next.lvl4Score += 10;
                fivechanges = 0;
                Destroy(gameObject);
                
            }
        }

        if (gameObject.name == "Dust2(Clone)")
        {
            if (fivechanges == 10)
            {
                next.lvl4Score += 20;
                fivechanges = 0;
                Destroy(gameObject);
                
            }
        }

        if (gameObject.name == "Dust3(Clone)")
        {
            if (fivechanges == 15)
            {
                next.lvl4Score += 30;
                fivechanges = 0;
                Destroy(gameObject);
                
            }
        }
        if (oldpos < cutup)
        {
            print("cutup");
            fivechanges++;
            
        }
        if (oldpos > cutup)
        {
            print("cutdown");
            fivechanges++;

        }
        oldpos = cutup;



    }

    void OnCollisionStay(Collision col)
    {
        if (col.gameObject.name == "cloth")
        {
            //touched1 += thiscollider * Time.deltaTime;
            //if (touched1 >= 3)
            if ((col.gameObject.transform.position.x < gameObject.transform.position.x-0.07f) || (col.gameObject.transform.position.z < gameObject.transform.position.z - 0.07f))
            {
                cutup = 1;
                //print(cutup);
            }
            if ((col.gameObject.transform.position.x > gameObject.transform.position.x+0.07f) || (col.gameObject.transform.position.z > gameObject.transform.position.z + 0.07f))
            {
                cutup = -1;
                //print(cutup);
            }
        }

    }

}
