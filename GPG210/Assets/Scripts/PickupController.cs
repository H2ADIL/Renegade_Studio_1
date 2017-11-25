using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupController : MonoBehaviour
{
    //Script attached to pickups
    //Telling player to add ammo

    public int AddAmmo = 2;
    Player _characterScript;


	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (other.gameObject.GetComponent<Player>() != null)
            {
                _characterScript = other.gameObject.GetComponent<Player>();
                _characterScript.AmmoPickup(AddAmmo);

            }
        }
    }
}
