using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

  public GameObject target;
  public Vector3 offset;
  public float speed = 5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
    Vector3 targetPosition = new Vector3 (
      target.transform.position.x + offset.x, 
      target.transform.position.y + offset.y, 
      transform.position.z);
    transform.position = Vector3.Lerp (transform.position, targetPosition, speed * Time.deltaTime);
	}
}
