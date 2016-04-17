using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Position : MonoBehaviour
{
    public static float xvr;
    public static float xvl;
    public static float maxcoordy;
    public static float mincoordy;
    public static float xtl;
    public static float xtr;

    public GameObject cubel;
    public GameObject cuber;
    public GameObject cube1;
    public GameObject cube2;


    void Start()
    {
        //----set starting points of all coords needed----\\
        xvr = gameObject.transform.position.x;
        xvl = gameObject.transform.position.x;
        xtl = gameObject.transform.position.x;
        xtr = gameObject.transform.position.x;
        maxcoordy = gameObject.transform.position.y;
        mincoordy = gameObject.transform.position.y;

        //----find the cubes----\\
        cubel = GameObject.Find("CubeL");
        cuber = GameObject.Find("CubeR");
        cube1 = GameObject.Find("Cube1");
        cube2 = GameObject.Find("Cube2");
    }


    void Update()
    {

        //----define max y, max and min x on T pose----\\
        if (transform.position.y > maxcoordy)
        {
            maxcoordy = transform.position.y;
        }

        if (transform.position.x > xtr)
        {
            xtr = transform.position.x;
        }

        if (transform.position.x < xtl)
        {
            xtl = transform.position.x;
        }


        //----for max y, define max x and min x on the V pose, leaving y space for spreading----\\
        if (maxcoordy - transform.position.y <= 0.2F)
        {
            if (transform.position.x > xvr)
            {
                xvr = transform.position.x;
                cuber.transform.position = new Vector3(xvr, maxcoordy, 9.9F);
            }

            if (transform.position.x < xvl)
            {
                xvl = transform.position.x;
                cubel.transform.position = new Vector3(xvl, maxcoordy, 9.9F);
            }
        }


        //----unnecessary except for visualizing----\\
        if (transform.position.x == xtr)
        {
            mincoordy = transform.position.y;
            cube2.transform.position = new Vector3(xtr, -3.73f, 9.9F);
        }

        if (transform.position.x == xtl)
        {
            mincoordy = transform.position.y;
            cube1.transform.position = new Vector3(xtl, -3.73f, 9.9F);
        }



    }

}
