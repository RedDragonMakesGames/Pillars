using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Minion", menuName = "TDGameplay/Minion", order = 2)]
public class MinionData : ScriptableObject
{
    public int health;
    public float moveSpeed;

}
