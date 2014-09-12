#pragma strict

var movTexture : MovieTexture;

function Start () {

	movTexture = renderer.material.mainTexture;
	movTexture.Play();

}
