using UnityEngine;
using System.Collections;

public class reclabelstick : MonoBehaviour {

    public bool set = true;
    public int setscore;
    //public randomrecipeez rightlist;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (gameObject.transform.childCount != 0)
        {
            gameObject.transform.GetComponent<Collider>().enabled = false;
        }
    }

    void OnCollisionEnter(Collision col)
    {
        //if (rightlist.easyl1.Contains(col.gameObject) || rightlist.easyl2.Contains(col.gameObject) || rightlist.easyl3.Contains(col.gameObject))
        if(col.gameObject.name == "E1" || col.gameObject.name == "E2" || col.gameObject.name == "E3")
        {

            Colliding.coltimer = 60;
            col.gameObject.transform.parent = null;
            if (col.gameObject.transform.parent == null)
            {
                next.lvl5Score += setscore;
            }
            
            //var originalScale = col.gameObject.transform.lossyScale;
            col.gameObject.transform.parent = gameObject.transform;
            col.gameObject.transform.GetComponent<Collider>().enabled = false;
            
            
            var originalRot = new Vector3(90, -180, 0);
            
            col.gameObject.transform.eulerAngles = originalRot;
            col.gameObject.transform.localPosition = new Vector3(0, 0, 0);

            
        }

        if (col.gameObject.name == "W1" || col.gameObject.name == "W2" || col.gameObject.name == "W3")
        {
            if (set == true)
            {
                next.lvl5Score -= 10;
                set = false;
            }
            
        }
    }

    void OnCollisionExit(Collision col)
    {
        set = true;
    }

}
