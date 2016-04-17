using UnityEngine;
using System.Collections;

public class playtoastsound : MonoBehaviour {

    private AudioSource source;

    void Awake()
    {
        source = GetComponent<AudioSource>();
    }



    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (breadontoaster.burnt == true)
        {
            source.Play();
        }
    }
}
