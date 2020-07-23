using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The class of the game session in which all dynamic data from the game is stored
/// </summary>
[System.Serializable]
public class GameSession : MonoBehaviour
{
    [SerializeField] private int circle_number;
    [SerializeField] private int cell_number;

    [SerializeField] private string i;
    [SerializeField] private string my_body;

    [SerializeField] private List<string> face_card_deck = new List<string>();
    [SerializeField] private List<string> situations_card_deck = new List<string>();
        
    [SerializeField] private List<string> limitations = new List<string>();


    /// <value>Accepts and returns the player’s position among circles</value>
    public int Circle_number
        {
            get
            {
                return circle_number;
            }
            set
            {
                circle_number = value;
            }
        }
    /// <value>Accepts and returns the player’s position among the cells in the circle.</value>
    public int Cell_number
        {
            get
            {
                return cell_number;
            }
            set
            {
                cell_number = value;
            }
        }
    /// <value>Accepts and returns the path to the picture characterizing the player</value>
    public string I
        {
            get
            {
                return i;
            }
            set
            {
                i = value;
            }
        }
    /// <value>Accepts and returns the path to the picture characterizing the player’s body</value>
    public string My_Body
        {
            get
            {
                return my_body;
            }
            set
            {
                my_body = value;
            }
        }
    /// <value>Accepts and returns a list of paths to the "Faces" deck</value>
    public List<string> Face_card_deck
        {
            get
            {
                return face_card_deck;
            }
            set
            {
                face_card_deck = value;
            }
        }
    /// <value>Accepts and returns a list of paths to the "Situations" deck</value>
    public List<string> Situations_card_deck
        {
            get
            {
                return situations_card_deck;
            }
            set
            {
                situations_card_deck = value;
            }
        }
    /// <value>Accepts and returns a list of restrictions</value>
    public List<string> Limitations
        {
            get
            {
                return limitations;
            }
            set
            {
                limitations = value;
            }
        }
    
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    private void Start()
    {
           
    }
    private void Update()
    {

    }
}
