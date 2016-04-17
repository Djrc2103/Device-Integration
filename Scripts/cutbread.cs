using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class cutbread : MonoBehaviour {

    public List<GameObject> inputobjects;
    public GameObject toaster;
    public Colliding addbread;
    public Colliding addbread2;
    public GameObject plate;
    public GameObject plate2;
    public GameObject plate3;
    public GameObject plate4;
    public GameObject bin;
    public bool set = true;
    public int cutup;
    public int oldpos;
    public int fivechanges;
    public bool dodestroy = true;

    // Use this for initialization
    void Start () {

        fivechanges = 0;
        oldpos = 0;
        toaster = GameObject.Find("Toaster");
        toaster.transform.position = new Vector3(Position.xtr, -3.72f, 10.5F);
        plate.transform.position = new Vector3(Position.xtl+0.2f, -3.722f, 10.69F);
        plate2.transform.position = new Vector3(Position.xtl+0.2f, -3.722f, 10.49F);
        plate3.transform.position = new Vector3(Position.xtl+0.2f, -3.722f, 10.29F);
        plate4.transform.position = new Vector3(Position.xtl+0.4f, -3.722f, 10.5F);
        bin = GameObject.Find("bin");
        bin.transform.position = new Vector3(Position.xtl+0.1f, -4.68f, 9.33f);
    }
	
	// Update is called once per frame
	void Update () {

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
        if (fivechanges == 5)
        {
            addbread.inputobjects.Add(inputobjects[0]);
            addbread2.inputobjects.Add(inputobjects[0]);
            inputobjects[0].transform.eulerAngles = new Vector3(0,0,-90);
            inputobjects.RemoveAt(0);
            fivechanges = 0;
            set = true;
            if (inputobjects.Count > 5)
            {
                if (set == true)
                {
                    next.lvl3Score += 10;
                    set = false;
                }
                
            }
            
            
        }
    }


    void OnCollisionStay(Collision col)
    {
        if (inputobjects.Contains(col.gameObject))
        {
            if (gameObject.transform.position.z < 10.3f)
            {
                cutup = 2;
            }
            if (gameObject.transform.position.z > 10.4f)
            {
                cutup = 1;
            }
        }
    }
}
