using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FrogControl : MonoBehaviour
{
	public Rigidbody2D rb;
	public AudioSource audio;
	//private int lives;

	void Start()
    {
		//lives = 5;
		audio = GetComponent<AudioSource>();
	}

	void Update()
	{

		if (Input.GetKeyDown(KeyCode.RightArrow))
			rb.MovePosition(rb.position + Vector2.right);
		else if (Input.GetKeyDown(KeyCode.LeftArrow))
			rb.MovePosition(rb.position + Vector2.left);
		else if (Input.GetKeyDown(KeyCode.UpArrow))
			rb.MovePosition(rb.position + Vector2.up);
		else if (Input.GetKeyDown(KeyCode.DownArrow))
			rb.MovePosition(rb.position + Vector2.down);

	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.tag == "Car")
		{
			SceneManager.LoadScene("ExitScene");
			audio.Play();
			//Tried to incorporate lives from here down but couldn't get it to work properly
			//Debug.Log("WE LOST!");
			//PlayerScore.CurrentScore = 0;
			//lives--;
			//if (lives <= 0)
			//{
			//	SceneManager.LoadScene("ExitScene");
			//}
			//else
			//{
			//	SceneManager.LoadScene(SceneManager.GetActiveScene().name);
			//	lives = lives - 1;
			//}
		}
	}
}
