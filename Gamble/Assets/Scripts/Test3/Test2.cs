using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour
{
    enum JokBo
    {
        KK_0 , KK_1 , KK_2 , KK_3 , KK_4 , KK_5, KK_6, KK_7, KK_8, KK_9,
        DD_1, DD_2, DD_3, DD_4, DD_5, DD_6, DD_7, DD_8, DD_9, DD_10,
        KD_13 = 113, KD_18 = 118, KD_38 = 138
    }
    public struct CARD
    {
        public int month;
        public string shape;
    }
    public struct PLAYER
    {
        public string name;
        public CARD card1;
        public CARD card2;
        public int jokbo;
        public int gold;
    }

    public CARD[] Deck;
    public PLAYER[] User;
    int PlayerNum = 4;
    int Input;

    int WinCount;

    // Start is called before the first frame update
    void Start()
    {
        User = new PLAYER[PlayerNum];
        for (int i = 0; i < PlayerNum; i++)
        {
            Debug.Log(i + 1 + "¹øÂ° ÇÃ·¹ÀÌ¾î ÀÌ¸§");
        }
        Deck = new CARD[20];

        InitDeck();
        Shuffle(Deck);
        Deal();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void PlayerSelect()
    {
        if (PlayerNum > 4)
        {
            Debug.Log("4 ÀÌÇÏ¸¸ °¡´ÉÇÕ´Ï´Ù. ´Ù½Ã ÀÔ·ÂÇØ ÁÖ¼¼¿ä!");
        }
        else if (PlayerNum == 1)
        {
            Debug.Log("È¥ÀÚ¼­´Â ÇÃ·¹ÀÌ ÇÒ ¼ö ¾ø½À´Ï´Ù. ´Ù½Ã ÀÔ·ÂÇØ ÁÖ¼¼¿ä!");
        }
    }

    void InitDeck()
    {
        for (int i = 0; i < 20; i++)
        {
            Deck[i].month = (i % 10) + 1;
            Deck[i].shape = "";
        }
        Deck[0].shape = "±¤"; // 1±¤
        Deck[2].shape = "±¤"; // 3±¤
        Deck[7].shape = "±¤"; // 8±¤
    }

    void Shuffle(CARD[] Deck1)
    {
        for (int i = 0; i < 20; i++)
        {
            int sour = Random.Range(0, 20);
            int dest = Random.Range(0, 20);
            CARD tempCard = Deck1[sour];
            Deck1[sour] = Deck1[dest];
            Deck1[dest] = tempCard;
        }
    }

    void MakeJokbo(PLAYER[] User, int PlayerNum)
    {
        for (int i = 0; i < PlayerNum; i++)
        {
            if (User[i].card1.shape == "±¤" && User[i].card2.shape == "±¤")
            {
                if (User[i].card1.month + User[i].card2.month == 4)
                {
                    User[i].jokbo = (int)JokBo.KD_13;
                }
            }
            else if (User[i].card1.shape == "±¤" && User[i].card2.shape == "±¤")
            {
                if (User[i].card1.month + User[i].card2.month == 9)
                {
                    User[i].jokbo = (int)JokBo.KD_18;
                }
                else
                {
                    User[i].jokbo = (int)JokBo.KD_38;
                }
            }
            else if (User[i].card1.month == User[i].card2.month)
            {
                User[i].jokbo = (int)JokBo.KK_9 + User[i].card1.month;
            }
            else
            {
                User[i].jokbo = (User[i].card1.month + User[i].card2.month) % 10;
            }
        }
    }

    void PrintJokbo(int jokbo)
    {
        if (jokbo >= (int)JokBo.KD_13)
        {
            Debug.Log(jokbo % 100 + "±¤¶¯");
        }
        else if (jokbo >= (int)JokBo.DD_1)
        {
            Debug.Log(jokbo % 100 + "¶¯");
        }
        else
        {
            Debug.Log(jokbo + "²ý");
        }
    }

    void Deal()
    {
        for (int i = 0; i < PlayerNum; i++)
        {
            User[i].card1 = Deck[i];
            User[i].card2 = Deck[i + 10];
        }
        MakeJokbo(User, PlayerNum);

        int max = (int)JokBo.KK_0;

        for (int i = 0; i < PlayerNum; i++)
        {
            if (max < User[i].jokbo)
            {
                max = User[i].jokbo;
                WinCount = 1;
            }
            else if (max == User[i].jokbo)
            {
                WinCount++;
            }
        }

        for (int i = 0; i < PlayerNum; i++)
        {
            Debug.Log(User[i].name);
            Debug.Log(User[i].card1.month);
            Debug.Log(User[i].card1.shape);
            Debug.Log(User[i].card2.month);
            Debug.Log(User[i].card2.shape);
            PrintJokbo(User[i].jokbo);
        }

        Shuffle(Deck);
    }
}
