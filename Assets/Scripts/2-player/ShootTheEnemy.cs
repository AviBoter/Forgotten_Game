using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof (ClosestEnemy))]
public class ShootTheEnemy : MonoBehaviour
{
    private ClosestEnemy script;
    private Transform enemy;
    private float radius = 2f;
    // Start is called before the first frame update
    void Start()
    {
        ClosestEnemy script = GetComponent<ClosestEnemy>();
    }

    // Update is called once per frame
    void Update()
    {
        if (script.nearestEnemy != null) {
            enemy = script.nearestEnemy;

            if (Vector2.Distance(transform.position, enemy.position) <= radius) {
                Destroy(enemy);

            }
        }
    }
}
