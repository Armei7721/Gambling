using UnityEngine;

public class DivCard : MonoBehaviour
{
    public CardSprite card;
    public int cardIndex;
    public Sprite sprite;
    private SpriteRenderer renderer;
    public int random;
    public int cardCount;
    void Start()
    {
        renderer = GetComponent<SpriteRenderer>();

    }
    private void Update()
    {

    }

    
    //public void Show()
    //{
    //    showCard = Instantiate(BlankCard, transform.position, Quaternion.identity);
    //    showCard.AddComponent<DicTest>();
    //    showCard.GetComponent<DicTest>().month = cardsprite.faces[0].month;       
    //        sprite = card.faces[0];         
    //    renderer.sprite = sprite;     
    //}

    public void  rand()
    {
        if (cardCount <= 1)
        {
            sprite = card.faces[0];

        }
    }
    public void Show()
    {
        renderer.sprite = sprite;
        Debug.Log(sprite);
    }

}
