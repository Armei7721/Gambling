using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DicTest : MonoBehaviour
{
    public Sprite[] onemonth;
    public Sprite[] twomonth;
    public Sprite[] threemonth;
    public Sprite[] fourmonth;
    public Sprite[] fivemonth;
    public Sprite[] sixmonth;
    public Sprite[] sevenmonth;
    public Sprite[] eightmonth;
    public Sprite[] ninemonth;
    public Sprite[] tenmonth;
    public SpriteRenderer show;

    public GameObject test;
    public GameObject test2;

    private CardSprite card;
    public int deckNum;
    Dictionary<string, CardDictionary> cities = new Dictionary<string, CardDictionary>();

    private void Awake()
    {
        
        show = GetComponent<SpriteRenderer>();
        card = GetComponent<CardSprite>();
        //card = FindObjectOfType<CardSprite>();
    }
    private void OnEnable()
    {
        Assignment();
    }
    private void Start()
    {
        card = FindObjectOfType<CardSprite>();
        cities.Add("1월", new CardDictionary("1월", 1, false, onemonth));
        cities.Add("2월", new CardDictionary("2월", 2, false, twomonth));
        cities.Add("3월", new CardDictionary("3월", 3, false, threemonth));
        cities.Add("4월", new CardDictionary("4월", 4, false, fourmonth));
        cities.Add("5월", new CardDictionary("5월", 5, false, fivemonth));
        cities.Add("6월", new CardDictionary("6월", 6, false, sixmonth));
        cities.Add("7월", new CardDictionary("7월", 7, false, sevenmonth));
        cities.Add("8월", new CardDictionary("8월", 8, false, eightmonth));
        cities.Add("9월", new CardDictionary("9월", 9, false, ninemonth));
        cities.Add("10월", new CardDictionary("10월", 10, false, tenmonth));
        // Add card information for other months
        
        // Additional assignments if necessary for isSpecial field, etc.
        Show();
      
        
    }
    void Show()
    {   
        for (int i = 0; i < onemonth.Length; i++)
        {
            show.sprite = card.faces[i];
        }
    }
    void Clone()
    {
        test2 = Instantiate(test, transform.position, Quaternion.identity);
        CardSprite cloneCardSprite = test2.GetComponent<CardSprite>();
    }
    void Assignment()
    {
        for (int i = 0; i < onemonth.Length; i++)
        {
            onemonth[i] = card.faces[i];
            twomonth[i] = card.faces[i + onemonth.Length];
            threemonth[i] = card.faces[i + 2 * onemonth.Length];
            fourmonth[i] = card.faces[i + 3 * onemonth.Length];
            fivemonth[i] = card.faces[i + 4 * onemonth.Length];
            sixmonth[i] = card.faces[i + 5 * onemonth.Length];
            sevenmonth[i] = card.faces[i + 6 * onemonth.Length];
            eightmonth[i] = card.faces[i + 7 * onemonth.Length];
            ninemonth[i] = card.faces[i + 8 * onemonth.Length];
            tenmonth[i] = card.faces[i + 9 * onemonth.Length];
        }
    }

}
