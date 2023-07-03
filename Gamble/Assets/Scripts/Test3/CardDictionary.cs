using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public struct CardDictionary
{
    public string name;
    public int month;
    public bool isSpecial;
    public Sprite[] sprites;
    

    public CardDictionary(string _name, int _month, bool _isSpecial, Sprite[] _sprites)
    {
        name = _name;
        month = _month;
        isSpecial = _isSpecial;
        sprites = _sprites;
        
    }
}