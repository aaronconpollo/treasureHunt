using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class gameLogic : MonoBehaviour {

	public Text textUI;
	public Transform player;
	public Transform goal;
	public float distance = 10f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		distance =  Vector3.Distance(player.position, transform.position);

		if(distance < 6f && Input.GetKeyDown (KeyCode.Space) ) {
			textUI.text = "YOU WIN!!!!!!!!!!!";
		}
		else if (distance > 6f && Input.GetKeyDown (KeyCode.Space)) {
			textUI.text = "NOPE";
		}
	

	}
}
