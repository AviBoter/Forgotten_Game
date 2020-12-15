using UnityEngine;
using UnityEngine.SceneManagement;

/**
 * This component chases a given target object.
 */
public class Chaser: TargetMover {
    [Tooltip("The object that we try to chase")]
    [SerializeField] Transform targetObject = null;

    [Tooltip("attack radius")]
    [SerializeField]
    private float radius = 1f;

    public Vector3 TargetObjectPosition() {
        return targetObject.position;
    }

    private void Update() {
        SetTarget(targetObject.position);

        if (targetObject != null && Vector2.Distance(transform.position, targetObject.position) <= radius)
        {
            //Destroy(targetObject.gameObject);
            //restart lvl

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }

    }
}
