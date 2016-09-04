using UnityEngine;
using System.Collections;

public class ScoreScript_CSharp : MonoBehaviour {

	public static int mScoreStage1;
	public static int mScoreStage2;
	public static int mScoreStage3;
	public static int mScoreStage4;
	public static int QuotaScoreForStage1;
	public static int QuotaScoreForStage2;
	public static int QuotaScoreForStage3;
	public static int QuotaScoreForStage4;
	private int mLife;

	// Use this for initialization
	void Start () {
		mScoreStage1 = 0;
		mScoreStage2 = 0;
		mScoreStage3 = 0;
		mScoreStage4 = 0;
		QuotaScoreForStage1 = 300;
		QuotaScoreForStage2 = 500;
		QuotaScoreForStage3 = 700;
		QuotaScoreForStage4 = 1000;

		mLife = 3;
	}
	
	public int getScore(int stageNum){
		int score;
		switch (stageNum) {
		case 1:
			score = mScoreStage1;
			break;
		case 2:
			score = mScoreStage2;
			break;
		case 3:
			score = mScoreStage3;
			break;
		case 4:
			score = mScoreStage4;
			break;
		default:
			score = 0;
			break;
		}
		return score;	
	}

	public void addScore(int stageNum, int point){
		switch (stageNum) {
		case 1:
			mScoreStage1 += point;
			break;
		case 2:
			mScoreStage2 += point;
			break;
		case 3:
			mScoreStage3 += point;
			break;
		case 4:
			mScoreStage4 += point;
			break;
		default:
			break;
		}
	}

	public void subtractLife(int point){
		mLife -= point;
	}

	public int getLife(){
		return mLife;
	}
}
