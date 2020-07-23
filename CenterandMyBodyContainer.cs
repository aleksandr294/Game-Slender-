using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CenterandMyBodyContainer : MonoBehaviour
{
    // Start is called before the first frame update
    private static CenterandMyBodyContainer container_obj;

    public GameObject template;
    static GameObject container;
    static GameObject next_question_obj;
    static GameObject close_obj;

    static Transform panel;
    static Transform i;
    static Transform my_Body;

    static Image i_card;
    static Image myBody_card;
    static Image button_image;

    static Text questions_about_me_t;
    static Text questions_about_my_body_t;
    static Text general_questions_t;

    static Button next_question;
    static Button close;

    static List<string> questions_about_me;
    static List<string> questions_about_my_body;
    static List<string> general_questions;

    static Icon icon;

    private void Awake()
    {
        container_obj = this;
    }

    private void Update()
    {
    }

    public static void initialization()
    {
        container = Object.Instantiate(container_obj.template);

        icon = Object.FindObjectOfType<Icon>();

        panel = container.transform.Find("Dialog");
        i = panel.Find("I").GetComponent<Transform>();
        my_Body = panel.Find("MyBody").GetComponent<Transform>();

        i_card = i.Find("I_Card").GetComponent<Image>();
        questions_about_me_t = i.Find("Questions_About_Me").GetComponent<Text>();

        myBody_card = my_Body.Find("MyBody_Card").GetComponent<Image>();
        questions_about_my_body_t = my_Body.Find("Questions_About_My_Body").GetComponent<Text>();

        general_questions_t = panel.Find("General_Questions").GetComponent<Text>();

        next_question = panel.Find("Next_Question").GetComponent<Button>();
        close = panel.Find("Close").GetComponent<Button>();

        next_question_obj = panel.Find("Next_Question").GetComponent<GameObject>();
        close_obj = panel.Find("Close").GetComponent<GameObject>();

        questions_about_me = new List<string>
        {
            "Что нравиться или не нравиться в этом образе?",
            "Какие эмоции вызывает это выражение лица?",
            "Какие мысли, чувства есть у этого человека?"
        };

        questions_about_my_body = new List<string>
        {
            "Что нравиться или не нравиться в этом образе?",
            "Про что думает, чувствует, говорит человек с образом такого тела?"
        };

        general_questions = new List<string>()
        {
            "Знают ли эти образы друг друга?",
            "Что их связывает?",
            "Что они думают и чувствуют друг к другу?",
            "Всё, как вы ответили на вопросы, это так, как видит ваше подсознание ситуацию с вашим лишним весом."
        };

    }
    //Sprite i_srpite_card, Sprite my_bod_sprite_card
    public static void show_container(Sprite i_srpite_card, Sprite my_body_sprite_card)
    {
        
        initialization();
        alpha_channel(i_card);
        i_card.sprite = i_srpite_card;
        questions_about_me_t.text = questions_about_me[0];
        questions_about_me.RemoveAt(0);

        next_question.onClick.AddListener(delegate
        {
            if (questions_about_me.Count != 0)
            {
                questions_about_me_t.text = questions_about_me[0];
                questions_about_me.RemoveAt(0);
            }

            else if (questions_about_my_body.Count != 0)
            {
                if (questions_about_me.Count == 0)
                {
                    alpha_channel(myBody_card);
                    myBody_card.sprite = my_body_sprite_card;
                    questions_about_me_t.text = "";
                }

                questions_about_my_body_t.text = questions_about_my_body[0];
                questions_about_my_body.RemoveAt(0);
            }

            else if (general_questions.Count != 0)
            {
                if (questions_about_my_body.Count == 0)
                {
                    questions_about_my_body_t.text = "";
                }

                general_questions_t.text = general_questions[0];
                general_questions.RemoveAt(0);
            }

            else
            {
                close.gameObject.SetActive(true);
                next_question.gameObject.SetActive(false);

            }
        });

        close.onClick.AddListener(delegate
        {
            icon.set_icons(i_srpite_card, my_body_sprite_card);
            Object.Destroy(container);
        });
    }

    //public static void next_question()
    //{
    //    if (questions.Count != 0)
    //        question.text = questions.Dequeue();

    //    //else if (questions.Count == (9 - 3))
    //    //    myBody_card.sprite = 

    //    else if(questions.Count == 0)
    //    {
    //        Object.Destroy(container);
    //    }
    //}

    public static void alpha_channel(Image image)
    {
        var color = image.color;
        color.a = 1f;
        image.color = color;
    }
}
