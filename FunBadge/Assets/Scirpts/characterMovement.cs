using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class characterMovement : MonoBehaviour {

	public float moveSpeed = 300;
	public GameObject character;

	private Rigidbody2D characterBody;
	private float ScreenWidth;

    public Text score_text;
    public int score;

	void Start () {

        score = 0;
        score_text.text = score.ToString();

		ScreenWidth = Screen.width;
		characterBody = character.GetComponent<Rigidbody2D>();
	}
	
	void Update () {

        score_text.text = score.ToString();

		int i = 0;
		//loop over every touch found
		while (i < Input.touchCount) {
			if (Input.GetTouch (i).position.x > ScreenWidth / 2) {
				//move right
				RunCharacter (1.0f);
			}
			if (Input.GetTouch (i).position.x < ScreenWidth / 2) {
				//move left
				RunCharacter (-1.0f);
			}
			++i;
		}
	}
	void FixedUpdate(){
		#if UNITY_EDITOR
		RunCharacter(Input.GetAxis("Horizontal"));
		#endif
	}

	private void RunCharacter(float horizontalInput){
		//move player
		characterBody.AddForce(new Vector2(horizontalInput * moveSpeed * Time.deltaTime, 0));

	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            score++;
            Destroy(collision.gameObject);
            //Debug.Log("hit");
        }
    }
}