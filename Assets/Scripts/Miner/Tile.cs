using UnityEngine;
using System.Collections;
/**
 * @author Zekye
 *
 */
public class Tile
{
    private GameObject cube;
    public Tile(float x, float y, float z)
    {
        cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = new Vector3(x, y, z);
        cube.transform.localScale = new Vector3(1, 1, 1);
        cube.name = "Tile[" + x + "," + y + "," + z + "]";
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseUp()
    {
        Debug.Log("Click");
    }
    
}
