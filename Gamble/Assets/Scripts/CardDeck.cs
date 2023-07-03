using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Object/Card Deck", fileName = "Card Deck")]
public class CardDeck : ScriptableObject
{
        public Sprite[] cardSprite;
    [SerializeField]
    private int month;
        public int Month { get { return month; } } // 카드의 월을 정하는 인수
    [SerializeField]
    private bool specialCard;
        public bool SpecialCard  { get { return specialCard;} } // 카드가 광이나 특수한 기능을 가지는지 확인
    
}




