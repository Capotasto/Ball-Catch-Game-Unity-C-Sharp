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
		if(obj.gameObject.name.Equals("Enemy(Clone)")){
			Vector3 scale = transform.localScale;
			scale.x -= Random.Range(0.1f, 0.5f);
			transform.localScale = scale;
			if(transform.localScale.x < 1.0f){
				scale.x = 1.0f;
				transform.localScale = scale;
			}
			mScore.addScore (1);
		}
	}
}
