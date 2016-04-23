using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour {

	public GameObject researchUIPanel;
	bool isOpen = false;

	public Text daysElapsed;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.R)) {
			OpenResearch ();
		}
	}

	void FixedUpdate() {
		daysElapsed.text = System.DateTime.Now.AddDays(Mathf.FloorToInt (Time.timeSinceLevelLoad)).Date.ToString();

	}

	void OpenResearch() {
		isOpen = !isOpen;
		Time.timeScale = isOpen ? 0.0f : 1.0f;
		researchUIPanel.SetActive (isOpen);
	}
}
