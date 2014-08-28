using UnityEngine;
using System.Collections;

public class PlayerAnimation : MonoBehaviour {

	public Animator anim;

	void Start () {
		anim = GetComponent<Animator> ();
	}
	

	void Update () {


		//idle animation
		if(Input.GetKey(KeyCode.W)){
			anim.SetBool("up",true);
			anim.SetBool("down",false);
			anim.SetBool("left",false);
			anim.SetBool("right",false);
		}
		if(Input.GetKey(KeyCode.S)) {
			anim.SetBool("down",true);
			anim.SetBool("up",false);
			anim.SetBool("left",false);
			anim.SetBool("right",false);
		}
		if(Input.GetKey(KeyCode.A)) {
			anim.SetBool("left",true);
			anim.SetBool("up",false);
			anim.SetBool("down",false);
			anim.SetBool("right",false);
		}
		if(Input.GetKey(KeyCode.D)) {
			anim.SetBool("right",true);
			anim.SetBool("up",false);
			anim.SetBool("down",false);
			anim.SetBool("left",false);
		}

		//walk animation

		if (Input.GetKey (KeyCode.W)) {
			anim.SetBool ("walkUp", true);
			} 
		else {
			anim.SetBool ("walkUp", false);
			}

		if (Input.GetKey (KeyCode.S)) {
			anim.SetBool ("walkDown", true);
		} 
		else {
			anim.SetBool ("walkDown", false);
		}

		if (Input.GetKey (KeyCode.A)) {
			anim.SetBool ("walkLeft", true);
		} 
		else {
			anim.SetBool ("walkLeft", false);
		}

		if (Input.GetKey (KeyCode.D)) {
			anim.SetBool ("walkRight", true);
		} 
		else {
			anim.SetBool ("walkRight", false);
		}
	}
}