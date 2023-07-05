using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    SpriteRenderer spriteRenderer;

    private int cardIndex;
    public GameObject test2;
    public GameObject test3;
    Test test;
    int cardCount = 0;
    private CardSprite card;

    Dictionary<string, CardDictionary> cities = new Dictionary<string, CardDictionary>();

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        cardIndex = Random.Range(0, 39);
        card = test2.GetComponent<CardSprite>();

        if (card != null)
        {
            Clone();
        }
        else
        {
            Debug.LogError("CardSprite component not found on test2 object.");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Clone()
    {
        if (cardCount < 1)
        {
            // 왼쪽에 카드 복제
            GameObject cloneCardSprite = Instantiate(test2, transform.position - new Vector3(2f, 4f, 0f), Quaternion.identity);

            // 뽑힌 카드 가져오기
            Sprite drawnCard = card.DrawCard();

            // 복제된 카드의 SpriteRenderer에 뽑힌 카드를 표시
            cloneCardSprite.GetComponent<SpriteRenderer>().sprite = drawnCard;

            cardCount++;
            Debug.Log(cardCount);
        }
    }
}