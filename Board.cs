using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Board : MonoBehaviour
{
    // Start is called before the first frame update
    

    private void Awake()
    {
        game_session = Object.FindObjectOfType<GameSession>();
    }

    void Start()
    {
        if (game_session.I == "" && game_session.My_Body == "")
        {
            Greeting.show_container();
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
