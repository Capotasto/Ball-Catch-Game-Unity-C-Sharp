using UnityEngine;
using System.Collections;

public class LevelScript_CSharp : MonoBehaviour {

	private int mLevel = 1;

	// Use this for initialization
	void Start () {
		mLevel = 1;
	}
	
	public int getLevel(){
		return mLevel;
	}
}
