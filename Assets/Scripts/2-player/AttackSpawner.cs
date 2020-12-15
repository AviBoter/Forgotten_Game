
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component spawns the given object whenever the player clicks a given key.
 */
public class AttackSpawner : MonoBehaviour
{
    [SerializeField] protected KeyCode FireUp;
    [SerializeField] protected KeyCode FireDown;
    [SerializeField] protected KeyCode FireLeft;
    [SerializeField] protected KeyCode FireRight;
    [SerializeField] protected GameObject prefabToSpawn;
    [SerializeField] private float AttackSpeed = 5f;
    [SerializeField] private float attackCoolDown = 2f;
    [SerializeField] private bool isEnemy = false;


    private float attackAllowed;



    protected virtual GameObject spawnObject(Vector3 velocityOfSpawnedObject)
    {
        // Step 1: spawn the new object.
        Vector3 positionOfSpawnedObject = transform.position;  // span at the containing object position.
        Quaternion rotationOfSpawnedObject = Quaternion.identity;  // no rotation.
        GameObject newObject = Instantiate(prefabToSpawn, positionOfSpawnedObject, rotationOfSpawnedObject);

        // Step 2: modify the velocity of the new object.
        FireBallMover newObjectMover = newObject.GetComponent<FireBallMover>();
        if (newObjectMover)
        {
            newObjectMover.SetVelocity(velocityOfSpawnedObject);
        }

        return newObject;
    }

    void Start()
    {
        attackAllowed = Time.time;
    }

    void Update()
    {
        // cooldown

        if (Time.time > attackAllowed)
        {
            {
                if (!isEnemy) 
                    playerAttack();
                
                else 
                    enemyAttack();
            }
        }
    }

    private void playerAttack() {

        if (Input.GetKeyDown(FireUp))
        {
            spawnObject(new Vector3(0, AttackSpeed, 0));
            attackAllowed = Time.time + attackCoolDown;
        }
        else if (Input.GetKeyDown(FireDown))
        {
            spawnObject(new Vector3(0, -AttackSpeed, 0));
            attackAllowed = Time.time + attackCoolDown;
        }
        else if (Input.GetKeyDown(FireLeft))
        {
            spawnObject(new Vector3(-AttackSpeed, 0, 0));
            attackAllowed = Time.time + attackCoolDown;
        }
        else if (Input.GetKeyDown(FireRight))
        {
            spawnObject(new Vector3(AttackSpeed, 0, 0));
            attackAllowed = Time.time + attackCoolDown;
        }
    }

    private void enemyAttack() {
        spawnObject(new Vector3(0, AttackSpeed, 0));
        attackAllowed = Time.time + attackCoolDown;
    }

}

