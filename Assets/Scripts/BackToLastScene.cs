using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToLastScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void changeScnene(){
		UnityEngine.SceneManagement.SceneManager.LoadScene(SceneNameKeep.lastScene);
	}
}
