using UnityEngine;
using System.Collections;

public class Stage1Button : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void goToStage(){
		UnityEngine.SceneManagement.SceneManager.LoadScene ("Stage1");
	}
}
