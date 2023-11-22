using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueCard : Card
{
    public BlueCard(CardData pData) : base(pData)
    {
        data = pData;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void Effect()
    {
        if (type == typeCard.wheat)
        {
            if (data.nameCard == "Champs de blé")
            {
                owner.money++;
            }
            if (data.nameCard == "Verger")
            {
                owner.money += 3;
            }
        }
        else if (type == typeCard.animal)
        {
            if (data.nameCard == "Ferme")
            {
                owner.money++;
            }
        }
        else if (type == typeCard.industry)
        {
            if (data.nameCard == "Forêt")
            {
                owner.money++;
            }
            if (data.nameCard == "Mine")
            {
                owner.money += 5;
            }
        }
    }
}