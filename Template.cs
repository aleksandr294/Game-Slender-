using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Template : MonoBehaviour
{
    private static Template container_obj;

    public GameObject template;
    static GameObject container;
    // Start is called before the first frame update

    private void Awake()
    {
        container_obj = this;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void initialization()
    {
        container = Object.Instantiate(container_obj.template);
    }

    public static void show_container()
    {
        initialization();
        
    }
}
