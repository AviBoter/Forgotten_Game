using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;


public class ClosestEnemy : MonoBehaviour
{
    private Transform Player;

    public List<Transform> EnemyList;

    public Transform nearestEnemy ;

    [Tooltip("attack radius")]
    [SerializeField] private float radius = 3f;

    [Tooltip("attack key")]
    [SerializeField] private KeyCode Attackey;

    private bool Attackpressed = false;




    void Start()
    {
        Player = gameObject.GetComponent<Transform>();
        StartCoroutine(waiter());
    }

    void Update()
    {
        if (Input.GetKey(Attackey)) {
            Attackpressed = true;
        }
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
            if (nearestEnemy!=null && Vector2.Distance(transform.position, nearestEnemy.position) <= radius 
                                   && Attackpressed)
            {
                    Destroy(nearestEnemy.gameObject);
                    EnemyList.Remove(nearestEnemy);
                    Attackpressed = false;
            }


            //Wait for 2 seconds
             yield return new WaitForSeconds(1);

        }
    }
}

