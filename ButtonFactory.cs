using System.Collections;
using System.Collections.Generic;
using UnityEngine;


abstract class CreatorButton
{
    public abstract IButton FactoryMethod();
}

class CenterIMyBodyCreator : CreatorButton
{
    public override IButton FactoryMethod()
    {
        return new CenterIMyBodyButton();
    }
}

class CausesOfOverweightCreator : CreatorButton
{
    public override IButton FactoryMethod()
    {
        return new CausesOfOverweightCreatorButton();
    }
}

class LimitationCreater : CreatorButton
{
    public override IButton FactoryMethod()
    {
        return new LimitationButton();
    }
}

public interface IButton
{
    void action();
    void highlight_button();
}

class CenterIMyBodyButton : IButton
{
    GameSession game_session;
    SpriteCreater sprite_creater = new SpriteCreater();

    Sprite i_card;
    Sprite my_body_card;

    string path_i_card;
    string path_my_body_card;
    
    public void action()
    {
        game_session = Object.FindObjectOfType<GameSession>();
        int size_card = game_session.Face_card_deck.Count;
        
        path_i_card = Application.dataPath + "/StreamingAssets/Deck of Face Cards/" + game_session.Face_card_deck[Random.RandomRange(0, size_card)];
        path_my_body_card = Application.dataPath + "/StreamingAssets/Deck of Face Cards/" + game_session.Face_card_deck[Random.RandomRange(0, size_card)];

        i_card = sprite_creater.create(path_i_card);
        my_body_card = sprite_creater.create(path_my_body_card);

        CenterandMyBodyContainer.show_container(i_card, my_body_card);
    }

    public void highlight_button()
    {
        
    }
}

class CausesOfOverweightCreatorButton : IButton
{
    public GameObject button;

    private SpriteRenderer sprite_renderer;

    public GameObject Button
    {
        set
        {
            button = value;
        }
    }

    public void action()
    {
    }

    public void highlight_button()
    {
    }
}

class LimitationButton : IButton
{
    GameSession game_session;
    SpriteCreater sprite_creater = new SpriteCreater();

    Sprite situation_card;

    string path_limitation_card;
    string limitation;

    public void action()
    {
        game_session = Object.FindObjectOfType<GameSession>();

        int size_card = game_session.Situations_card_deck.Count;
        int size_limitations = game_session.Limitations.Count;

        path_limitation_card = Application.dataPath + "/StreamingAssets/Deck of Situations Cards/" + game_session.Situations_card_deck[Random.RandomRange(0, size_card)];

        limitation = game_session.Limitations[Random.RandomRange(0, size_limitations)];

        situation_card = sprite_creater.create(path_limitation_card);

        LimitContainer.show_container(situation_card, limitation);
    }

    public void highlight_button()
    {
    }
}

