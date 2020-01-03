using UnityEngine;
using System.Collections;
[
 RequireComponent(typeof(PlayerPhysics))]

public class Runner : MonoBehaviour {

	private bool touchingPlatform;

	private PlayerPhysics playerPhysics;

	public static float distanceTraveled;

	public Vector3 jumpVelocity;
	void Start () {
		playerPhysics = GetComponent<PlayerPhysics>();
	}

	void Update () {
				
		distanceTraveled = transform.localPosition.x;

		//Auto Move Right
				float translation = 7f * Time.deltaTime;
				transform.Translate (translation, 0f, 0f);
	
				if(touchingPlatform && Input.GetButtonDown ("Jump")) {
						rigidbody.AddForce (jumpVelocity, ForceMode.VelocityChange);
						touchingPlatform = false;
				}

	
		}
	
	
		void OnCollisionEnter () {
			touchingPlatform = true;
		}
		
		
		
		void OnCollisionExit () {
			touchingPlatform = false;
		}

	
	
	
	
	
	
	
	
	
	
	
	}



