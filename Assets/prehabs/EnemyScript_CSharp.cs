using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EnemyScript_CSharp : MonoBehaviour {

	public ScoreScript_CSharp mScoreScript;
	//BuletScale
	public float BuletScaleForStage1;
	public float BuletScaleForStage2;
	public float BuletScaleForStage3;
	public float BuletScaleForStage4;
	//BuletSpeed
	public float BuletSpeedForStage1;
	public float BuletSpeedForStage2;
	public float BuletSpeedForStage3;
	public float BuletSpeedForStage4;
	//BuletRotate
	public float BuletRotateForStage1;
	public float BuletRotateForStage2;
	public float BuletRotateForStage3;
	public float BuletRotateForStage4;

	private float mHightScore;
	private int mQuotaScore;
	private float mBulteScale;
	private float mBuletSpeed;
	private float mBuletRotate;
	private string mStageIDString;
	private int mStageNumber;


	// Use this for initialization
	void Start () {
		mScoreScript = GameObject.Find("ScoreSystem").GetComponent("ScoreScript_CSharp") as ScoreScript_CSharp;
		if (SceneManager.GetActiveScene().name == "Stage1") {	
			mQuotaScore = ScoreScript_CSharp.QuotaScoreForStage1;
			mBulteScale = BuletScaleForStage1;
			mBuletSpeed = BuletSpeedForStage1;
			mBuletRotate = BuletRotateForStage1;
			mStageIDString = GlobalObject.HIGH_SCORE_STAGE1;
			mStageNumber = 1;
		} else if (SceneManager.GetActiveScene().name == "Stage2") {
			mQuotaScore = ScoreScript_CSharp.QuotaScoreForStage2;
			mBulteScale = BuletScaleForStage2;
			mBuletSpeed = BuletSpeedForStage2;
			mBuletRotate = BuletRotateForStage2;
			mStageIDString = GlobalObject.HIGH_SCORE_STAGE2;
			mStageNumber = 2;
		} else if (SceneManager.GetActiveScene().name == "Stage3") {
			mQuotaScore = ScoreScript_CSharp.QuotaScoreForStage3;
			mBulteScale = BuletScaleForStage3;
			mBuletSpeed = BuletSpeedForStage3;
			mBuletRotate = BuletRotateForStage3;
			mStageIDString = GlobalObject.HIGH_SCORE_STAGE3;
			mStageNumber = 3;
		} else if (SceneManager.GetActiveScene().name == "Stage4") {
			mQuotaScore = ScoreScript_CSharp.QuotaScoreForStage4;
			mBulteScale = BuletScaleForStage4;
			mBuletSpeed = BuletSpeedForStage4;
			mBuletRotate = BuletRotateForStage4;
			mStageIDString = GlobalObject.HIGH_SCORE_STAGE4;
			mStageNumber = 4;
		}
		//set stagenumber
		GlobalObject.PlayingStageNumber = mStageNumber;
		//Change Bulet Size
		changeBuletScale();
		//get hightsocre
		mHightScore = PlayerPrefs.GetInt(mStageIDString, 0);
	}
	
	// Update is called once per frame
	void Update () {
		//Change Bulet Speed
		changeBuletSpeed();
		//Change Bulet Rotatition
		changeBuletRotation();

		//check quota score
		if(mScoreScript.getScore(mStageNumber) >= mQuotaScore){
			if(mScoreScript.getLife() > 0){
				//change clread flg
				switch(mStageNumber){
				case 1:
					GlobalObject.isCreardStage1 = true;
					break;
				case 2:
					GlobalObject.isCreardStage2 = true;
					break;
				case 3:
					GlobalObject.isCreardStage3 = true;
					break;
				case 4:
					GlobalObject.isCreardStage4 = true;
					break;
				}

				//Save Hight Score
				Debug.Log ("mScoreScript.getScore(mStageNumber) :" + mScoreScript.getScore(mStageNumber));
				Debug.Log ("mHightScore :" + mHightScore);
				Debug.Log ("mStageIDString :" + mStageIDString);
				if(mHightScore < mScoreScript.getScore(mStageNumber)){
					PlayerPrefs.SetInt(mStageIDString, mScoreScript.getScore(mStageNumber));
				}
				//Application.LoadLevel("GameOver");
				UnityEngine.SceneManagement.SceneManager.LoadScene("Result");
			}
		}
			
		//Subtract life
		if(transform.position.z < -12.0) {
			Destroy(gameObject);
			mScoreScript.subtractLife (1);
			if(mScoreScript.getLife() <= 0){
				//Save Hight Score
				if(mHightScore < mScoreScript.getScore(mStageNumber)){
					PlayerPrefs.SetInt(mStageIDString, mScoreScript.getScore(mStageNumber));
				}
				//Application.LoadLevel("GameOver");
				UnityEngine.SceneManagement.SceneManager.LoadScene("Result");
			}

		}
	}

	void OnCollisionEnter(Collision colli){
		Destroy (gameObject);
	}

	private void changeBuletScale(){
		Vector3 scale = transform.localScale;
		scale.x = mBulteScale;
		scale.y = mBulteScale;
		scale.z = mBulteScale;
		transform.localScale = scale;
	}

	private void changeBuletSpeed(){
		Vector3 pos = transform.position;
		pos.z -= mBuletSpeed;
		transform.position = pos;
	}

	private void changeBuletRotation(){
		transform.Rotate(mBuletRotate, mBuletRotate, mBuletRotate);
	}
}
