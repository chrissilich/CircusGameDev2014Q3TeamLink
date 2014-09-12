using UnityEngine;
using System.Collections;

public class EndScene : MonoBehaviour {

	public Texture backgroundTexture;

	public GUIStyle PlayButton;

	public float guiPlacementY;

	public float guiPlacementX;


	void OnGUI() {

//Displays Background Texture
		GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), backgroundTexture);

//Displays Buttons without Outline
		if (GUI.Button (new Rect(Screen.width * guiPlacementX, Screen.height * guiPlacementY, Screen.width * .2f, Screen.height * .2f), "", PlayButton)) {
			print("Clicked Play Game");
			Application.LoadLevel("FinalBuild");
		}

	}

}
