using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public abstract class WeaponClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public abstract List<Collider> GetTargets(Vector3 sourcePos, List<Collider> possibleTargets);

    /*
    public virtual List<Collider> GetTargets(Vector3 sourcePos, List<Collider> possibleTargets)
    {
        List<Collider> chosenTargets = new();

        chosenTargets.Add(possibleTargets[0]);

        return chosenTargets;
    }*/
}
