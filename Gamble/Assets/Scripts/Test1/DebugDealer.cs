using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugDealer : MonoBehaviour
{
    public CardStack dealer;
    public CardStack player;
    private void OnGUI()
    {
        
        {
            if(GUI.Button(new Rect(10,10,256,28),"Å¬¸¯"))
            {
                player.Push(dealer.Pop());
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
