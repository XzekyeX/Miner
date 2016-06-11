using UnityEngine;
using System.Collections;
/**
 * @author Zekye
 *
 */
public class World : MonoBehaviour
{
    public int width;
    public int height;
    public int depth;
    Tile[,,] tiles;
    // Use this for initialization
    void Start()
    {
        tiles = new Tile[width, height, depth];
        int a = 2;
        int hw = (width / 2);
        int hd = (depth / 2);
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                for (int z = 0; z < depth; z++)
                {
                    if (!(x >= (hw - 1 - a) && x <= (hw + a) && z >= (hd - 1 - a) && z <= (hd + a)))
                    {
                        tiles[x, y, z] = new Tile(x, y, z);
                    }
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
