using UnityEngine;
using System.Collections;

public class EnemeiesScritpt_CSharp : MonoBehaviour {

	public Transform enemy;

	// Update is called once per frame
	void Update () {
		if(Time.frameCount % 60 == 0){
			Instantiate(enemy, new Vector3(Random.Range(-5.0f,5.0f),1,8), transform.rotation);
		}
	}
}
