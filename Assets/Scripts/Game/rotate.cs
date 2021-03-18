using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour {
    public float rotateSpeed;

	// Update is called once per frame
	void FixedUpdate () {
        transform.Rotate(Vector3.down * Time.deltaTime * rotateSpeed);
	}
}
