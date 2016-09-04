using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EnemeiesScritpt_CSharp : MonoBehaviour {

	public Transform enemy;
	public Material newMaterialRef;
	private int mFrameCount;

	void Start(){
		if (SceneManager.GetActiveScene ().name == "Stage1") {
			mFrameCount = 60;
		}else if(SceneManager.GetActiveScene ().name == "Stage2"){
			mFrameCount = 55;
		}else if(SceneManager.GetActiveScene ().name == "Stage3"){
			mFrameCount = 50;
		}else if(SceneManager.GetActiveScene ().name == "Stage4"){
			mFrameCount = 40;
		}
	}

	// Update is called once per frame
	void Update () {


		if(Time.frameCount % 60 == 0){
			Instantiate(enemy, new Vector3(Random.Range(-5.0f,5.0f),1,8), transform.rotation);
			//enemy.GetComponent<Renderer>().material = newMaterialRef;
		}
	}
}
