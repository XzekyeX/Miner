﻿using UnityEngine;
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
    public TileType[] types;
    public Tile[,,] tiles;
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
                    if (!(x >= (hw - 1 - area) && x <= (hw + area) && z >= (hd - 1 - area) && z <= (hd + area) && (y >= 1 && y <= height)))
                    {
                        int i = (int)Random.Range(0, types.Length);
                        tiles[x, y, z] = new Tile(types[y > 0 ? i : 0], x, y, z);
                    }
                }
            }
        }
        GameObject gp = GameObject.Find("Player");
        if (gp != null)
        {
            gp.transform.position = new Vector3(hw, 1, hd);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
