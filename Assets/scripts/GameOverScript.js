#pragma strict

var style : GUIStyle;

private var yourScore : float;  
//private var scoreObject : GameObject;

function Start(){
	var text : UnityEngine.UI.Text = GameObject.Find("YourScoreText").GetComponent("Text") as UnityEngine.UI.Text;
	yourScore = ScoreScript.score;

	if(yourScore != null){
		text.text = yourScore.ToString();
	}else{
		text.text = "Nothing";
	}


}

function DoRetry(){
	UnityEngine.SceneManagement.SceneManager.LoadScene("Main");
}