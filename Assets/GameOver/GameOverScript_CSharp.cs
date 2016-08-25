using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOverScript_CSharp : MonoBehaviour {

	private float mYourScore;
	private float mHighScore;

	// Use this for initialization
	void Start () {
		Text yourText = GameObject.Find("YourScoreText").GetComponent("Text") as Text;
		Text highText = GameObject.Find("HighScoreText").GetComponent("Text") as Text;
		mYourScore = ScoreScript_CSharp.mScore;
		mHighScore = PlayerPrefs.GetFloat("HIGH_SCORE",0);

		yourText.text = mYourScore.ToString();
		highText.text = mHighScore.ToString();
//		if(mYourScore != null){
//			yourText.text = mYourScore.ToString();
//		}
//		else{
//			yourText.text = "Nothing";
//		}

//		if(mHighScore != null){
//			highText.text = mHighScore.ToString();
//		}
//		else{
//			highText.text = "Nothing";
//		}
	}
	
	public void OnClick(){
		UnityEngine.SceneManagement.SceneManager.LoadScene("Main");
	}
}
