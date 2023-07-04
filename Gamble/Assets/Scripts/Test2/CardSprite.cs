using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CardSprite : MonoBehaviour
{
    SpriteRenderer sprite;
    
    public Sprite[] faces;
    public Sprite cardBack;
    private int cardIndex;

    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        cardIndex = Random.Range(0, faces.Length);
        ShuffleSprites();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  
    public void ShuffleSprites()
    {
        for (int i = 0; i < faces.Length - 1; i++)
        {
            int randomIndex = Random.Range(i, faces.Length);
            Sprite tempSprite = faces[i];
            faces[i] = faces[randomIndex];
            faces[randomIndex] = tempSprite;
            
        }
    }
    //public void ToggleFace(bool showFace)
    //{
    //    if (showFace)
    //    {
    //        sprite.sprite = faces[cardIndex];
    //    }
    //    else
    //    {
    //        sprite.sprite = cardBack;
    //    }
    //}

}
