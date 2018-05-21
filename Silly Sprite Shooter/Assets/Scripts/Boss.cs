using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Boss : MonoBehaviour
{
    public float health = 2.0f;
    public float delta = 1.5f;  // Amount to move left and right from the start point
    public float speed = 2.0f;
    public Vector3 BulletOffset = new Vector3(0, 0, 0);
    public GameObject bulletPrefab;
    public float timer = 1.0f;
    public Slider health_bar;
    private float currentTime;
    private Vector3 startPos;
    private Movement player;
    Text label_score;

    void Start()
    {
        startPos = transform.position;
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Movement>();
        label_score = GameObject.FindGameObjectWithTag("Score").GetComponent<Text>();
    }

    private void Update()
    {
        Vector3 v = startPos;
        v.x += delta * Mathf.Sin(Time.time * speed);
        transform.position = v;

        currentTime += Time.deltaTime;
        if (currentTime > timer)
        {
         GameObject temp = Instantiate<GameObject>(bulletPrefab);
         temp.transform.position = this.transform.position + BulletOffset;
         currentTime = 0;
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Contains("Bullet"))
        {
            Destroy(other.gameObject);
            health_bar.value -= (100/health);
            if (health_bar.value <= 0)
            {
                Destroy(this.gameObject);
                SceneManager.LoadScene("finish");
            }
        }
    }


}
