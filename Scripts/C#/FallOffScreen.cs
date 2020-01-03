using UnityEngine;
using System.Collections;

public class FallOffScreen : MonoBehaviour {

	public GameObject gameObject;
	public int FallOffPoint;
	public float y;
	
	void Start () {
		//Nothing is Needed Here.
	}
	
	void Update () {
		FallOffPoint = -5;
		y = gameObject.transform.position.y;
		//Test for Height (in y Coord)
		if(y < FallOffPoint) {
			Destroy (gameObject);
		}
	}
}