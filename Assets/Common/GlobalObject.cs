using UnityEngine;
using System.Collections;

public class GlobalObject : MonoBehaviour {

	public static GlobalObject sInstance;
	public static string HIGH_SCORE_STAGE1 = "high_score_stage1";
	public static string HIGH_SCORE_STAGE2 = "high_score_stage2";
	public static string HIGH_SCORE_STAGE3 = "high_score_stage3";
	public static string HIGH_SCORE_STAGE4 = "high_score_stage4";

	public static bool isCreardStage1;
	public static bool isCreardStage2;
	public static bool isCreardStage3;
	public static bool isCreardStage4;
	public static int PlayingStageNumber = 0;

	private GlobalObject(){
		isCreardStage1 = false;
     	isCreardStage2 = false;
     	isCreardStage3 = false;
     	isCreardStage4 = false;
	}
}