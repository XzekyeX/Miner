using UnityEngine;
using System.Collections;
/**
 * @author Zekye
 *
 */
public class Tile : MonoBehaviour
{
    private GameObject cube;
    public Tile(float x, float y, float z)
    {
        cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = new Vector3(x, y, z);
        cube.transform.localScale = new Vector3(1, 1, 1);
        cube.name = "Tile[" + x + "," + y + "," + z + "]";
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
