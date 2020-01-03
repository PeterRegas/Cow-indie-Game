#pragma strict

function Start() {
	
}

function Update(){
 
if (Input.GetKeyDown("space")){
 	if(!audio.isPlaying){
 		//audio.clip = jump;
 		audio.Play();
 		}
 	}
 }