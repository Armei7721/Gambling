using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CardSprite : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    
    public Sprite[] faces;
    public Sprite cardBack;
    public int cardIndex;
    public GameObject test2;
    public GameObject test3;
    public GameObject test5;
    Test test;
    int cardCount = 0;
    // Start is called before the first frame update
    void start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        cardIndex = Random.Range(0, faces.Length);
        ShuffleSprites();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ShuffleSprites()
    {
        for (int i = 0; i < faces.Length - 1; i++)
        {
            int randomIndex = Random.Range(i, faces.Length);
            Sprite tempSprite = faces[i];
            faces[i] = faces[randomIndex];
            faces[randomIndex] = tempSprite;
            
        }
    }
    public void ToggleFace(bool showFace)
    {
        if (showFace)
        {
            spriteRenderer.sprite = faces[cardIndex];
        }
        else
        {
            spriteRenderer.sprite = cardBack;
        }
    }

}
