using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class TestAttack : WeaponClass
{
    public override List<Collider> GetTargets(Vector3 sourcePos, List<Collider> possibleTargets)
    {
        Debug.Log("Overriding");
        List<Collider> chosenTargets = new();

        chosenTargets.Add(possibleTargets[0]);

        return chosenTargets;
    }
}
