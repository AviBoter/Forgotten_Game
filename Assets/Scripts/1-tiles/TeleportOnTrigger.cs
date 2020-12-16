using System.Collections;
using System.Collections.Generic;
using UnityEngine;



/**
 * This component Teleport its object whenever it triggers a 2D collider to given location
 * using tag.
 */
public class TeleportOnTrigger : MonoBehaviour
{
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;

    [Tooltip("Destnation object")]
    [SerializeField] Transform TeleportToObject;

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == triggeringTag && TeleportToObject != null)
        {
            other.transform.position = TeleportToObject.position;
        }
    }
}
