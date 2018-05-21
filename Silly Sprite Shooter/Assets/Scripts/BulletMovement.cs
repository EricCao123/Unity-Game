using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
public class BulletMovement : MonoBehaviour {

    public float speed = 1.5f;
    public float timer = 1.0f;
    private float currentTime;
    private RectTransform bar;
    
    

    // Use this for initialization
    void Start () {
        currentTime = 0;
    }
	
	// Update is called once per frame
	void Update () {
        currentTime += Time.deltaTime;
        if(currentTime > timer)
        {
            Destroy(this.gameObject);
        }
        transform.position += new Vector3(0, speed, 0);
    }



    
}
