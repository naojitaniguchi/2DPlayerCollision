using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Conversation : MonoBehaviour {
	public GameObject textObject ;
	public GameObject textTop ;
	public string[] texts;
	bool conversationStarted = false ;
	int textCount = 0 ;

	// Use this for initialization
	void Start () {
		
	}

	private IEnumerator closeText() {  
		// 1秒待つ  
		yield return new WaitForSeconds (1.0f);  
		textTop.SetActive( false ) ;
	}  
	
	// Update is called once per frame
	void Update () {
		if ( conversationStarted ){
			if ( Input.GetKeyDown( KeyCode.Space )){
				textObject.GetComponent<Text>().text = texts[textCount];
				textCount ++ ;
				if ( textCount == texts.Length ){
					StartCoroutine ("closeText");
					conversationStarted = false ;
				}
			}
		}
	}

	public void startConversation(){
		conversationStarted = true ;
		textTop.SetActive( true ) ;
		textObject.GetComponent<Text>().text = texts[textCount];
		textCount ++ ;
	}
}
