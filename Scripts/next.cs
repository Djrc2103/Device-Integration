using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class next : MonoBehaviour {
    //Scene scene = SceneManager.GetActiveScene();
    // Use this for initialization
    public static int GlobalScore;
    public static int lvl1Score;
    public static int lvl2Score;
    public static int lvl3Score;
    public static int lvl4Score;
    public static int lvl5Score;
    public static int timerlevel;
    public float timeset = 0.0f;
    public float multiplier = 1.0f;
    public static int loc1Score;
    public static int loc2Score;
    public static int loc3Score;
    public static int loc4Score;
    public static int loc5Score;


    void Start() {

    }

    // Update is called once per frame
    void Update() {

        timeset += multiplier * Time.deltaTime;
        GlobalScore = lvl1Score + lvl2Score + lvl3Score + lvl4Score + lvl5Score + loc1Score + loc2Score + loc3Score + loc4Score + loc5Score;

        if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            print("scene 2");
            if (timeset > 0 && timeset <= 180)
            {
                if (lvl1Score == 40)
                {
                    loc1Score = 30;
                }
            }
            if (timeset > 180 && timeset <= 240)
            {
                if (lvl1Score == 40)
                {
                    loc1Score = 20;
                }
            }
            if (timeset > 240 && timeset <= 300)
            {
                if (lvl1Score == 40)
                {
                    loc1Score = 10;
                }
            }
        }

        if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            if (timeset > 0 && timeset <= 180)
            {
                if (lvl2Score == 210)
                {
                    loc2Score = 30;
                }
            }
            if (timeset > 180 && timeset <= 240)
            {
                if (lvl2Score == 210)
                {
                    loc2Score = 20;
                }
            }
            if (timeset > 240 && timeset <= 300)
            {
                if (lvl2Score == 210)
                {
                    loc2Score = 10;
                }
            }
        }
        if (SceneManager.GetActiveScene().buildIndex == 4)
        {
            if (timeset > 0 && timeset <= 180)
            {
                if (lvl3Score == 120)
                {
                    loc3Score = 30;
                }
            }
            if (timeset > 180 && timeset <= 240)
            {
                if (lvl3Score == 120)
                {
                    loc3Score = 20;
                }
            }
            if (timeset > 240 && timeset <= 300)
            {
                if (lvl3Score == 120)
                {
                    loc3Score = 10;
                }
            }
        }

        if (SceneManager.GetActiveScene().buildIndex == 5)
        {
            if (timeset > 0 && timeset <= 180)
            {
                if (GameObject.FindWithTag("Dust(Clone)") == null && GameObject.FindWithTag("Dust2(Clone)") == null && GameObject.FindWithTag("Dust3(Clone)") == null)
                {
                    loc4Score = 30;
                }
            }
            if (timeset > 180 && timeset <= 240)
            {
                if (GameObject.FindWithTag("Dust(Clone)") == null && GameObject.FindWithTag("Dust2(Clone)") == null && GameObject.FindWithTag("Dust3(Clone)") == null)
                {
                    loc4Score = 20;
                }
            }
            if (timeset > 240 && timeset <= 300)
            {
                if (GameObject.FindWithTag("Dust(Clone)") == null && GameObject.FindWithTag("Dust2(Clone)") == null && GameObject.FindWithTag("Dust3(Clone)") == null)
                {
                    loc4Score = 10;
                }
            }
        }


        if (SceneManager.GetActiveScene().buildIndex == 8)
        {
            if (timeset > 0 && timeset <= 180)
            {
                if (lvl5Score == 550)
                {
                    loc5Score = 30;
                }
            }
            if (timeset > 180 && timeset <= 240)
            {
                if (lvl5Score == 550)
                {
                    loc5Score = 20;
                }
            }
            if (timeset > 240 && timeset <= 300)
            {
                if (lvl5Score == 550)
                {
                    loc5Score = 10;
                }
            }
        }




        if (Input.GetKeyDown("n"))
        {

            //print(GlobalScore);
            print(timeset);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            timeset = 0;
        }

        if (Input.GetKeyDown("escape"))
        {

            Application.Quit();
        }

        if (Input.GetKeyDown("r"))
        {
            if (SceneManager.GetActiveScene().buildIndex == 2)
            {
                lvl1Score = 0;
                loc1Score = 0;
                Coffeemaker.wateron = false;
                closelid.closedlid = false;
                presscofbutton.fillwithcoffee = false;
                presscofbutton.coffeerecfilled = false;
                coffeepouring.cupisfull = false;
                fillglass.glassisfull = false;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                GameObject.Find("LMHeadMountedRig").transform.position = new Vector3(2.181f, -3.312f, 9.688f);

            }

            if (SceneManager.GetActiveScene().buildIndex == 3)
            {
                lvl2Score = 0;
                loc2Score = 0;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                GameObject.Find("LMHeadMountedRig").transform.position = new Vector3(2.181f, -3.312f, 9.688f);
            }

            if (SceneManager.GetActiveScene().buildIndex == 4)
            {
                lvl3Score = 0;
                loc3Score = 0;
                breadontoaster.burnt = false;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                GameObject.Find("LMHeadMountedRig").transform.position = new Vector3(2.181f, -3.312f, 9.688f);
            }

            if (SceneManager.GetActiveScene().buildIndex == 5)
            {
                lvl4Score = 0;
                loc4Score = 0;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                GameObject.Find("LMHeadMountedRig").transform.position = new Vector3(2.181f, -3.312f, 9.688f);
            }

            if (SceneManager.GetActiveScene().buildIndex == 6 || SceneManager.GetActiveScene().buildIndex == 7 || SceneManager.GetActiveScene().buildIndex == 8)
            {
                lvl5Score = 0;
                loc5Score = 0;
                SceneManager.LoadScene(5);
                GameObject.Find("LMHeadMountedRig").transform.position = new Vector3(2.181f, -3.312f, 9.688f);
            }

        }

        }
}
