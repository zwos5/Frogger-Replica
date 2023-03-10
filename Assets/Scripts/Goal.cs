using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
	void OnTriggerEnter2D()
	{
		Debug.Log("YOU WON!");
		PlayerScore.CurrentScore += 100;
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
