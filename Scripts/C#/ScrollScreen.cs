using UnityEngine;
using System.Collections;

public class ScrollScreen : MonoBehaviour {
	public float scrollSpeed = 0.3F;
	void Update() {
		float offset = Time.time * scrollSpeed;
		renderer.material.mainTextureOffset = new Vector2(offset, 0);
	}
}
