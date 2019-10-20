using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    
    public Rigidbody Rigi;

    [SerializeField] float MovementSpeed;
    float Horizontal;
    float Vertical;

    public bool Blacky = false;

    public float AnzeigeX;
    public float AnzeigeY;

	// Use this for initialization
	void Start ()
    {
        Rigi = gameObject.GetComponent<Rigidbody>();
	}	
	// Update is called once per frame
	void Update ()
    {
        Horizontal = Input.GetAxis("Horizontal");
        Vertical = Input.GetAxis("Vertical");

        AnzeigeX = Horizontal * MovementSpeed;
        AnzeigeY = Vertical * MovementSpeed;

        Rigi.AddForce(Horizontal * MovementSpeed, 0, Vertical * MovementSpeed);        
	}
}