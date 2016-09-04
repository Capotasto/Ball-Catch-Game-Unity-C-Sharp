using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResultScript : MonoBehaviour {

	private float mYourScore;
	private float mHighScore;

	private int finishedStageNumber;

	// Use this for initialization
	void Start () {
		Text yourText = GameObject.Find("YourScoreText").GetComponent("Text") as Text;
		Text highText = GameObject.Find("HighScoreText").GetComponent("Text") as Text;
		Text resultText =  GameObject.Find("resultLabel").GetComponent("Text") as Text;
		Text RetryText =  GameObject.Find("RetryText").GetComponent("Text") as Text;

		finishedStageNumber = GlobalObject.PlayingStageNumber;
		switch(finishedStageNumber){
		case 0:
			resultText.text = "Something Wrong";
			break;
		case 1:
			mYourScore = ScoreScript_CSharp.mScoreStage1;
			mHighScore = PlayerPrefs.GetInt (GlobalObject.HIGH_SCORE_STAGE1, 0);
			if (GlobalObject.isCreardStage1) {
				resultText.text = "Stage 1 is cleared!!";
				RetryText.text = "Next Satage";
			} else {
				resultText.text = "Game Over";		
				RetryText.text = "Retry";
			}	
			break;
		case 2:
			mYourScore = ScoreScript_CSharp.mScoreStage2;
			mHighScore = PlayerPrefs.GetInt (GlobalObject.HIGH_SCORE_STAGE2, 0);
			if (GlobalObject.isCreardStage2) {
				resultText.text = "Stage 2 is cleared!!";
				RetryText.text = "Next Satage";
			} else {
				resultText.text = "Game Over";		
				RetryText.text = "Retry";
			}
			break;
		case 3:
			mYourScore = ScoreScript_CSharp.mScoreStage3;
			mHighScore = PlayerPrefs.GetInt (GlobalObject.HIGH_SCORE_STAGE3, 0);
			if (GlobalObject.isCreardStage3) {
				resultText.text = "Stage 3 is cleared!!";
				RetryText.text = "Next Satage";
			} else {
				resultText.text = "Game Over";		
				RetryText.text = "Retry";
			}
			break;
		case 4:
			mYourScore = ScoreScript_CSharp.mScoreStage4;
			mHighScore = PlayerPrefs.GetInt (GlobalObject.HIGH_SCORE_STAGE4, 0);
			if (GlobalObject.isCreardStage4) {
				resultText.text = "Stage 4 is cleared!!";
				RetryText.text = "Title Page";
			} else {
				resultText.text = "Game Over";		
				RetryText.text = "Retry";
			}
			break;
		}

		yourText.text = mYourScore.ToString();
		highText.text = mHighScore.ToString();
		Debug.Log ("mHighScore.ToString() :" + mHighScore.ToString());
	}

	public void OnRetryButtonClick(){
		switch(finishedStageNumber){
		case 0:
			break;
		case 1:
			if (GlobalObject.isCreardStage1) {
				UnityEngine.SceneManagement.SceneManager.LoadScene("Stage2");
			} else {
				UnityEngine.SceneManagement.SceneManager.LoadScene("Stage1");
			}
			break;

		case 2:
			if (GlobalObject.isCreardStage2) {
				UnityEngine.SceneManagement.SceneManager.LoadScene("Stage3");
			} else {
				UnityEngine.SceneManagement.SceneManager.LoadScene("Stage2");
			}

			break;

		case 3:
			if (GlobalObject.isCreardStage3) {
				UnityEngine.SceneManagement.SceneManager.LoadScene("Stage4");
			} else {
				UnityEngine.SceneManagement.SceneManager.LoadScene("Stage3");
			}

			break;

		case 4:
			if (GlobalObject.isCreardStage4) {
				UnityEngine.SceneManagement.SceneManager.LoadScene("Title");
			} else {
				UnityEngine.SceneManagement.SceneManager.LoadScene("Stage4");
			}

			break;

		}
	}

	public void OnStageSelectButtonClick(){
		UnityEngine.SceneManagement.SceneManager.LoadScene("StageSelect");
	}

	public void OnTitleClick(){
		UnityEngine.SceneManagement.SceneManager.LoadScene("Title");
	}
}
