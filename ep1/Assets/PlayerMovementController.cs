using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour {
    public float Speed;
    public float JumpSpeed;
    public KeyCode Down = KeyCode.S;
    public KeyCode Left = KeyCode.A;
    public KeyCode Right = KeyCode.D;
    public KeyCode Jump = KeyCode.Space;

    private Rigidbody2D body;

    // Use this for initialization
    void Start () {
        this.body = this.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        var moveDelta = new Vector3();
        
        if (Input.GetKey(Down))
        {
            moveDelta -= new Vector3(0,  this.Speed * Time.deltaTime, 0);
        }

        if (Input.GetKey(Left))
        {
            moveDelta -= new Vector3(this.Speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(Right))
        {
            moveDelta += new Vector3(this.Speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKeyUp(Jump))
        {
            this.body.AddForce(new Vector2(0, this.JumpSpeed));
        }

        if (moveDelta == Vector3.zero)
        {
            return;
        }

        this.body.velocity = new Vector2(moveDelta.x, moveDelta.y);
    }
}
