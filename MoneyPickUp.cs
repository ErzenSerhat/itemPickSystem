using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MoneyPickUp : MonoBehaviour
{

    public int cashValue=1;
    void Update()
    {
        transform.Rotate(0f, 1f, 0f, Space.Self);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            IInventory inventory = other.GetComponent<IInventory>();
            if(inventory != null)
            {
                inventory.Money = inventory.Money + cashValue;
                Destroy(gameObject);
            }
        }
        
    }
}
