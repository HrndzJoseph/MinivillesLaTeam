using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCard : Card
{
    public RedCard(CardData pData) : base(pData)
    {
        data = pData;
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void Effect()
    {
        if (data.nameCard == "Caf�")
        {
            GameManager.GetInstance().activePlayer.money--;
            /*owner.money++;*/
        }
        if (data.nameCard == "Restaurant")
        {
            GameManager.GetInstance().activePlayer.money -= 2;
            /*owner.money += 2;*/
        }
    }
}
