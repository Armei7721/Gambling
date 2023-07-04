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
            // 왼쪽에 카드 복제
            test3 = Instantiate(test2, transform.position - new Vector3(2f, 4f, 0f), Quaternion.identity);
            test3.AddComponent<CardSprite>();
            CardSprite cloneCardSpriteScript = test3.GetComponent<CardSprite>();

            if (cloneCardSpriteScript != null)
            {
                // 뽑힌 카드 가져오기
                Sprite drawnCard = cloneCardSpriteScript.DrawCard();
                Debug.Log("발동");
                // 복제된 카드의 SpriteRenderer에 뽑힌 카드를 표시
                cloneCardSpriteScript.GetComponent<SpriteRenderer>().sprite = drawnCard;
            }

            cardCount++;
            Debug.Log(cardCount);
        }
    }

}
