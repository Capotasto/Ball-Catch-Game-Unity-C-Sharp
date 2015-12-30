#pragma strict

var enemy : Transform;

function Update () {

	if(Time.frameCount % 60 == 0){
		Instantiate(enemy, Vector3(Random.Range(-5.0,5.0),1,8), transform.rotation);
	}
}
