using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AsteroidScript : MonoBehaviour
{
    public Button ans;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.tag == "Laser")
        {
            ans.onClick.Invoke();
            Destroy(collision.gameObject);
        }
        
    }
}
