#pragma strict

function Update () {

	if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved){
		transform.Translate(Input.GetTouch(0).deltaPosition.x/90,0,0);

	}

	//var x : float = Input.GetAxis("Horizontal");
	//transform.Translate(x* 0.3,0,0);

}

function OnCollisionEnter(obj:Collision){
	
	if	(obj.gameObject.name == "Enemy(Clone)"){
		transform.localScale.x -= Random.Range(0.1, 0.5);
		if(transform.localScale.x < 1.0) transform.localScale.x = 1.0;

	}
}