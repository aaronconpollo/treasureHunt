using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class hints : MonoBehaviour {
	
	public Transform goal;
	public Transform player;
	public Text textUI;

	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


		if (player.position.z < -50f ) {
			textUI.text = "Treasure is near. Head northwest to the stick person sculpture";
		}

		else if (player.position.z > 11f && player.position.z < 55f && player.position.x < -45f) {
			textUI.text = "Darn. Just a statue. Did that hula-hooping snowman to the east just glint?";
		}

		else if (player.position.z > 72f && player.position.z < 92f && player.position.x > 72f) {
			textUI.text = "UGH. Nothing. Ok that sunken hotdog to the northwest is the key. FOR SURE.";
		}

		else if (player.position.z > 109f && player.position.z < 166f  && player.position.x < 2f) {
			textUI.text = "The non-sunken end of the dog seems to be pointing northeast to something behind the rocks.";
		}

		else if(textUI.text == "YOU WIN!!!!!!!!!!!"){
			textUI.text = "YOU WIN!!!!!!!!!!!";
		}

		else {
			textUI.text = "";
		}

		
	}
}
