using System.Collections.Generic;
using UnityEngine;

public class CardDeck : MonoBehaviour
{
    SpriteRenderer Sprite;
    public Sprite Cardback;
    private void Start()
    {
        Sprite= GetComponent<SpriteRenderer>();
        Show();
    }

    void Show()
    {
        Sprite.sprite = Cardback;
    }
}




