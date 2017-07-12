using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeinTarget : MonoBehaviour {
	public GameObject[] fadeinTargets ;

	// Use this for initialization
	void Start () {
		for ( int i = 0 ; i < fadeinTargets.Length ; i ++ ){
			fadeinTargets[i].SetActive(false);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void startFadein(){
		for ( int i = 0 ; i < fadeinTargets.Length ; i ++ ){
			fadeinTargets[i].SetActive(true);
		}
	}
}
