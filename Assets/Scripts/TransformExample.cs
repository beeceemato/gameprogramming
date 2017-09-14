using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformExample : MonoBehaviour {

    public GameObject sprite;
    public float Speed = 1;

		// Update is called once per frame
	void Update () {

        
        transform.Translate(Vector3.up * Time.deltaTime * Speed);
	}
}
