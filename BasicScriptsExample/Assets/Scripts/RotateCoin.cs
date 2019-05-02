using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCoin : MonoBehaviour {

	// Use this for initialization

	
	// Update is called once per frame
	void Update () {
        transform.Rotate(100 * Vector3.right * Time.deltaTime);

    }
}
