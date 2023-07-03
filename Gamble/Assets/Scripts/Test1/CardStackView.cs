using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CardStack))]
public class CardStackView : MonoBehaviour
{
    CardStack CardStack;
    Dictionary<int, GameObject> fetchedCards;
    int lastCount;
    public Vector3 start;
    public float cardOffset;
    public GameObject cardPrefab;
    // Start is called before the first frame update
    void Start()
    {
        fetchedCards = new Dictionary<int,GameObject>();
        CardStack = GetComponent<CardStack>();
        ShowCards();
        lastCount = CardStack.CardCount;
    }
    public void ShowCards()
    {
        int cardCount =0;
        if (CardStack.HasCards)
        {
            foreach (int i in CardStack.GetCards())
            {
                float co = cardOffset * cardCount;
                Vector3 temp = start + new Vector3(co, 0f);
                AddCard(temp, i, cardCount);
               
                cardCount++;
            }
        }
    }
    void AddCard(Vector3 position, int cardIndex, int positionalIndex)
    {
        if(fetchedCards.ContainsKey(cardIndex))
        {
            return;
        }
        GameObject cardCopy = (GameObject)Instantiate(cardPrefab);
        cardCopy.transform.position = position;           
        
        CardShuffle cardShuffle = cardCopy.GetComponent<CardShuffle>();
        cardShuffle.cardIndex = cardIndex;
        cardShuffle.ToggleFace(true);
               
        SpriteRenderer spriteRenderer = cardCopy.GetComponent<SpriteRenderer>();
                
        spriteRenderer.sortingOrder = positionalIndex;

        fetchedCards.Add(cardIndex,cardCopy);

    }
    // Update is called once per frame
    void Update()
    {
        if(lastCount != CardStack.CardCount)
        {
            lastCount = CardStack.CardCount;
            ShowCards();
        }
    }
}
