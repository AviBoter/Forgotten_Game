using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Tilemaps;
using static System.Collections.Generic.Dictionary<UnityEngine.Vector3, UnityEngine.Vector3>;

/**
 * This component allows the player to move by clicking the arrow keys,
 * but only if the new position is on an allowed tile.
 * and allow him to go throw not allowed tile by clicking space while walking thourght them
 */
public class KeyboardMoverByTile : KeyboardMover
{
    [SerializeField] Tilemap tilemap = null;
    [SerializeField] AllowedTiles allowedTiles = null;
    [SerializeField] TileBase newTile = null;
    [SerializeField] TileBase oldTile = null;
    [SerializeField] TileBase PlayerHome = null;

    private TileBase TileOnPosition(Vector3 worldPosition)
    {
        Vector3Int cellPosition = tilemap.WorldToCell(worldPosition);
        return tilemap.GetTile(cellPosition);
    }

    void Update()
    {
        Vector3 newPosition = NewPosition();
        TileBase tileOnNewPosition = TileOnPosition(newPosition);

        if (allowedTiles.Contain(tileOnNewPosition))
        {
            transform.position = newPosition;
        }
        else if (!allowedTiles.Contain(tileOnNewPosition) && tileOnNewPosition.Equals(oldTile) && Input.GetKey(KeyCode.Space))
        {
            tilemap.SetTile(tilemap.WorldToCell(newPosition), newTile);
        }
        else if (tileOnNewPosition.Equals(PlayerHome) && Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Home Sweet Home " + tileOnNewPosition + "!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }
        else
        {
            Debug.Log("You cannot walk on " + tileOnNewPosition + "!");
        }
    }
}