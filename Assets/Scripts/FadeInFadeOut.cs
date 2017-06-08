using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeInFadeOut : MonoBehaviour {
	GameObject fadeImageObject ;
	float fadeTime ;
	float alpha ;
	float t ;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void startFade(){
	}

	private IEnumerator loop() {
		// ループ
		while (true) {
			// 毎フレームループします
			yield return null;

			alpha = t / fadeTime ;
			float A2 = 1.0F - alpha ;
			fadeImageObject.GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, A2);
			t += Time.deltaTime ;

			if ( alpha > 1.0f ){
				// loadscane
			}

			Debug.Log("loop");

			// これで色を指定する
		}
	}

}
