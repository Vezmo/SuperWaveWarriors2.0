using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatetest : MonoBehaviour {

  public float Speed;
  RectTransform transform;

	// Use this for initialization
	void Start ()
  {
    transform = GetComponent<RectTransform>();
	}
	
	// Update is called once per frame
	void Update ()
  {
    transform.Rotate(new Vector3(0, 0, -Speed * Time.deltaTime));


  }
}
