using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Player : MonoBehaviour {
    public float speed;
	public GameObject textObject ;
	bool upPushed = false ;
	bool downPushed = false ;
	bool leftPushed = false ;
	bool rightPushed = false ;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.up * speed * -1.0f;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.right * speed * -1.0f;
        }

		if (upPushed)
		{
			gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
		}
		if (downPushed)
		{
			gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.up * speed * -1.0f;
		}
		if (rightPushed)
		{
			gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
		}
		if (leftPushed)
		{
			gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.right * speed * -1.0f;
		}


    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        Debug.Log("hit");
		Debug.Log(coll.gameObject);
        Debug.Log(coll.contacts[0].point);

		//textObject.GetComponent<Text>().text = "痛っつ";

		gameObject.GetComponent<ChangeSceneByCollisionEnter>().changeSceneByCollision( coll.gameObject );

		if ( coll.gameObject.GetComponent<Conversation>() != null ){
			coll.gameObject.GetComponent<Conversation>().startConversation() ;
		}
    }

	public void upButtonPushed(){
		upPushed = true ;
	}

	public void downButtonPushed(){
		downPushed = true ;
	}

	public void leftButtonPushed(){
		leftPushed = true ;
	}

	public void rightButtonPushed(){
		rightPushed = true ;
	}

	public void buttonUpped(){
		upPushed = false ;
		downPushed = false ;
		leftPushed = false ;
		rightPushed = false ;
	}

}
