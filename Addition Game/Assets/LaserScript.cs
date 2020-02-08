using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LaserScript : MonoBehaviour
{
  
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * 10 * Time.deltaTime);
        if(transform.position.y > 10f)
        {
            Destroy(gameObject);
        }
    }
    
}
