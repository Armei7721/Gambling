using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugChangeCard : MonoBehaviour
{
    CardFlipper flipper;
    CardShuffle cardShuffle;
    int cardIndex = 0;
    public GameObject card;
    // Start is called before the first frame update
    void Start()
    {
        cardShuffle = card.GetComponent<CardShuffle>();
        flipper = card.GetComponent<CardFlipper>();
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnGUI()
    {
        if(GUI.Button (new Rect (10,10,100,28),"클릭하세요"))
        {
            if(cardIndex >= cardShuffle.faces.Length)
            {
                cardIndex = 0;
 //               cardShuffle.ToggleFace(false);
                flipper.FlipCard(cardShuffle.faces[cardIndex - 1], cardShuffle.cardBack, -1);
            }
            else
            {
                cardShuffle.cardIndex = cardIndex;
//                cardShuffle.ToggleFace(true);
                if(cardIndex>0)
                {
                    flipper.FlipCard(cardShuffle.faces[cardIndex - 1], cardShuffle.faces[cardIndex], cardIndex);
                }
                else
                {
                    flipper.FlipCard(cardShuffle.cardBack, cardShuffle.faces[cardIndex], cardIndex);

                }
                cardIndex++;
            }
        }
    }
}
