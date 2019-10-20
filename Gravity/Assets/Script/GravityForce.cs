using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityForce : MonoBehaviour {

    static Rigidbody Sun;

    [SerializeField] float Mass;

    [SerializeField] Merkur Merkur;
    [SerializeField] Venus Venus;
    [SerializeField] Earth Earth;


    static Vector3 Direction;

	// Use this for initialization
	void Start ()
    {
        Sun = gameObject.GetComponent<Rigidbody>();
        Mass = 1.89678f * Mathf.Pow(10, 24);
        Merkur = GameObject.FindWithTag("Merkur").GetComponent<Merkur>();
    }	

	// Update is called once per frame
	void Update ()
    {
        merkur();
        //venus();
        //earth();
    }
    public void merkur()
    {
       // Debug.Log("Merkur");
        float Gravity;
        float Distance;

        Distance = Vector3.Distance(this.gameObject.transform.position, Merkur.transform.position);
        Gravity = /*(6.3649f * Mathf.Pow(10, -17)) */ ((Mass * Merkur.Rigi.mass) / Distance);
        Direction = this.transform.position - Merkur.transform.position;
        Merkur.Rigi.AddForce(Direction.normalized * Gravity);
        Debug.Log("Gravity: " + Gravity);
        Debug.Log("Direction: " + Direction);
        Debug.Log("Force: " + Direction.normalized * Gravity);
    }
    public void venus()
    {

    }
    public void earth()
    {

    }
}