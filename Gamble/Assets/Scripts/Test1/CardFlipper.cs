using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardFlipper : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    CardShuffle shuffle;
    public AnimationCurve scaleCurve;
    public float duration = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        shuffle = GetComponent<CardShuffle>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void FlipCard(Sprite startImage, Sprite EndImage, int cardIndex)
    {
        StopCoroutine(Flip(startImage,EndImage, cardIndex));
        StartCoroutine(Flip(startImage, EndImage, cardIndex));
    }
    IEnumerator Flip(Sprite startImage, Sprite endImage, int cardIndex)
    {
        spriteRenderer.sprite = startImage;
        float time = 0f;
        while (time <= 1)
        {
            float scale = scaleCurve.Evaluate(time);
            time = time + Time.deltaTime / duration;
            Vector3 localScale = transform.localScale;
            localScale.x = scale;
            transform.localScale = localScale;
            if(time >= 0.5f)
            {
                spriteRenderer.sprite = endImage;
            }
            yield return new WaitForFixedUpdate();
        }
        if(cardIndex== -1)
        {
            shuffle.ToggleFace(false);
        }
        else
        {
            shuffle.cardIndex = cardIndex;
            shuffle.ToggleFace(true);
        }
    }
}
