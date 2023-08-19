﻿
using UnityEngine;

public class Sword : MonoBehaviour
{

    [SerializeField]
    private SwordData swordData; // 1

    private void OnMouseDown() // 2
    {
        Debug.Log(swordData.SwordName); // 3
        Debug.Log(swordData.Description); // 3
        Debug.Log(swordData.Icon.name); // 3
        Debug.Log(swordData.GoldCost); // 3
        Debug.Log(swordData.AttackDamage); // 3
    }
}
