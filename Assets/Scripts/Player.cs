using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

  public float acceleration = 2.5f;
  public float movementSpeed = 4f;
  public float jumpingSpeed = 6f;
  private float speed = 0f;

//  public float movementSpeed = 0.0001f;
//  private Color[] colors = { Color.black, Color.blue, Color.cyan, Color.gray, Color.green, Color.magenta, Color.red, Color.white, Color.yellow };

	// Use this for initialization
	void Start () {
  
  }
	
  float randomAngle() {
    return Random.Range (1, 3) * Random.Range (-1, 1);
  }

	// Update is called once per frame
	void Update () {
    // Accelerate the player.
    speed += acceleration * Time.deltaTime;
    if (speed > movementSpeed) {
      speed = movementSpeed;
    }
   
    // Move the player.
    GetComponent<Rigidbody> ().velocity = new Vector3 (
      speed, 
      GetComponent<Rigidbody>().velocity.y, 
      GetComponent<Rigidbody>().velocity.z
    );

    // Check for input
    if (Input.GetMouseButtonDown(0) || Input.GetKeyDown("space")) {
      GetComponent<Rigidbody> ().velocity = new Vector3 (
        GetComponent<Rigidbody>().velocity.x, 
        jumpingSpeed, 
        GetComponent<Rigidbody>().velocity.z
      );
    }


//    transform.position = new Vector3 (transform.position.x + movementSpeed * Time.deltaTime, 0, 0);
//    transform.RotateAround(transform.position, Vector3.up, 2);
//    transform.RotateAround(transform.position, Vector3.back, randomAngle());
//    transform.RotateAround(transform.position, Vector3.left, randomAngle());
//    Renderer rend = GetComponent<Renderer> ();
//    rend.material.SetColor ("_Color", colors [Random.Range (0, colors.Length)]);
  }
}
