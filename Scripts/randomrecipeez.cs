using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class randomrecipeez : MonoBehaviour {

    public List<GameObject> easyl1;
    public List<GameObject> easyl2;
    public List<GameObject> easyl3;
    public GameObject label1pic;
    public GameObject label2pic;
    public GameObject label3pic;
    public GameObject label1name;
    public GameObject label2name;
    public GameObject label3name;


    // Use this for initialization
    void Start () {
        
        int k = Random.Range(0,3);

        if (k == 0)
        {
            label1name.transform.position = new Vector3(1.98f, -2.90f,10.6f);
            label1pic.transform.position = new Vector3(1.98f, -3.24f, 10.61f);
            for (float i = Position.xtl; i <= Position.xtr + 0.1f; i = i + ((Position.xtr - Position.xtl) / 4))
            {
                //for (float j = 10.1f; j < 10.6f; j = j + 0.2f)
                //{
                    int randl = Random.Range(0, easyl1.Count);
                    easyl1[randl].transform.position = new Vector3(i, -3.737f, 10.348f);
                    easyl1.RemoveAt(randl);
                //}
            }
        }

        if (k == 1)
        {
            label2name.transform.position = new Vector3(1.98f, -2.90f, 10.6f);
            label2pic.transform.position = new Vector3(1.98f, -3.24f, 10.61f);
            for (float i = Position.xtl; i <= Position.xtr + 0.1f; i = i + ((Position.xtr - Position.xtl) / 4))
            {
                //for (float j = 10.1f; j < 10.6f; j = j + 0.2f)
                //{
                int randl = Random.Range(0, easyl2.Count);
                easyl2[randl].transform.position = new Vector3(i, -3.737f, 10.348f);
                easyl2.RemoveAt(randl);
                //}
            }
        }

        if (k == 2)
        {
            label3name.transform.position = new Vector3(1.98f, -2.90f, 10.6f);
            label3pic.transform.position = new Vector3(1.98f, -3.24f, 10.61f);

            for (float i = Position.xtl; i <= Position.xtr + 0.1f; i = i + ((Position.xtr - Position.xtl) / 4))
            {
                //for (float j = 10.1f; j < 10.6f; j = j + 0.2f)
                //{
                int randl = Random.Range(0, easyl3.Count);
                easyl3[randl].transform.position = new Vector3(i, -3.737f, 10.348f);
                easyl3.RemoveAt(randl);
                //}
            }
        }


    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
