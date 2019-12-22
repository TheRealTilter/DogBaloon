using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour {

    public static bool isGameOver = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(isGameOver);
        if (Input.GetKeyDown(KeyCode.Return) && isGameOver) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            isGameOver = false;
        }
	}
}