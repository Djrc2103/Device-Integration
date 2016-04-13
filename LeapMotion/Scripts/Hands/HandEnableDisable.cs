using UnityEngine;
using System.Collections;
using Leap;

public class HandEnableDisable : HandTransitionBehavior {

    public GameObject inhand;
    public Vector3 pos;

	protected override void HandReset() {
        gameObject.SetActive(true);

        /*if (inhand != null)
        {
            //inhand.transform.position = GameObject.Find("palm").transform.position;
            //inhand.transform.parent = GameObject.Find("palm").transform;
            inhand.transform.localPosition = pos;
            
        }*/

    }

	// Use this for initialization
	protected override void HandFinish () {
        

       /* if (GameObject.Find("palm").transform.childCount != 0)
        {

            inhand = GameObject.Find("palm").transform.GetChild(0).gameObject;
            //pos = inhand.transform.localPosition;
            pos = new Vector3(inhand.transform.localPosition.x, inhand.transform.localPosition.y, inhand.transform.localPosition.z);
        }*/
        

            gameObject.SetActive(false);

        
   
    }
	
}
