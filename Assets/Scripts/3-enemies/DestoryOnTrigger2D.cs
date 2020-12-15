using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/**
 * This component destroys its object whenever it triggers a 2D collider with the given tag.
 */
public class DestoryOnTrigger2D : MonoBehaviour
{
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (this.tag == "Player" && other.tag != "FireBall") {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        else if (other.tag == triggeringTag && enabled)
        {
            Destroy(this.gameObject);
            Destroy(other.gameObject);
        }
    }
}
