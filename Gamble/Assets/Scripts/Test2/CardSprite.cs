using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSprite : MonoBehaviour
{
    SpriteRenderer sprite;

    public List<Sprite> faces;
    public Sprite cardBack;

    // Start is called before the first frame update
    public void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        ShuffleSprites();
      
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
        Sprite drawnCard = null;

        for (int i = 0; i < faces.Count; i++)
        {
            if (faces[i] != null)
            {
                drawnCard = faces[i];
                faces.RemoveAt(i);
                break;
            }
        }

        return drawnCard;
    }
}
