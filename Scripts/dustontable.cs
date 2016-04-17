using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class dustontable : MonoBehaviour {

    public List<GameObject> inputobjects;
    public int k;
    public float touched1 = 0.0f;
    public float touched2 = 0.0f;
    public float touched3 = 0.0f;
    public float thiscollider = 1.0f;
    public GameObject cloth;

    // Use this for initialization
    void Start () {

        cloth.transform.position = new Vector3(Position.xtr, -3.729f, 10.4f);

        for (float i = Position.xtl+0.1f; i <= Position.xtr - 0.1f; i = i + 0.2f)
        {
            for (float j = 10.35f; j < 10.75f; j = j + 0.2f)
            {
                k = Random.Range(0, inputobjects.Count);
                Instantiate(inputobjects[k], new Vector3(i, -3.7307f, j), Quaternion.identity);
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}

   /* void OnCollisionStay(Collision col)
    {
            if (col.gameObject.name=="Dust" || col.gameObject.name=="Dust(Clone)")
            {
                touched1 += thiscollider * Time.deltaTime;
                if (touched1 >=3)
                {
                    Destroy(col.gameObject);
                    touched1 = 0.0f;
                }
            }

            if (col.gameObject.name == "Dust2" || col.gameObject.name == "Dust2(Clone)")
            {
                touched2 += thiscollider * Time.deltaTime;
                if (touched2 >= 5)
                {
                    Destroy(col.gameObject);
                    touched2 = 0.0f;
                }
            }

            if (col.gameObject.name == "Dust3" || col.gameObject.name == "Dust3(Clone)")
            {
                touched3 += thiscollider * Time.deltaTime;
                if (touched3 >= 7)
                {
                    Destroy(col.gameObject);
                    touched3 = 0.0f;
                }
            }
    }*/
}
