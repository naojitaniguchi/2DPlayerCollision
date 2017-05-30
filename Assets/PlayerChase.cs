using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChase : MonoBehaviour {
    public GameObject playerObject;
    public float xOffset = 1.0f;
    public float yOffset = 1.0f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float x_len = playerObject.transform.position.x - gameObject.transform.position.x;
        if ( x_len > xOffset)
        {
            float xDiff = x_len - xOffset;
            gameObject.transform.position = new Vector3(gameObject.transform.position.x + xDiff, gameObject.transform.position.y, gameObject.transform.position.z);
        }
        if (x_len < xOffset *-1.0f)
        {
            float xDiff = x_len + xOffset;
            gameObject.transform.position = new Vector3(gameObject.transform.position.x + xDiff, gameObject.transform.position.y, gameObject.transform.position.z);
        }
        float y_len = playerObject.transform.position.y - gameObject.transform.position.y;
        if (y_len > yOffset)
        {
            float yDiff = y_len - yOffset;
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + yDiff, gameObject.transform.position.z);
        }
        if (y_len < yOffset * -1.0f)
        {
            float yDiff = y_len + yOffset;
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + yDiff, gameObject.transform.position.z);
        }


    }
}
