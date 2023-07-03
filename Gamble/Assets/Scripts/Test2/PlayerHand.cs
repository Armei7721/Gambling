using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHand : MonoBehaviour
{
    public List<int> cards;
    public bool firstCard;
    public bool HasCards
    {
        get { return cards != null && cards.Count > 0; }
    }
    public int CardCount
    {
        get
        {
            if(cards ==null)
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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
