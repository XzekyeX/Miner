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
    public int area;
    Tile[,,] tiles;
    // Use this for initialization
    void Start()
    {
        tiles = new Tile[width, height, depth];
        int hw = (width / 2);
        int hd = (depth / 2);
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                for (int z = 0; z < depth; z++)
                {
                    if (!(x >= (hw - 1 - area) && x <= (hw + area) && z >= (hd - 1 - area) && z <= (hd + area)))
                    {
                        tiles[x, y, z] = new Tile(x, y, z);
                    }
                }
            }
        }
        GameObject gp = GameObject.Find("Player");
        if (gp != null)
        {
            Player p = gp.GetComponent<Player>();
            if (p != null)
            {
                p.x = hw;
                p.z = hd;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
