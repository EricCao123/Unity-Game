using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {
    Movement player;
    public int points;
	// Use this for initialization
	void Start () {
        player = FindObjectOfType<Movement>();

	}

    private void OnTriggerEnter2D(Collider2D hit)
    {
        if(hit.CompareTag("Player")){
            player.points += points;
            Destroy(gameObject);
        }
    }
}
