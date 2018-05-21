using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour {

    public int level;
    private Movement player;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Movement>();
	}
	
	// Update is called once per frame
	void Update () {
		if(level == 1 && player.points == 0)
        {
            SceneManager.LoadScene("complete_easy");
        }

        if (level == 2 && player.points == 0)
        {
            SceneManager.LoadScene("complete_medium");
        }

        if (level == 3 && player.points == 0)
        {
            SceneManager.LoadScene("complete_hard");
        }

        if (level == 4 && player.points == 0)
        {
            SceneManager.LoadScene("complete_extreme");
        }


    }
}
