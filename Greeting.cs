using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Greeting : MonoBehaviour
{
    private static Greeting container_obj;

    public GameObject template;
    static GameObject container;

    static Transform panel;

    static Button close;
    // Start is called before the first frame update
    private void Awake()
    {
        container_obj = this;
    }

    public static void initialization()
    {
        container = Object.Instantiate(container_obj.template);

        panel = container.transform.Find("Dialog");

        close = panel.Find("Close").GetComponent<Button>();

    }

    public static void show_container()
    {
        initialization();
        close.onClick.AddListener(delegate
        {
            Object.Destroy(container);
            var b = new CenterIMyBodyCreator().FactoryMethod();
            b.action();
        });
    }
}
