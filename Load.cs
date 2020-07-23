using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;


/// <summary>
/// A class for loading data from a game session file into the GameSession class
/// </summary>
public class Load : MonoBehaviour
{
    private GameSession game_session;
    private string path_file;
    private Text text_button;

    /// <summary>
    /// The method is called when the game starts and checks if the file exists under the name save_game_session.json and if it is not there, 
    /// then the path to the default_game_session.json file is assigned to the path_file field; if there is save_game_session.json
    /// </summary>
    void Start()
    {
        if (!System.IO.File.Exists("save_game_session.json"))
            path_file = "default_game_session.json";
        else
        {
            text_button = transform.GetChild(0).GetComponent<Text>();
            text_button.text = "Продолжить игру";
            path_file = "save_game_session.json";
        }
        game_session = Object.FindObjectOfType<GameSession>();
    }

    /// <summary>
    /// The method starts when you click the "New game" or "Continue the game" button, loading data from the default_game_session.json or save_game_session.json file into the game session class and launching Board scene
    /// </summary>
    public void load()
    {
        using (FileStream fstream = File.OpenRead(path_file))
        {
            byte[] array_byte = new byte[fstream.Length];
            fstream.Read(array_byte, 0, array_byte.Length);
            string json = System.Text.Encoding.Default.GetString(array_byte);
            JsonUtility.FromJsonOverwrite(json, game_session);
            Debug.Log("Successfully");
        }
        SceneManager.LoadScene(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
