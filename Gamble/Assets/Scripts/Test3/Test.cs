using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    SpriteRenderer spriteRenderer;

    
    public Sprite cardBack;
    private int cardIndex;
    public GameObject test2;
    public GameObject test3;
    public GameObject test5;
    Test test;
    int cardCount = 0;
    public CardSprite card;
    
    Dictionary<string, CardDictionary> cities = new Dictionary<string, CardDictionary>();
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        cardIndex = Random.Range(0, 39);
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
            test3 = Instantiate(test2, transform.position - new Vector3(2f, 0f, 0f), Quaternion.identity);

            CardSprite cloneCardSpriteScript = test3.GetComponent<CardSprite>();

            if (cloneCardSpriteScript != null)
            {
                cloneCardSpriteScript.faces = card.faces;
                int randomIndex = Random.Range(0, cloneCardSpriteScript.faces.Length);
                cloneCardSpriteScript.GetComponent<SpriteRenderer>().sprite = cloneCardSpriteScript.faces[randomIndex];
            }

            cardCount++;
            Debug.Log(cardCount);
        }
        else if (cardCount >= 1)
        {
            spriteRenderer.sprite = card.faces[cardIndex];
            // 오른쪽에 카드 복제
            GameObject test4 = Instantiate(test5, transform.position + new Vector3(2f, 0f, 0f), Quaternion.identity);

            CardSprite cloneCardSpriteScript = test4.GetComponent<CardSprite>();

            if (cloneCardSpriteScript != null)
            {
                cloneCardSpriteScript.faces = card.faces;
                int randomIndex = Random.Range(0, cloneCardSpriteScript.faces.Length);
                cloneCardSpriteScript.GetComponent<SpriteRenderer>().sprite = cloneCardSpriteScript.faces[randomIndex];
            }
        }
    }


}
