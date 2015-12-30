#pragma strict

function Update () {

	var x : float = Input.GetAxis("Horizontal");
	transform.Translate(x* 0.3,0,0);

}

function OnCollisionEnter(obj:Collision){
	
	if	(obj.gameObject.name == "Enemy(Clone)"){
		transform.localScale.x -= Random.Range(0.1, 0.5);
		if(transform.localScale.x < 1.0) transform.localScale.x = 1.0;

	}
}