using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	public Texture backgroundTexture;

	public GUIStyle PlayButton;
	public GUIStyle StoryButton;

	public float guiPlacementY1;
	public float guiPlacementY2;

	public float guiPlacementX1;
	public float guiPlacementX2;




	void OnGUI() {

//Displays Background Texture
		GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), backgroundTexture);

//Displays Buttons without Outline
		if (GUI.Button (new Rect(Screen.width * guiPlacementX1, Screen.height * guiPlacementY1, Screen.width * .4f, Screen.height * .4f), "", PlayButton)) {
			print("Clicked Play Game");
			Application.LoadLevel("FinalBuild");
		}

		if (GUI.Button (new Rect(Screen.width * guiPlacementX2, Screen.height * guiPlacementY2, Screen.width * .3f, Screen.height * .3f), "", StoryButton)) {
			Application.LoadLevel("StoryScene");
		}

	}

}
