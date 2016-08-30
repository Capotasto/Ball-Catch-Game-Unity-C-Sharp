using UnityEngine;
using System.Collections;

public class LevelScript_CSharp : MonoBehaviour {

	public GUIStyle mLevelStyle;
	private int mLevel = 1;

	// Use this for initialization
	void Start () {
		mLevel = 1;
	}
	
	public int getLevel(){
		return mLevel;
	}

	void OnGUI(){
		GUI.Label(new Rect(10,10,100,100),"Level: " + mLevel, mLevelStyle);
	}
}
