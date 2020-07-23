using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoom : MonoBehaviour
{
    float default_width = 1f;
    float default_height = 1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.B))
        {
            transform.localScale = new Vector3(Mathf.Lerp(default_width, default_width += 0.5f, Time.time), Mathf.Lerp(default_height, default_height += 0.5f, Time.time), 1f);
            //transform.localScale = new Vector3(Mathf.PingPong(Time.time, default_width + 0.5f - default_width) + 0.5f, Mathf.PingPong(Time.time, default_height + 0.5f - default_height) + 0.5f, 1f);

            //Debug.Log("dfdf");
        }
        if (Input.GetKeyUp(KeyCode.M))
        {
            transform.localScale = new Vector3(Mathf.Lerp(default_width, default_width -= 0.5f, Time.time), Mathf.Lerp(default_height, default_height -= 0.5f, Time.time), 1f);
            //transform.localScale = new Vector3(Mathf.PingPong(Time.time, default_width + 0.5f - default_width) + 0.5f, Mathf.PingPong(Time.time, default_height + 0.5f - default_height) + 0.5f, 1f);

            //Debug.Log("dfdf");
        }
    }
}
