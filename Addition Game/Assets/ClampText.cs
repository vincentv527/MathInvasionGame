using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClampText : MonoBehaviour
{
    public Text number;
    // Update is called once per frame
    void Update()
    {
        Vector3 numberPos = Camera.main.WorldToScreenPoint(this.transform.position);
        number.transform.position = numberPos;
    }
}
