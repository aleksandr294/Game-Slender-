using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Icon : MonoBehaviour
{
    Image i_card;
    Image my_body_card;

    Transform I;
    Transform My_body;

    SpriteCreater sprite_creater = new SpriteCreater();

    GameSession game_session;
    // Start is called before the first frame update
    private void Awake()
    {
        game_session = Object.FindObjectOfType<GameSession>();

        I = gameObject.transform.Find("I");
        My_body = gameObject.transform.Find("My_Body");

        i_card = I.Find("I_card").GetComponent<Image>();
        my_body_card = My_body.Find("My_Body_card").GetComponent<Image>();
    }

    void Start()
    {
        if(game_session.I != "" && game_session.My_Body != "")
        {
            i_card.sprite = sprite_creater.create(game_session.I);
            my_body_card.sprite = sprite_creater.create(game_session.My_Body);
            alpha_channel(i_card);
            alpha_channel(my_body_card);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void set_icons(Sprite i, Sprite my_body)
    {
        i_card.sprite = i;
        my_body_card.sprite = my_body;
        alpha_channel(i_card);
        alpha_channel(my_body_card);
    }

    public void alpha_channel(Image image)
    {
        var color = image.color;
        color.a = 1f;
        image.color = color;
    }
}
