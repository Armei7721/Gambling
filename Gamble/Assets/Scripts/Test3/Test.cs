using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    SpriteRenderer spriteRenderer;

    
    
    private int cardIndex;
    public GameObject test2;
    public GameObject test3;
    //public GameObject test5;
    Test test;
    int cardCount = 0;
    private CardSprite card;
    
    Dictionary<string, CardDictionary> cities = new Dictionary<string, CardDictionary>();
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        cardIndex = Random.Range(0, 39);
        Clone();
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
            test3 = Instantiate(test2, transform.position - new Vector3(2f, 4f, 0f), Quaternion.identity);
            test3.AddComponent<CardSprite>();
            CardSprite cloneCardSpriteScript = test3.GetComponent<CardSprite>();

            if (cloneCardSpriteScript != null)
            {
                // ���� ī�� ��������
                Sprite drawnCard = cloneCardSpriteScript.DrawCard();
                Debug.Log("�ߵ�");
                // ������ ī���� SpriteRenderer�� ���� ī�带 ǥ��
                cloneCardSpriteScript.GetComponent<SpriteRenderer>().sprite = drawnCard;
            }

            cardCount++;
            Debug.Log(cardCount);
        }
    }

}
