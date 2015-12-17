using UnityEngine;
using System.Collections;


public class pickUp : MonoBehaviour {
	public GameObject c;


	//this outputs (disp, duration) pair specifying how far and how long to move coin
	float[] interpolatePush(float ratio){
		float[] rtn = new float[2]; 
		if (ratio <= .1f) {
			float t = Mathf.InverseLerp(0,.1f,ratio);
			//Debug.Log ("hi");
			rtn[0] = Mathf.Lerp(0,.098f,t);
			rtn[1] = Mathf.Lerp(0,.713f,t);
			return rtn;
		}
		if (ratio <= .2f) {
			float t = Mathf.InverseLerp(.1f,.2f,ratio);
			rtn[0] = Mathf.Lerp(.098f,.527f,t);
			rtn[1] = Mathf.Lerp(.713f,.6f,t);
			return rtn;
		}
		if (ratio <= .3f) {
			float t = Mathf.InverseLerp(.2f,.3f,ratio);
			rtn[0] = Mathf.Lerp(.527f,1.23f,t);
			rtn[1] = Mathf.Lerp(.6f,.82f,t);
			return rtn;
		}
		if (ratio <= .4f) {
			float t = Mathf.InverseLerp(.3f,.4f,ratio);
			rtn[0] = Mathf.Lerp(1.23f,2.17f,t);
			rtn[1] = Mathf.Lerp(.82f,1.21f,t);
			return rtn;
		}
		if (ratio <= .5f) {
			float t = Mathf.InverseLerp(.4f,.5f,ratio);
			rtn[0] = Mathf.Lerp(2.17f,3.29f,t);
			rtn[1] = Mathf.Lerp(1.21f,1.39f,t);
			return rtn;
		}
		if (ratio <= .6f) {
			float t = Mathf.InverseLerp(.5f,.6f,ratio);
			rtn[0] = Mathf.Lerp(3.29f,4.574f,t);
			rtn[1] = Mathf.Lerp(1.39f,1.491f,t);
			return rtn;
		}
		if (ratio <= .7f) {
			float t = Mathf.InverseLerp(.6f,.7f,ratio);
			rtn[0] = Mathf.Lerp(4.574f,6.0f,t);
			rtn[1] = Mathf.Lerp(1.491f,1.543f,t);
			return rtn;
		}
		if (ratio <= .8f) {
			float t = Mathf.InverseLerp(.7f,.8f,ratio);
			rtn[0] = Mathf.Lerp(6.0f,7.56f,t);
			rtn[1] = Mathf.Lerp(1.543f,1.577f,t);
			return rtn;
		}
		if (ratio <= .9f) {
			float t = Mathf.InverseLerp(.8f,.9f,ratio);
			rtn[0] = Mathf.Lerp(7.56f,9.234f,t);
			rtn[1] = Mathf.Lerp(1.577f,1.542f,t);
			return rtn;
		}
		if (ratio <= 1.0f) {
			float t = Mathf.InverseLerp(.9f,1.0f,ratio);
			rtn[0] = Mathf.Lerp(9.234f,11.0f,t);
			rtn[1] = Mathf.Lerp(1.542f,1.676f,t);
			return rtn;
		}
		//make this an else
		return rtn;
	} 





	void Awake () {
	
	}


	
	// Update is called once per frame
	void Update () {
	
	}
}
