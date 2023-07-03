using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardStack : MonoBehaviour
{
    public List<int> cards;
    public bool isGameDeck;
    public bool HasCards
    {
        get{ return cards != null && cards.Count > 0; }
    }
    public int CardCount
    {
        get
        {
            if(cards == null)
            {
                return 0;
            }
            else
            {
                return cards.Count;
            }
        }
    }
    public IEnumerable<int> GetCards()
    {
        foreach(int i in cards)
        {
            yield return i;
        }
    }    
    public int Pop()
    {
        int temp = cards[0];
        cards.RemoveAt(0);
        return temp;
    }
    public void Push(int card)
    {
        cards.Add(card);
    }
    public void Shuffle()
    {
        if(cards == null)
        {
            cards = new List<int>();
        }
        else
        {
            cards.Clear();
        }
        for(int i = 0;i< 40; i++)
        {
            cards.Add(i);
        }
        int n = cards.Count;
        while(n>1)
        {
            n--;
            int k = Random.Range(0, n + 1);
            int temp = cards[k];
            cards[k] = cards[n];
            cards[n] = temp;
        }
    }
    // Start is called before the first frame update
    void Awake()
    {
        cards = new List<int>();
        if(isGameDeck)
         {
            Shuffle(); 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
