using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class KeyDetection : MonoBehaviour {

	//Labeling Keys
	public string letter_a = "a";
	public string letter_b = "b";
	public string letter_c = "c";
	public string letter_d = "d";
	public string letter_e = "e";
	public string letter_f = "f";
	public string letter_g = "g";
	public string letter_h = "h";
	public string letter_i = "i";
	public string letter_j = "j";
	public string letter_k = "k";
	public string letter_l = "l";
	public string letter_m = "m";
	public string letter_n = "n";
	public string letter_o = "o";
	public string letter_p = "p";
	public string letter_q = "q";
	public string letter_r = "r";
	public string letter_s = "s";
	public string letter_t = "t";
	public string letter_u = "u";
	public string letter_v = "v";
	public string letter_w = "w";
	public string letter_y = "y";
	public string letter_x = "x";
	public string letter_z = "z";
	//Text Testing
	public GUIText cointext;
	// Use this for initialization
	void Start () {
		List<string> letters_col = new List<string> ();
		letters_col.Add (letter_a);
		cointext.text = "" + (letters_col [0]);
	}

	// Update is called once per frame
	void Update () {

	}
}
