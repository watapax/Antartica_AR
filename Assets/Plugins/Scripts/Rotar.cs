using UnityEngine;
using System.Collections;

public class Rotar : MonoBehaviour {

 
	public float velocidad;

	void FixedUpdate(){
		transform.Rotate(Vector3.up * velocidad * Time.deltaTime , Space.Self);
	}
}
