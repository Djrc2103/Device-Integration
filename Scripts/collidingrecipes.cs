using UnityEngine;
using System.Collections;

public class collidingrecipes : MonoBehaviour {

    public static int coltimer;

    // Use this for initialization
    void Start () {
	
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

        //if (mplaceobj.collideorder.Contains(col.gameObject))
        if (col.gameObject.name=="E1" || col.gameObject.name == "E2" || col.gameObject.name == "E3" || col.gameObject.name == "W1" || col.gameObject.name == "W2" || col.gameObject.name == "W3")
        {
            if (gameObject.transform.childCount == 0 && coltimer == 0)
            {
                col.gameObject.transform.parent = null;
                float origz = col.gameObject.transform.lossyScale.z;
                float origx = col.gameObject.transform.lossyScale.x;
                float origy = col.gameObject.transform.lossyScale.y;
                //Quaternion originalRot = col.gameObject.transform.rotation;
                //col.gameObject.transform.rotation = gameObject.transform.rotation;
                col.gameObject.transform.parent = gameObject.transform;
                //col.gameObject.transform.localRotation = originalRot;
                col.gameObject.transform.position = col.gameObject.transform.parent.TransformPoint(origx, -origy * 2, origz * 1.5f);
                coltimer = 120;

            }
        }
    }



    }



