using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using UnityEngine;

public class PlayerInventory : MonoBehaviour, IInventory    
{
    public int Money { get => money; set => money = value; }

    public int money=0;

}
