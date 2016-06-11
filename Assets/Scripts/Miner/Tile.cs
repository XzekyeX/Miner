using UnityEngine;
using System.Collections;
/**
 * @author Zekye
 *
 */
public class Tile
{
    public TileType type;
    private GameObject visual;
    public Tile(TileType type, float x, float y, float z)
    {
        this.type = type;
        visual = (GameObject)GameObject.Instantiate(type.visual, new Vector3(x, y, z), Quaternion.identity);
    }

}
