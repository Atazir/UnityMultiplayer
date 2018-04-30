using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagController : MonoBehaviour {

    [SerializeField] GameObject myFire;

    public bool isGrabbed;

	// Use this for initialization
	void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update ()
    {

		if(isGrabbed)
        {
            myFire.SetActive(false);
        }
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            isGrabbed = true;
        }
    }
}
