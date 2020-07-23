using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LimitContainer : MonoBehaviour
{
    private static LimitContainer container_obj;

    public GameObject template;
    static GameObject container;

    static Transform panel;

    static Image situation_card;

    static Button situation_button;

    static ScrollRect exercise_sr;

    static Text limitation_t;
    static Text questions_t;
    static Text exercise_t;

    static Button next_question;
    static Button close;

    static List<string> questions;

    static string exercise;

    private void Awake()
    {
        container_obj = this;
    }

    public static void initialization()
    {
        container = Object.Instantiate(container_obj.template);

        panel = container.transform.Find("Dialog");

        situation_card = panel.Find("Button").GetComponent<Image>();

        exercise_sr = panel.Find("Exercise").GetComponent<ScrollRect>();

        limitation_t = panel.Find("Limitation").GetComponent<Text>();
        questions_t = panel.Find("Questions").GetComponent<Text>();
        exercise_t = panel.Find("Exercise").Find("Viewport").Find("Content").GetComponent<Text>();

        next_question = panel.Find("Next_Question").GetComponent<Button>();
        close = panel.Find("Close").GetComponent<Button>();
        situation_button = panel.Find("Button").GetComponent<Button>();

        questions = new List<string>()
        {
            "Что изображено на этой картинке?",
            "Как картинка ассоциируется с выпавшим мне ограничением?",
            "Есть ли на этой картинке Я?",
            "Какое мое поведение, какие черты характера или какие мысли привели к этой ситуации?",
            "Какова моя роль в происходящем?"
        };

        exercise = "Сначала прочитайте, затем прикройте глаза и проделайте упражнение.\n\n Вдох - выдох. Смотрите на ситуацию как бы со стороны. Мысленно меняйте ее так, как вам бы хотелось, чтобы тогда это было. Когда вас устраивает результат, мысленно поблагодарите участников этой ситуации за полученный опыт, каким бы он ни был. Вдох - выдох.\n Улыбка!";

    }

    public static void show_container(Sprite situation_srpite_card, string limit)
    {
        initialization();
        situation_card.sprite = situation_srpite_card;
        limitation_t.text += " " + limit;
        questions_t.text += "\n\n\n" + questions[0];
        questions.RemoveAt(0);

        next_question.onClick.AddListener(delegate
        {
            if (questions.Count > 0)
            {
                questions_t.text = "\n\n\n" + questions[0];
                questions.RemoveAt(0);
            }
            else
            {
                questions_t.text = exercise;
                next_question.gameObject.SetActive(false);
                close.gameObject.SetActive(true);
            }
        });

        situation_button.onClick.AddListener(delegate
        {
            ZoomCard.show_container(situation_card.sprite);
        });

        close.onClick.AddListener(delegate
        {
            Object.Destroy(container);
        });
    }
}
