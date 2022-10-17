using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackround : MonoBehaviour
{
    private float _xRange = 19.08f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -_xRange)
        {
            transform.position = new Vector2(_xRange, 0);
        }
    }
}
