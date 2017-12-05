using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_EMP : MonoBehaviour
{
    public float force;
    public GameObject EMPshot;
    //public Rigidbody emprb;
    //GameObject tempEMP;

	// Use this for initialization
	void Start ()
    {

	}
	
	// Update is called once per frame
	void Update ()
    {
        /*
        tempEMP = Instantiate(EMPshot, transform.position, transform.rotation);
        emprb = tempEMP.GetComponent<Rigidbody>();
        emprb.AddForce(transform.forward * force);
        Destroy(this, 1f);
        */
        transform.Translate(Vector3.forward * force * Time.deltaTime);
        Destroy(this.gameObject, 2f);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemies")
        {
          
        }
        
        if (other.gameObject.tag == "Walls")
        {
            Destroy(this.gameObject);
        }
    }
}
