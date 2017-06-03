using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public float speed;

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

    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        Debug.Log("hit");
		Debug.Log(coll.gameObject);
        Debug.Log(coll.contacts[0].point);

		gameObject.GetComponent<ChangeSceneByCollisionEnter>().changeSceneByCollision( coll.gameObject );
    }

}
