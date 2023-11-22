using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


<<<<<<< Updated upstream
public class Card : ScriptableObject
{
    public Card(string pName, int pValueM, int pValueD, int pSecondValue, bool pOnlyCard, typeCard pType)
=======
//[CreateAssetMenu(fileName = "New card", menuName = "Card")]
public class Card : MonoBehaviour 
>>>>>>> Stashed changes
    {
    public Card(CardData pData)
    {
        data = pData;
    }

    protected CardData data;
    protected Player owner;

    public typeCard type;

    public enum typeCard
    {
        wheat,
        animal,
        shop,
        coffee,
        industry,
        business,
        factory,
        fruits
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void CardBought(Player player)
    {
        owner = player;
    }

    public virtual void Effect()
    {

    }
}