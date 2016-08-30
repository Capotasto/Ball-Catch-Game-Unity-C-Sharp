using UnityEngine;
using System.Collections;

public class PlayerScript_CSharp : MonoBehaviour {

	public ScoreScript_CSharp mScore ;

	void Start(){
		mScore = GameObject.Find("ScoreSystem").GetComponent("ScoreScript_CSharp") as ScoreScript_CSharp;
	}

	// Update is called once per frame
	void Update () {
//		if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved){
//			transform.Translate(Input.GetTouch(0).deltaPosition.x/90,0,0);
//		}

		float x = Input.GetAxis("Horizontal");
		transform.Translate (x * 0.3f, 0, 0);
	}

	void OnCollisionEnter(Collision obj){
		float subScaleFrom = 0.0f;
		float subScaleTo = 0.0f;
		float minScale = 0.0f;
		int getPoint = 0;
		if (Application.loadedLevelName == "Stage1") {
			subScaleFrom = 0.1f;
			subScaleTo = 0.5f;
			minScale = 1.0f;
			getPoint = 10;
		} else if (Application.loadedLevelName == "Stage2") {
			subScaleFrom = 0.2f;
			subScaleTo = 0.6f;
			minScale = 0.8f;
			getPoint = 15;
		} else if (Application.loadedLevelName == "Stage3") {
			subScaleFrom = 0.3f;
			subScaleTo = 0.7f;
			minScale = 0.6f;
			getPoint = 30;
		} else if (Application.loadedLevelName == "Stage4") {
			subScaleFrom = 0.5f;
			subScaleTo = 1.0f;
			minScale = 0.3f;
			getPoint = 40;
		} 
		if(obj.gameObject.name.Equals("Enemy(Clone)")){
			Vector3 scale = transform.localScale;
			scale.x -= Random.Range(subScaleFrom, subScaleTo);
			transform.localScale = scale;
			if(transform.localScale.x < minScale){
				scale.x = minScale;
				transform.localScale = scale;
			}
			mScore.addScore (getPoint);
		}
	}
}
