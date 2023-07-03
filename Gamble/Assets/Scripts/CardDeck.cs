using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Object/Card Deck", fileName = "Card Deck")]
public class CardDeck : ScriptableObject
{
        public Sprite[] cardSprite;
    [SerializeField]
    private int month;
        public int Month { get { return month; } } // ī���� ���� ���ϴ� �μ�
    [SerializeField]
    private bool specialCard;
        public bool SpecialCard  { get { return specialCard;} } // ī�尡 ���̳� Ư���� ����� �������� Ȯ��
    
}




