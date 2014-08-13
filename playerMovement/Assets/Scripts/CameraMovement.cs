using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

	public class CameraMove : MonoBehaviour {
		
		Transform target;
		void Start () {
			target = GameObject.Find ("player").transform;
		}
		
		
		void Update () {
			transform.position = target.position + new Vector3 (0, 0, -10);
		}
	}
}
