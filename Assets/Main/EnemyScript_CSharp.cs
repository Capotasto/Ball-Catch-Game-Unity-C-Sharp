using UnityEngine;
using System.Collections;

public class EnemyScript_CSharp : MonoBehaviour {

	public ScoreScript_CSharp mScore;
	private float mHightScore;

	// Use this for initialization
	void Start () {
		mScore = GameObject.Find("ScoreSystem").GetComponent("ScoreScript_CSharp") as ScoreScript_CSharp;
		mHightScore = PlayerPrefs.GetFloat("HIGH_SCORE",0);
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = transform.position;
		pos.z -= 0.2f;
		transform.position = pos;
		transform.Rotate (1,1,1);

		if(transform.position.z < -12.0) {
			Destroy(gameObject);
			mScore.subtractLife (1);
			if(mScore.getLife() <= 0){
				//Save Hight Score
				if(mHightScore < mScore.getScore()){
					PlayerPrefs.SetFloat("HIGH_SCORE",mScore.getScore());
				}

				//Application.LoadLevel("GameOver");
				UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver");
			}

		}
	}

	void OnCollisionEnter(Collision colli){
		Destroy (gameObject);
	}
}
