using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZoomCard : MonoBehaviour
{
    private static ZoomCard container_obj;

    public GameObject template;
    static GameObject container;

    static Transform panel;

    static Image card;

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

        card = panel.Find("Card_image").GetComponent<Image>();

        close = panel.Find("Close").GetComponent<Button>();


    }

    // Update is called once per frame
    
    public static void show_container(Sprite card_image)
    {
        initialization();
        card.sprite = card_image;
        
        close.onClick.AddListener(delegate
        {
            Object.Destroy(container);
        });
    }
}
