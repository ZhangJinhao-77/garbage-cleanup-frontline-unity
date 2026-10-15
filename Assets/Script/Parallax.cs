using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    public Transform cam;
    public float moveRate;
    private float starPointX,starPointY;
    public bool lockY;//FALSE

    void Start()
    {
        starPointX = transform.position.x;
        starPointY = transform.position.y;
    }

    
    void Update()
    {
        if (lockY)
        {
            transform.position = new Vector2(starPointX + cam.position.x * moveRate, transform.position.y);
        }
        else
        {
            transform.position = new Vector2(starPointX + cam.position.x * moveRate, starPointY + cam.position.y*moveRate);
        }
        
    }
}
