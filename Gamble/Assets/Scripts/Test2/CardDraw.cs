using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDraw : MonoBehaviour
{
    public GameObject brankCard; // �� ī�� ������

    private Dictionary<string, CardDictionary> cities; // ī�� ������ ���� ��ųʸ�

    private void Start()
    {
        // cities ��ųʸ� �ʱ�ȭ
        cities = new Dictionary<string, CardDictionary>();
        
        // ī�� �̱� ���� ȣ��
        DrawCard();
    }

    private void DrawCard()
    {
        // ������ �� Ű�� ����
        string randomMonth = GetRandomMonth();

        // ������ ���� ī�� ���� ��������
        CardDictionary cardData = cities[randomMonth];

        // ���ο� ī�� ������Ʈ ����
        GameObject newCard = Instantiate(brankCard, transform.position, Quaternion.identity);

        // DicTest ������Ʈ �߰� �� ī�� ���� �Ҵ�
        DicTest cardScript = newCard.AddComponent<DicTest>();
        cardScript.deckNum = cardData.month;
        cardScript.onemonth = cardData.sprites;
        // �߰����� �۾� ���� ���� (��: ī�带 �����ִ� ��)
    }

    private string GetRandomMonth()
    {
        // cities ��ųʸ��� Ű �� �����ϰ� ����
        List<string> keys = new List<string>(cities.Keys);
        int randomIndex = Random.Range(0, keys.Count);
        string randomMonth = keys[randomIndex];
        return randomMonth;
    }
}
