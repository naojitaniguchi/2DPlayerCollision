using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTest : MonoBehaviour {

	public GameObject playerObject ;

	public enum MoveDir{
		UP,
		DOWN,
		RIGHT,
		LEFT
	}

	public MoveDir dir ;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void pushed(){
		Debug.Log( "pushed");
	}

	public void pointerUp(){
		playerObject.GetComponent<Player>().buttonUpped();
		Debug.Log( "pointerUp");
	}

	public void pointerDown(){
		switch( dir ){
		case MoveDir.UP:
			playerObject.GetComponent<Player>().upButtonPushed();
			break;
		case MoveDir.DOWN:
			playerObject.GetComponent<Player>().downButtonPushed();
			break;
		case MoveDir.LEFT:
			playerObject.GetComponent<Player>().leftButtonPushed();
			break;
		case MoveDir.RIGHT:
			playerObject.GetComponent<Player>().rightButtonPushed();
			break;
		}
		Debug.Log( "pointerDown");
	}

}
