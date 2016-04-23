using UnityEngine;
using System.Collections;

public class cam : MonoBehaviour {

	public float height;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.mousePosition.x <= 50) {
			transform.Translate(new Vector3(-1,0,0));
		} else if (Input.mousePosition.x >= Screen.width-50) {
			transform.Translate(new Vector3(1,0,0));
		} else if (Input.mousePosition.y <= 10) {
			transform.Translate(new Vector3(0,0,-1));
		} else if (Input.mousePosition.y >= Screen.height - 10) {
			transform.Translate(new Vector3(0,0,1));
		}
		
	}
}
