using UnityEngine;
using System.Collections;

public class closelid : MonoBehaviour {

    public static bool closedlid = false;
    public GameObject lid;
    public int lidtimer;

	// Use this for initialization
	void Start () {

        lid = GameObject.Find("lid");
	}
	
	// Update is called once per frame
	void Update () {
	    if (lidtimer > 0)
        {
            lidtimer--;
        }
	}

    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.name == "palm" && col.gameObject.transform.childCount == 0 && Colliding.coltimer==0 && lidtimer == 0)
        {
            if(closedlid == false)
            {
                Colliding.coltimer = 70;
                closedlid = true;
                lid.transform.eulerAngles = new Vector3(90, 0, 0);
                lidtimer = 300;
            }
            else
            {
                Colliding.coltimer = 70;
                closedlid = false;
                lid.transform.eulerAngles = new Vector3(-45, 0, 0);
            }

        }

    }

}
