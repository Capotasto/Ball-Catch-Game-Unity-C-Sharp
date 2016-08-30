using UnityEngine;
using System.Collections;

public class EnemyScript_CSharp : MonoBehaviour {

	public ScoreScript_CSharp mScoreScript;
	private float mHightScore;

	// Use this for initialization
	void Start () {
		mScoreScript = GameObject.Find("ScoreSystem").GetComponent("ScoreScript_CSharp") as ScoreScript_CSharp;
		mHightScore = PlayerPrefs.GetFloat("HIGH_SCORE",0);
		//Change Bulet Size
		changeBuletScale ();
	}
	
	// Update is called once per frame
	void Update () {
		//Change Bulet Speed
		changeBuletSpeed();

		//Change Bulet Rotatition
		changeBuletRotation();

		if(transform.position.z < -12.0) {
			Destroy(gameObject);
			mScoreScript.subtractLife (1);
			if(mScoreScript.getLife() <= 0){
				//Save Hight Score
				if(mHightScore < mScoreScript.getScore()){
					PlayerPrefs.SetFloat("HIGH_SCORE", mScoreScript.getScore());
				}

				//Application.LoadLevel("GameOver");
				UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver");
			}

		}
	}

	void OnCollisionEnter(Collision colli){
		Destroy (gameObject);
	}

	private void changeBuletScale(){
		float buletScale = 0.0f;
		if (Application.loadedLevelName == "Stage1") {	
			buletScale = 0.5f;
		} else if (Application.loadedLevelName == "Stage2") {
			buletScale = 0.4f;
		} else if (Application.loadedLevelName == "Stage3") {
			buletScale = 0.3f;
		} else if (Application.loadedLevelName == "Stage4") {
			buletScale = 0.2f;
		}
		Vector3 scale = transform.localScale;
		scale.x = buletScale;
		scale.y = buletScale;
		scale.z = buletScale;
		transform.localScale = scale;
	}

	private void changeBuletSpeed(){
		float buletSpeed = 0.0f;
		if (Application.loadedLevelName == "Stage1") {	
			buletSpeed = 0.2f;
		} else if (Application.loadedLevelName == "Stage2") {
			buletSpeed = 0.25f;
		} else if (Application.loadedLevelName == "Stage3") {
			buletSpeed = 0.3f;
		} else if (Application.loadedLevelName == "Stage4") {
			buletSpeed = 0.4f;
		}
		Vector3 pos = transform.position;
		pos.z -= buletSpeed;
		transform.position = pos;
	}

	private void changeBuletRotation(){
		float buletRotate = 0.0f;
		if (Application.loadedLevelName == "Stage1") {	
			buletRotate = 1.0f;
		} else if (Application.loadedLevelName == "Stage2") {
			buletRotate = 1.2f;
		} else if (Application.loadedLevelName == "Stage3") {
			buletRotate = 1.4f;
		} else if (Application.loadedLevelName == "Stage4") {
			buletRotate = 1.6f;
		}
		transform.Rotate(buletRotate,buletRotate,buletRotate);
	}
}
