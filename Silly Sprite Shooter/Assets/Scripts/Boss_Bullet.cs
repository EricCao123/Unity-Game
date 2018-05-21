using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Boss_Bullet : MonoBehaviour
{

    public float timer = 1.0f;
    private float currentTime;
    public float speed = 1.0f;
    public Slider health;
    public float damage = 10f;

    // Use this for initialization
    void Start()
    {
        currentTime = 0;
        health = GameObject.FindGameObjectWithTag("Health").GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if (currentTime > timer)
        {
            Destroy(this.gameObject);
        }
        transform.position -= new Vector3(0, speed, 0);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Contains("Player"))
        {
            Destroy(this.gameObject);
            health.value -= damage;
            if (health.value == 0)
            {
                SceneManager.LoadScene("gameOver");
            }
        }
    }
}
