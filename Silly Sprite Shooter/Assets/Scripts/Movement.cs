using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour {

    public float speed = 0.1f;
    public Vector3 BulletOffset = new Vector3(0, 0, 0);
    public float timer;
    public GameObject bulletPrefab;
    public int points;
    public int level;
    private float currentTime;
    private AudioSource sound;
	// Use this for initialization
	void Start () {
        currentTime = 0;
        sound = GameObject.FindGameObjectWithTag("Player").GetComponent<AudioSource>();
	}

    // Update is called once per frame
    private void Update()
    {
        //Keyboard Inputs
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))            //Move Left
        {
            transform.position += new Vector3(-speed,0,0);
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))          //Move Right
        {
            transform.position += new Vector3(speed, 0, 0);
        }

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))             //Move Up
        {
            transform.position += new Vector3(0, speed, 0);
        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))           //Move Down
        {
            transform.position += new Vector3(0, -speed, 0);
        }

        currentTime += Time.deltaTime;                                            //Fire
        if (currentTime > timer)
        {
            if (Input.GetKey(KeyCode.Space))                                      
            {
                GameObject temp = Instantiate<GameObject>(bulletPrefab);
                temp.transform.position = this.transform.position + BulletOffset;
                sound.Play();
                currentTime = 0;
            }
        }

        //level 1 completed

        //Boundary limits
        if (transform.position.x == -7.55f && transform.position.y == -4.2f)
            transform.position = new Vector3(-7.55f, -4.2f, transform.position.z);
        //
        else if (transform.position.x == 7.55f && transform.position.y == -2.5f)
            transform.position = new Vector3(7.55f, -2.5f, transform.position.z);
        //
        else if (transform.position.x == -7.55f && transform.position.y == 4.28f)
            transform.position = new Vector3(-7.55f, 4.28f, transform.position.z);
        //
        else if (transform.position.x == 7.55f && transform.position.y == 4.28f)
            transform.position = new Vector3(7.55f, 4.28f, transform.position.z);
        else if (transform.position.x <= -7.55f)
            transform.position = new Vector3(-7.55f, transform.position.y, transform.position.z);
        //
        else if (transform.position.x >= 7.55f)
            transform.position = new Vector3(7.55f, transform.position.y, transform.position.z);
        //
        else if (transform.position.y <= -2.5f)
            transform.position = new Vector3(transform.position.x, -2.5f, transform.position.z);
        //
        else if (transform.position.y >= 4.28f)
            transform.position = new Vector3(transform.position.x, 4.28f, transform.position.z);
    }
}

    

