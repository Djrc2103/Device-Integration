using UnityEngine;
using System.Collections;

public class knifetohand : MonoBehaviour {
    public int coltimer;
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
        if (col.gameObject.name=="palm" && col.gameObject.transform.childCount == 0 && coltimer == 0)
        {
            gameObject.transform.parent = null;
            gameObject.transform.parent = col.gameObject.transform;
            gameObject.transform.localPosition = new Vector3(0.2f, -2.0f, 2.6f);
            gameObject.transform.eulerAngles = new Vector3(0, 0, 90);
            coltimer = 100;
            knifeonplace.knifetimer = 150;

        }
    }

}
