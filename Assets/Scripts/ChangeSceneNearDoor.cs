using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSceneNearDoor : MonoBehaviour {
	public GameObject DoorObject ;
	public Vector3 DoorOffset ;
	public float doorRadius ;
	public string sceneName ;
	public Color loadToColor = Color.white;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if ( Input.GetKeyDown(KeyCode.Space) ){
			Vector3 targetPos = DoorObject.transform.position + DoorOffset ;
			Vector3 diff = targetPos - gameObject.transform.position ;
			if ( diff.magnitude < doorRadius ){
				Initiate.Fade(sceneName,loadToColor,0.5f);
			}
		}
		
	}
}
