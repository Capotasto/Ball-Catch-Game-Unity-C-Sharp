#pragma strict

private var level : int = 1;
var style : GUIStyle;

function Start () {
	level = 1;
}

function getLevel(){
	return level;
}

function OnGUI () {
	GUI.Label(Rect(10,10,100,100),"Level: "+level, style);
}