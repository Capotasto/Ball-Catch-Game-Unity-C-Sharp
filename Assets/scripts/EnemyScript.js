#pragma strict

public var Score : ScoreScript;
private var highScore : float;

function Start(){
	Score = GameObject.Find("ScoreSystem").GetComponent("ScoreScript") as ScoreScript;
	highScore = PlayerPrefs.GetFloat("HIGH_SCORE",0);

}

function Update () {
	transform.position.z -= 0.1;
	transform.Rotate(1,1,1);

	if(transform.position.z < -12.0) {
		Destroy(gameObject);
		Score.subLife();
		if(Score.getLife() <= 0){
			//Save Hight Score
			if(highScore < Score.getScore()){
				PlayerPrefs.SetFloat("HIGH_SCORE",Score.getScore());
			}

			//Application.LoadLevel("GameOver");
			UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver");
		}

	}
}

function OnCollisionEnter(){
	Destroy(gameObject);	
}