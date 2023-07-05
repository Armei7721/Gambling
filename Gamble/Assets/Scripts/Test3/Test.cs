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
            // ���ʿ� ī�� ����
            GameObject cloneCardSprite = Instantiate(test2, transform.position - new Vector3(2f, 4f, 0f), Quaternion.identity);

            // ���� ī�� ��������
            Sprite drawnCard = card.DrawCard();

            // ������ ī���� SpriteRenderer�� ���� ī�带 ǥ��
            cloneCardSprite.GetComponent<SpriteRenderer>().sprite = drawnCard;

            cardCount++;
            Debug.Log(cardCount);
        }
    }
}