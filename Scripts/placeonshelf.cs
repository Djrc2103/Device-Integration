using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class placeonshelf : MonoBehaviour {

    public PlaceObj mplaceobj;
    public List<GameObject> inputobjects;
    public float yscale;
    public float zscale;
    public int setscore;

    // Use this for initialization
    void Start () {
        //gameObject.transform.parent = null;
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    void OnCollisionEnter(Collision col)
    {

        if (inputobjects.Contains(col.gameObject))
        {
            if (gameObject.transform.childCount == 0)
            {
                Colliding.coltimer = 100;
                yscale = ((3.5f - Position.maxcoordy) / 3 - col.gameObject.transform.lossyScale.y)/2;
                
                col.gameObject.transform.GetComponent<Collider>().enabled = false;
                var originalScale = col.gameObject.transform.lossyScale;
                var originalRot = new Vector3(0, 0, 0);
                col.gameObject.transform.parent = null;
                col.gameObject.transform.parent = gameObject.transform;
                
                col.gameObject.transform.eulerAngles = originalRot;
                if ((3.5f - Position.maxcoordy) / 3 > col.gameObject.transform.lossyScale.y)
                {
                    col.gameObject.transform.localPosition = new Vector3(0, yscale-0.1f, zscale);
                }
                if ((3.5f - Position.maxcoordy) / 3 <= col.gameObject.transform.lossyScale.y)
                {
                    col.gameObject.transform.localPosition = new Vector3(0, 0, zscale);
                    if (col.gameObject.name == "Mayo")
                    {
                        col.gameObject.transform.localPosition = new Vector3(0, -0.03f, zscale);
                    }
                }
                col.gameObject.transform.parent = null;
                col.gameObject.transform.localScale = originalScale;
                gameObject.transform.GetComponent<Collider>().enabled = false;
                next.lvl2Score += setscore;


                //---place 3by3 colliders for the rest of the columns---\\
                mplaceobj.columncounter--;
                if(mplaceobj.columncounter ==0)
                {
                    mplaceobj.nextcolumn();
                }
            }

        }

    }



}
