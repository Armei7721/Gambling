using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cardtest : MonoBehaviour
{
    private CardSprite cardSprite;
    private List<Sprite> cardPool;

    private void Awake()
    {
        cardSprite = GetComponent<CardSprite>();
    }

    private void Start()
    {
        InitializeCardPool();
    }

    private void InitializeCardPool()
    {
        cardPool = new List<Sprite>(cardSprite.faces);
    }

    public Sprite DrawCard()
    {
        if (cardPool.Count == 0)
        {
            Debug.LogWarning("No cards left in the deck.");
            return null;
        }

        int randomIndex = Random.Range(0, cardPool.Count);
        Sprite drawnCard = cardPool[randomIndex];
        cardPool.RemoveAt(randomIndex);
        return drawnCard;
    }
}
