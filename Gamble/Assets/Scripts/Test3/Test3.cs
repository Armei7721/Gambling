using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test3 : MonoBehaviour
{
    public struct CardInfo
    {   [SerializeField]
        public string name;
        public int month;
        public bool isSp;
        public Sprite[] sprites;
    }

    public CardSprite card;
    public List<CardInfo> cardInfos = new List<CardInfo>();

    private void Awake()
    {
        card = GetComponent<CardSprite>();
        
    }

    private void Start()
    {
        Save();
    }
    public void Save()
    {
        for (int i = 0; i < card.faces.Count; i++)
        {
            CardInfo cardInfo = new CardInfo();
            Sprite cardSprite = card.faces[i];

            if (i < 4)
            {
                cardInfo.month = 1;
                cardInfo.name = "1��";
                cardInfo.sprites = new Sprite[] { cardSprite };
            }
            else if (i < 8)
            {
                cardInfo.month = 2;
                cardInfo.name = "2��";
                cardInfo.sprites = new Sprite[] { cardSprite };
            }
            else if (i < 12)
            {
                cardInfo.month = 3;
                cardInfo.name = "3��";
                cardInfo.sprites = new Sprite[] { cardSprite };
            }
            else if (i < 16)
            {
                cardInfo.month = 4;
                cardInfo.name = "4��";
                cardInfo.sprites = new Sprite[] { cardSprite };
            }
            else if (i < 20)
            {
                cardInfo.month = 5;
                cardInfo.name = "5��";
                cardInfo.sprites = new Sprite[] { cardSprite };
            }
            else if (i < 24)
            {
                cardInfo.month = 6;
                cardInfo.name = "6��";
                cardInfo.sprites = new Sprite[] { cardSprite };
            }
            else if (i < 28)
            {
                cardInfo.month = 7;
                cardInfo.name = "7��";
                cardInfo.sprites = new Sprite[] { cardSprite };
            }
            else if (i < 32)
            {
                cardInfo.month = 8;
                cardInfo.name = "8��";
                cardInfo.sprites = new Sprite[] { cardSprite };
            }
            else if (i < 36)
            {
                cardInfo.month = 9;
                cardInfo.name = "9��";
                cardInfo.sprites = new Sprite[] { cardSprite };
            }
            else if (i < 40)
            {
                cardInfo.month = 10;
                cardInfo.name = "10��";
                cardInfo.sprites = new Sprite[] { cardSprite };
            }

           // cardInfos.Add(cardInfo);
        }
    }
}