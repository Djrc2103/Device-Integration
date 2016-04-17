using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Colliding : MonoBehaviour {

    public List<GameObject> inputobjects;
    //public static bool coffeeon;
    public static bool tapon = false;
    public static int coltimer;
    //public PlaceObj mplaceobj;
    //public static GameObject cup;

	void Start () {
        //cup = GameObject.Find("cup");
	
	}

    void Update()
    {
        if (coltimer > 0)
        {
            coltimer--;
        }
    }
	

	void OnCollisionEnter (Collision col) {

        //if (mplaceobj.collideorder.Contains(col.gameObject))
        if (inputobjects.Contains(col.gameObject) && col.gameObject.name!="breadknife" && col.gameObject.name!="coffeerec")
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
                col.gameObject.transform.position = col.gameObject.transform.parent.TransformPoint(origx, -origy*2, origz*1.5f);
                coltimer = 120;

            }
        }

        if (col.gameObject.name == "coffeerec")
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
                col.gameObject.transform.position = col.gameObject.transform.parent.TransformPoint(origx, -origy * 4, origz * 1.5f);
                coltimer = 120;

            }
        }

        /*if (HandEnableDisable.objectdel==true && HandEnableDisable.handflag==true)
        {
            float origz = col.gameObject.transform.lossyScale.z;
            float origx = col.gameObject.transform.lossyScale.x;
            float origy = col.gameObject.transform.lossyScale.y;
         
            HandEnableDisable.inhand.gameObject.transform.parent = gameObject.transform;
            //col.gameObject.transform.localRotation = originalRot;
            HandEnableDisable.inhand.gameObject.transform.position = col.gameObject.transform.parent.TransformPoint(origx, -origy * 2, origz * 1.5f);
            //HandEnableDisable.inhand.GetComponent<Renderer>().enabled = true;
            HandEnableDisable.objectdel = false;
            HandEnableDisable.handflag = false;
        }*/

    }



}
