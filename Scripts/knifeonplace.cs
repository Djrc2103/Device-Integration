using UnityEngine;
using System.Collections;

public class knifeonplace : MonoBehaviour {

    public static int knifetimer;
    //public cutbread takeslices;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (knifetimer > 0)
        {
            knifetimer--;
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if ( col.gameObject.name=="breadknife" && knifetimer == 0 && Colliding.coltimer == 0)
        {
            col.gameObject.transform.parent = null;
            col.gameObject.transform.position = new Vector3(2.14f, -3.15f, 10.78F);
            col.gameObject.transform.eulerAngles = new Vector3(90, 0, 0);
            knifetimer = 500;
            Colliding.coltimer = 100;
        }
    }


}
