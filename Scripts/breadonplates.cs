using UnityEngine;
using System.Collections;

public class breadonplates : MonoBehaviour
{
    public Material donecolor;
    public Colliding takeslices;


    void OnCollisionEnter(Collision col)
    {
        if (gameObject.transform.childCount == 0 && (col.gameObject == breadontoaster.slicenumber) && breadontoaster.burnt == false)
        {
                col.gameObject.transform.parent = null;
                col.gameObject.transform.parent = gameObject.transform;
                col.gameObject.transform.localPosition = new Vector3(0, 0.01f, 0);
                col.gameObject.transform.eulerAngles = new Vector3(0, 0, 90);
                Colliding.coltimer = 100;
                col.gameObject.GetComponent<Collider>().enabled = false;
            next.lvl3Score += 10;

        }



    }
}
