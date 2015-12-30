#pragma strict

public var Score : ScoreScript;


function Start(){
	Score = GameObject.Find("ScoreSystem").GetComponent("ScoreScript");

}

function Update () {
	transform.position.z -= 0.1;
	transform.Rotate(1,1,1);

	if(transform.position.z < -12.0) {
		Destroy(gameObject);
		Score.subLife();
		if(Score.getLife() <= 0){
			//Application.LoadLevel("GameOver");
			UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver");
		}

	}
}

function OnCollisionEnter(){
	Destroy(gameObject);	
}

function OnDestroy(){
	Score.addScore();
}