using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CardShuffle : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public Sprite[] faces;
    public Sprite cardBack;
    public int cardIndex;


    // Start is called before the first frame update
    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        cardIndex=Random.Range(0,faces.Length);
    }

    // Update is called once per frame
    void Update()
    {
        
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
