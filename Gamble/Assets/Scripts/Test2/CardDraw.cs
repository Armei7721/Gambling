using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDraw : MonoBehaviour
{
    public GameObject brankCard; // 빈 카드 프리팹

    private Dictionary<string, CardDictionary> cities; // 카드 정보를 담은 딕셔너리

    private void Start()
    {
        // cities 딕셔너리 초기화
        cities = new Dictionary<string, CardDictionary>();
        
        // 카드 뽑기 동작 호출
        DrawCard();
    }

    private void DrawCard()
    {
        // 랜덤한 월 키를 선택
        string randomMonth = GetRandomMonth();

        // 선택한 월의 카드 정보 가져오기
        CardDictionary cardData = cities[randomMonth];

        // 새로운 카드 오브젝트 생성
        GameObject newCard = Instantiate(brankCard, transform.position, Quaternion.identity);

        // DicTest 컴포넌트 추가 및 카드 정보 할당
        DicTest cardScript = newCard.AddComponent<DicTest>();
        cardScript.deckNum = cardData.month;
        cardScript.onemonth = cardData.sprites;
        // 추가적인 작업 수행 가능 (예: 카드를 보여주는 등)
    }

    private string GetRandomMonth()
    {
        // cities 딕셔너리의 키 중 랜덤하게 선택
        List<string> keys = new List<string>(cities.Keys);
        int randomIndex = Random.Range(0, keys.Count);
        string randomMonth = keys[randomIndex];
        return randomMonth;
    }
}
