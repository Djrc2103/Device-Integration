using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlaceObj : MonoBehaviour {

    public GameObject shelf;
    public GameObject divider;
    public GameObject fridge;
    public GameObject fridgelabel;
    public List<GameObject> labels;
    public List<GameObject> inputobjects;
    public List<GameObject> collideorder;
    public int c;
    public int columncounter;
    public int columnindex;


    void Start()
    {

        //----define objects----\\
        shelf = GameObject.Find("Shelf");
        divider = GameObject.Find("Divider");
        fridge = GameObject.Find("Fridge");
        fridgelabel = GameObject.Find("fridgelabel");

        //----shelf, divider, fridge, labels----\\
        shelf.transform.localScale += new Vector3(Position.xvr - Position.xvl, 0, 0);
        divider.transform.localScale += new Vector3 (Position.maxcoordy + 3.5f- (-3.5f - Position.maxcoordy) / 3, 0, 0);
        divider.transform.position = new Vector3 ((Position.xvl+Position.xvr)/2, (Position.maxcoordy - 3.5f) / 2, 10.5f);
        fridge.transform.position = new Vector3(Position.xtr + 0.4f, -4.56f, 9.38f);
        fridgelabel.transform.position = new Vector3(Position.xtr+0.2f, -3.4f, 9.6f);

        //---add shelves accordingly; I SHOULD LEAVE ENOUGH SPACE IN BETWEEN FOR BIGGEST OBJ??---\\
        for (float i = Position.maxcoordy; i >= -3.5f; i = i+(-3.5f-Position.maxcoordy)/3-0.05f)
        {
            Instantiate(shelf, new Vector3((Position.xvr + Position.xvl) / 2, i-0.05f, 10.5f), Quaternion.identity); 
        }

        //---------populate the table from xtl to xtr----------\\
        c = -1;
        for (float i = Position.xtl; i <= Position.xtr + 0.1f; i = i + ((Position.xtr - Position.xtl) / 5))
        {
            for (float j = 10.1f; j < 10.6f; j = j + 0.2f)
            {
                c++;
                int k = Random.Range(0, inputobjects.Count);
                float posy = inputobjects[k].transform.position.y;
                collideorder[c] = inputobjects[k];
                inputobjects[k].transform.position = new Vector3(i, posy, j);
                inputobjects.RemoveAt(k);
            }
        }

        //---initialize collider on first 3 objects---\\
        columnindex = -3;
        nextcolumn();

        //---label scaling---\\
        for (int i=0; i<=5; i++)
        {
            labels[i].transform.localScale += new Vector3(Position.xvr - (Position.xvl + Position.xvr) / 2+0.05f, (-3.5f - Position.maxcoordy) / 3-0.05f, 0);
        }

        //---labels positioning---\\

        for (float i = (Position.xvl+ (Position.xvl + Position.xvr) / 2)/2-0.025f; i<=Position.xvr; i = i + labels[0].gameObject.transform.localScale.x)
        {
            for (float j = Position.maxcoordy+0.05f; j>-3.5f; j = j+labels[0].gameObject.transform.localScale.y)
            {
                int k = Random.Range(0, labels.Count);
                labels[k].transform.position = new Vector3(i, j, 10.55f);
                labels.RemoveAt(k);

            }
        }

    }

    
    //---3by3, making colliders available---\\
   public void nextcolumn()
    {
        columncounter = 3;
        columnindex += 6;
        for (int i= columnindex-3; i<columnindex; i++)
        {
            collideorder[i].transform.GetComponent<Collider>().enabled = true;
        }
        columnindex -= 3;
    }

    



}
