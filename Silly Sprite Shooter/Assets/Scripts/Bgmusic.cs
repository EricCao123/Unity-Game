using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bgmusic : MonoBehaviour {

    private AudioSource music;
    private float currentTime;
    private AudioSource audioSource;
    private AudioSource player;

    // Use this for initialization
    void Start () {
        player = GameObject.Find("Ship").GetComponent<AudioSource>();
        audioSource = GameObject.Find("Main Camera").GetComponent<AudioSource>();
        currentTime = 0;
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            player.mute = !player.mute;
            audioSource.mute = !audioSource.mute;
        }
    }
}
