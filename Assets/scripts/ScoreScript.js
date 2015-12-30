#pragma strict

public static var score : float = 0.0;
private var life : int = 3;
var style : GUIStyle;

function Start () {
	score = 0;
	life = 3;
}

function addScore(){
	score += 10;
}

function getScore(){
	return score;
}

function subLife(){
	life -= 1;
}

function getLife(){
	return life;
}

function OnGUI () {
    GUI.Label(Rect(10,10,100,100),"Score: "+score, style);
    GUI.Label(Rect(10,60,100,100),"Life: "+life, style);
}
