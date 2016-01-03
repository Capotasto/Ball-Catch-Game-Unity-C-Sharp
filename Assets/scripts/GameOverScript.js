#pragma strict

var style : GUIStyle;

private var yourScore : float; 
private var highScore : float;

function Start(){
	var yourText : UnityEngine.UI.Text = GameObject.Find("YourScoreText").GetComponent("Text") as UnityEngine.UI.Text;
	var highText : UnityEngine.UI.Text = GameObject.Find("HighScoreText").GetComponent("Text") as UnityEngine.UI.Text;
	yourScore = ScoreScript.score;
	highScore = PlayerPrefs.GetFloat("HIGH_SCORE",0);

	if(yourScore != null){
		yourText.text = yourScore.ToString();
	}else{
		yourText.text = "Nothing";
	}

	if(highText != null){
		highText.text = highScore.ToString();
	}else{
		highText.text = "Nothing";
	}


}

function DoRetry(){
	UnityEngine.SceneManagement.SceneManager.LoadScene("Main");
}