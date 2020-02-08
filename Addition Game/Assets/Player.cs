using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public AudioSource laserSound;
    public bool canFire = true;
    public GameObject laser;
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, -3f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * speed * horizontalInput * Time.deltaTime);
        
        if(transform.position.x > 6.5f)
        {
            transform.position = new Vector3(-6.5f, transform.position.y, 0);
        }
        else if(transform.position.x < -6.5f)
        {
            transform.position = new Vector3(6.5f, transform.position.y, 0);
        }
        if (Input.GetKeyDown(KeyCode.Space) && canFire == true)
        {
            laserSound.Play();
            Instantiate(laser, transform.position + new Vector3(0,0.83f,0), Quaternion.identity);
            canFire = false;
            StartCoroutine(WaitForSeconds(3));
        }
    }

    IEnumerator WaitForSeconds(float n)
    {
        yield return new WaitForSeconds(n);
        canFire = true;
    }
  
}
