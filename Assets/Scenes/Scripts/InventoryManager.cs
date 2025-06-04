using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager instance;
    public ScriptableItem cosa;
    public Text[] cosaNombres;
    public Image[] cosaSprites;

    void Awake()
    {
        if(instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }

    public void AddItem(ScriptableItem item)
    {
        for(int i = 0; i < cosa.Lenght; instance ++)
        {
            if(cosa[i] == null)
            {
                cosa[i] = item;
                cosaNames[i].Text = itemName;
                cosaSprites[i].Sprite = itemSprite;

                return;
            }
        }
    }
}
