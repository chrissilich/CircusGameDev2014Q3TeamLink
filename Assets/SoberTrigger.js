#pragma strict

private var mBlur : MotionBlur;

function Start() {
	mBlur = GameObject.Find("Main Camera").GetComponent(MotionBlur);
}

function OnTriggerEnter2D(other : Collider2D) {
	if(other.gameObject.tag == "Player"){
		mBlur.enabled = false;
	}
}

function OnTriggerExit2D(other : Collider2D) {
	if(other.gameObject.tag == "Player"){
		mBlur.enabled = true;
	}
}