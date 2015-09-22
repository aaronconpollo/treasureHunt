using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class basicPlayerController : MonoBehaviour {
	float moveSpeed = 20f;
	float rotationSpeed = -90f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if(Input.GetKey (KeyCode.W) ){
			transform.position += new Vector3(0f, 0f, 1f)  * Time.deltaTime *moveSpeed;
			transform.eulerAngles = new Vector3(0f, 0f, 0f);
		}

		if(Input.GetKey (KeyCode.A) ){
			transform.position += new Vector3(-1f, 0f, 0f)  * Time.deltaTime * moveSpeed;
			transform.eulerAngles = new Vector3(0f, -90f, 0f);
		}

		if(Input.GetKey (KeyCode.S) ){
			transform.position += new Vector3(0f, 0f, -1f)  * Time.deltaTime *moveSpeed;
			transform.eulerAngles = new Vector3(0f, 180f, 0f);
		}
		
		if(Input.GetKey (KeyCode.D) ){
			transform.position += new Vector3(1f, 0f, 0f)  * Time.deltaTime * moveSpeed;
			transform.eulerAngles = new Vector3(0f, 90f, 0f);
		}

		Camera.main.transform.position = transform.position + new Vector3(0f, 7f, -12f);


	}
}
