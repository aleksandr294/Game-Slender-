using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Save : MonoBehaviour
{
    private GameSession game_session;
    private const string path_file = "save_game_session.json";

    void Start()
    {
        game_session = Object.FindObjectOfType<GameSession>();
    }

    public void save()
    {
        string json = JsonUtility.ToJson(game_session, true);
        using (FileStream fstream = new FileStream(path_file, FileMode.Create))
        {
            byte[] array = System.Text.Encoding.Default.GetBytes(json);
            fstream.Write(array, 0, array.Length);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
