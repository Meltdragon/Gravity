using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour {

    [SerializeField] float Mass;

    [SerializeField] Rigidbody player;
    // Use this for initialization
    void Start ()
    {

    }

    // Update is called once per frame
    void FixedUpdate ()
    {
        Merkur();
    }
    public void Merkur()
    {
        Vector3 difference;
        float Gravity;
        float Distance;
        Vector3 Direction;

        difference = this.transform.position - player.transform.position;
        Distance = difference.magnitude;
        Direction = difference.normalized;



        Gravity = (6.3649f) * ((Mass * player.mass) / Mathf.Pow(Distance,2));

        player.AddForce(Direction * Gravity);

        //merkur.transform.position = Direction * Gravity;

       // merkur.Rigi.AddForce(Direction * Gravity,ForceMode.Force);

        Debug.Log(Gravity);
    }
}
