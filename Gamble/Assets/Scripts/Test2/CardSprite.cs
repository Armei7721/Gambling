using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSprite : MonoBehaviour
{
    SpriteRenderer sprite;

    public List<Sprite> faces;
    public Sprite cardBack;

    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        ShuffleSprites();
        DrawCard();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ShuffleSprites()
    {
        for (int i = 0; i < faces.Count - 1; i++)
        {
            int randomIndex = Random.Range(i, faces.Count);
            Sprite tempSprite = faces[i];
            faces[i] = faces[randomIndex];
            faces[randomIndex] = tempSprite;
        }
    }

    public Sprite DrawCard()
    {
        Sprite drawnCard = faces[0];
        faces.RemoveAt(0);
        return drawnCard;

    }
}
