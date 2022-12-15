using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerBehaviour : MonoBehaviour
{
    [SerializeField] public TowerData data;

    private int mAttackCount = 0;
    private bool mbIsAttacking;
    // Start is called before the first frame update
    void Start()
    {
        mbIsAttacking = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (mbIsAttacking) 
        {
            if (mAttackCount > data.attackDelay)
            {
                Attack();
                mAttackCount = 0;
            }
            mAttackCount++;
        }
    }

    void Attack()
    {
        //Check for enemies
        Collider[] objectsInRange = Physics.OverlapSphere(transform.position, data.attackRange);
        List<Collider> enemies = new();
        for (int i = 0; i < objectsInRange.Length; i++)
        {
            if (objectsInRange[i].CompareTag("Minion"))
            {
                enemies.Add(objectsInRange[i]);
            }
        }
        if (enemies.Count == 0)
        {
            //There are no enemies to attack
            return;
        }
        //Now we have a list of all attackable minions, use the WeaponClass overload from the tower data
        //to decide which one(s) to attack
        List<Collider> targets = data.attack.GetTargets(transform.position, enemies);
        for (int j = 0; j < targets.Count; j++)
        {
            //Attack all the selected minions
            AttackTarget(targets[j]);
        }
    }

    void AttackTarget(Collider target)
    {
        target.gameObject.GetComponent<MinionBehaviour>().GetAttacked();
    }
}
