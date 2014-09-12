#pragma strict

function OnTriggerEnter2D (other : Collider2D) {
	//var cc:characterController = GameObject.Find("LAST CALL").GetComponent("characterController");
	Debug.Log("cc");
	//cc.
	if (other.gameObject.tag == "Player") {
		Debug.Log(other.gameObject);
		Application.LoadLevel("EndScene");
		// other.gameObject.SendMessage("DeathByTrigger");
	}
}