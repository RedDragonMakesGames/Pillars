using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

[CreateAssetMenu(fileName = "Tower", menuName = "TDGameplay/Tower", order = 1)]
public class TowerData : ScriptableObject
{
    public int towerHealth;
    public float attackDelay;
    public float attackRange;
    public GameObject attackPrefab;
    [HideInInspector] public WeaponClass attack = null;

    public void OnEnable()
    {
        attack = attackPrefab.GetComponent<WeaponClass>();
    }
}
