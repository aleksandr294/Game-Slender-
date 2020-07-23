using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Button instruction;
    public Button settings;
    public Button exit;

    void Start()
    {
        instruction.onClick.AddListener(delegate
        {
            InstructionContainer.show_container();
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
