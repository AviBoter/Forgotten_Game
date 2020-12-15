using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosestPlayer : MonoBehaviour
{
    private Transform Player;

    public List<Transform> EnemyList;

    public Transform nearestEnemy;

    [Tooltip("attack radius")]
    [SerializeField] private float radius = 2f;
   // private bool active = false;

    void Start()
    {
        Player = gameObject.GetComponent<Transform>();
        StartCoroutine(waiter());
    }


    IEnumerator waiter()
    {
        for (; ; )
        {
          
            float minimumDistance = Mathf.Infinity;

            nearestEnemy = null;
            foreach (Transform enemy in EnemyList)
            {
                if (enemy != null)
                {
                    float distance = Vector2.Distance(Player.position, enemy.position);
                    if (distance < minimumDistance)
                    {
                        minimumDistance = distance;
                        nearestEnemy = enemy;
                    }
                }


            }
            if (nearestEnemy != null && Vector2.Distance(transform.position, nearestEnemy.position) <= radius)
            {

                Destroy(nearestEnemy.gameObject);
                EnemyList.Remove(nearestEnemy);
           
            }


   
                yield return new WaitForSeconds(1);
             
        }
    }
}