using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public ScriptableItem item;
    public SpriteRenderer spiteRendered;

    void Awake()
    {
        spiteRendered = GetComponent<SpriteRenderer>();
    }

    void Start()
    {
        spiteRendered.sprite = itemInfo.itemSprite;
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        InventoryManager.instance.AddItem(itemInfo);
        Destroy(gameObject);
    }
}
