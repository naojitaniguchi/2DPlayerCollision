using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneByCollisionEnter : MonoBehaviour {

	public GameObject[] targetObjects ;
	public string[] sceneNames;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void changeSceneByCollision( GameObject collisionObject ){
		for ( int i = 0 ; i < targetObjects.Length ; i ++ ){
			if ( targetObjects[i] == collisionObject ){
				// SceneManager.LoadScene(sceneNames[i]);
				Debug.Log( sceneNames[i] );
			}
		}
	}
}
