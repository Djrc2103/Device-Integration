using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class randomrecipemed : MonoBehaviour {

    public List<GameObject> easyl1;
    public List<GameObject> easyl2;
    public List<GameObject> easyl3;
    public List<GameObject> wrongl1;
    public List<GameObject> wrongl2;
    public List<GameObject> wrongl3;
    public GameObject label1pic;
    public GameObject label2pic;
    public GameObject label3pic;
    public GameObject label1name;
    public GameObject label2name;
    public GameObject label3name;
    public List<GameObject> combined1;


    // Use this for initialization
    void Start () {
        GameObject.Find("table").transform.position = new Vector3(Position.xtr + 0.05f, -3.748f, 9.83f);
        int k = Random.Range(0,3);

        if (k == 0)
        {
            label1name.transform.position = new Vector3(1.98f, -2.90f,10.6f);
            label1pic.transform.position = new Vector3(1.98f, -3.24f, 10.61f);
            //var combined1 = easyl1.Concat(wrongl1).ToList();
            combined1 = new List<GameObject>(easyl1);
            combined1.AddRange(wrongl1);

            for (float i = Position.xtl; i <= Position.xtr + 0.1f; i = i + ((Position.xtr - Position.xtl) / 6))
            {
                for (float j = 10.1f; j <= 10.6f; j = j + 0.2f)
                {
                    int randl = Random.Range(0, combined1.Count);
                    combined1[randl].transform.position = new Vector3(i, -3.737f, j);
                    combined1.RemoveAt(randl);
                }
            }
        }

        if (k == 1)
        {
            label2name.transform.position = new Vector3(1.98f, -2.90f, 10.6f);
            label2pic.transform.position = new Vector3(1.98f, -3.24f, 10.61f);
            var combined2 = easyl2.Concat(wrongl2).ToList();

            for (float i = Position.xtl; i <= Position.xtr + 0.1f; i = i + ((Position.xtr - Position.xtl) / 6))
            {
                for (float j = 10.1f; j < 10.6f; j = j + 0.2f)
                {
                int randl = Random.Range(0, combined2.Count);
                    combined2[randl].transform.position = new Vector3(i, -3.737f, j);
                    combined2.RemoveAt(randl);
                }
            }
        }

        if (k == 2)
        {
            label3name.transform.position = new Vector3(1.98f, -2.90f, 10.6f);
            label3pic.transform.position = new Vector3(1.98f, -3.24f, 10.61f);
            var combined3 = easyl3.Concat(wrongl3).ToList();

            for (float i = Position.xtl; i <= Position.xtr + 0.1f; i = i + ((Position.xtr - Position.xtl) / 5))
            {
                for (float j = 10.1f; j < 10.6f; j = j + 0.2f)
                {
                int randl = Random.Range(0, combined3.Count);
                    combined3[randl].transform.position = new Vector3(i, -3.737f, j);
                    combined3.RemoveAt(randl);
                }
            }
        }


    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
