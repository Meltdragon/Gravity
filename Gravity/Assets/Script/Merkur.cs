using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Merkur : MonoBehaviour {

    public Rigidbody Rigi;

    public float mass;

	// Use this for initialization
	void Start ()
    {
        Rigi = gameObject.GetComponent<Rigidbody>();
        mass = 3.13282f * Mathf.Pow(10, 17);
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       Rigi.AddForce(Vector3.right * 4787, ForceMode.Impulse);
    }
}
