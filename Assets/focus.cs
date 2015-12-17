using UnityEngine;
using System.Collections;

public class focus : MonoBehaviour {
	Transform target;
	float smoothing = 3.0f;
	float threshold = 0.5f;

	float waitTime = 0.1f;
	//Viewer view;
	// Use this for initialization
	void Start () {
		//view = GameObject.Find ("Main Camera").GetComponent<Viewer> ();
		target = GameObject.Find ("Main Camera").GetComponent<Viewer> ().target;
	}
	
	//void OnMouseDown(){
	public void moveCamera(){
		//Debug.Log (name);
		//target.position = gameObject.transform.position; so this jerks the camera to focus on coin--want to smooth this
		StopCoroutine ("lerpCamera");
		//wth
		StopAllCoroutines ();
		StartCoroutine ("lerpCamera");
	}


	IEnumerator lerpCamera(){ //lerps target (cam's target) to destination dest
		/*
		yield return new WaitForSeconds (waitTime);
		while (gameObject.GetComponent<Rigidbody>().velocity.sqrMagnitude > 0) {
			yield return null;
		}*/
		Vector3 dest = gameObject.transform.position;
		while(Vector3.Distance(target.position, dest) > threshold)
		{
			target.position = Vector3.Lerp(target.position, dest, smoothing * Time.deltaTime);
			
			yield return null;
		}
		yield return null;
	}
}
