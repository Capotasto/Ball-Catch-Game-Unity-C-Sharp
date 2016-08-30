using UnityEngine;
using System.Collections;

public class StartGameScript_CSharp : MonoBehaviour {

	public void SceneLoad(){
		UnityEngine.SceneManagement.SceneManager.LoadScene("StageSelect");
	}
}
