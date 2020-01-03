using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {

	public GUIText cointext;
	public int curCoins;
	public float coin_y;
	public float coin_x;

	void Update() {
			cointext.text = "" + curCoins;
		}
	

	void OnTriggerEnter(Collider col){
		if(col.gameObject.tag == "Coins"){
			coin_y = (col.gameObject).transform.position.y + 5;
			coin_x = (col.gameObject).transform.position.x;
			(col.gameObject).transform.position = new Vector2 (coin_x, coin_y);
			curCoins++;
					
		}
	}

}
	