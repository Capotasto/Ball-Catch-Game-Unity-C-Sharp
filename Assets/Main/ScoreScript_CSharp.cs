using UnityEngine;
using System.Collections;

public class ScoreScript_CSharp : MonoBehaviour {

	public static float mScore = 0.0f;
	public GUIStyle mScoreStyle;
	public GUIStyle mLifeStyle;
	private int mLife;

	// Use this for initialization
	void Start () {
		mScore = 0.0f;
		mLife = 3;
	}
	
	public void addScore(int point){
		mScore += point;
	}

	public float getScore(){
		return mScore;
	}

	public void subtractLife(int point){
		mLife -= point;
	}

	public int getLife(){
		return mLife;
	}

	void OnGUI(){
		GUI.Label(new Rect(10,60,100,100),"Score: " + mScore, mScoreStyle);
		GUI.Label(new Rect(10,110,100,100),"Life: " + mLife, mLifeStyle);
	}
}
