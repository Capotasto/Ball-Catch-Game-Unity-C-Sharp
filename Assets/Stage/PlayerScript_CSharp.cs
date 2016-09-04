using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerScript_CSharp : MonoBehaviour {

	public ScoreScript_CSharp mScoreScript ;
	private Text mLevelText;
	private Text mScoreText;
	private Text mLifeText;

	//QuotaScore
//	public int QuotaScoreForStage1;
//	public int QuotaScoreForStage2;
//	public int QuotaScoreForStage3;
//	public int QuotaScoreForStage4;

	float mSubScaleFrom = 0.0f;
	float mSubScaleTo = 0.0f;
	float mMinScale = 0.0f;
	int mGetPoint = 0;
	int mStageNum = 0;

	void Start(){
		mScoreScript = GameObject.Find("ScoreSystem").GetComponent("ScoreScript_CSharp") as ScoreScript_CSharp;
		mLevelText = GameObject.Find("LevelText").GetComponent("Text") as Text;
		mScoreText = GameObject.Find("ScoreText").GetComponent("Text") as Text;
		mLifeText = GameObject.Find("LifeText").GetComponent("Text") as Text;
		if (SceneManager.GetActiveScene ().name == "Stage1") {
			mLevelText.text = "Level: " + 1;
			mScoreText.text = "Score: 0 / " + ScoreScript_CSharp.QuotaScoreForStage1;
		} else if (SceneManager.GetActiveScene ().name == "Stage2") {
			mLevelText.text = "Level: " + 2;
			mScoreText.text = "Score: 0 / " + ScoreScript_CSharp.QuotaScoreForStage2; 
		} else if (SceneManager.GetActiveScene ().name == "Stage3") {
			mLevelText.text = "Level: " + 3;
			mScoreText.text = "Score: 0 / " + ScoreScript_CSharp.QuotaScoreForStage3; 
		} else if (SceneManager.GetActiveScene ().name == "Stage4") {
			mLevelText.text = "Level: " + 4;
			mScoreText.text = "Score: 0 / " + ScoreScript_CSharp.QuotaScoreForStage4; 
		}
		mLifeText.text = "Life: 3";
	}

	// Update is called once per frame
	void Update () {
		if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved){
			transform.Translate(Input.GetTouch(0).deltaPosition.x/90,0,0);
		}

//		float x = Input.GetAxis("Horizontal");
//		transform.Translate (x * 0.3f, 0, 0);


		if (SceneManager.GetActiveScene ().name == "Stage1") {
			mScoreText.text = "Score: " + mScoreScript.getScore (1) + " / " + ScoreScript_CSharp.QuotaScoreForStage1;
		} else if (SceneManager.GetActiveScene ().name == "Stage2") {
			mScoreText.text = "Score: " + mScoreScript.getScore (2) + " / " + ScoreScript_CSharp.QuotaScoreForStage2;
		} else if (SceneManager.GetActiveScene ().name == "Stage3") {
			mScoreText.text = "Score: " + mScoreScript.getScore (3) + " / " + ScoreScript_CSharp.QuotaScoreForStage3;
		} else if (SceneManager.GetActiveScene ().name == "Stage4") {
			mScoreText.text = "Score: " + mScoreScript.getScore (4) + " / " + ScoreScript_CSharp.QuotaScoreForStage4;
		}

		mLifeText.text = "Life: " + mScoreScript.getLife ();
	}

	void OnCollisionEnter(Collision obj){
		if (SceneManager.GetActiveScene().name == "Stage1") {
			mSubScaleFrom = 0.1f;
			mSubScaleTo = 0.5f;
			mMinScale = 1.0f;
			mGetPoint = 10;
			mStageNum = 1;
		} else if (SceneManager.GetActiveScene().name == "Stage2") {
			mSubScaleFrom = 0.2f;
			mSubScaleTo = 0.6f;
			mMinScale = 0.8f;
			mGetPoint = 15;
			mStageNum = 2;
		} else if (SceneManager.GetActiveScene().name == "Stage3") {
			mSubScaleFrom = 0.3f;
			mSubScaleTo = 0.7f;
			mMinScale = 0.6f;
			mGetPoint = 30;
			mStageNum = 3;
		} else if (SceneManager.GetActiveScene().name == "Stage4") {
			mSubScaleFrom = 0.5f;
			mSubScaleTo = 1.0f;
			mMinScale = 0.3f;
			mGetPoint = 40;
			mStageNum = 4;
		} 
		if(obj.gameObject.name.Equals("Enemy(Clone)")){
			Vector3 scale = transform.localScale;
			scale.x -= Random.Range(mSubScaleFrom, mSubScaleTo);
			transform.localScale = scale;
			if(transform.localScale.x < mMinScale){
				scale.x = mMinScale;
				transform.localScale = scale;
			}
			mScoreScript.addScore (mStageNum, mGetPoint);
		}
	}
}
