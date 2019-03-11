using System.Linq;
using UnityEngine;

public class getVertices : MonoBehaviour {
    GameObject cube;
    MeshFilter mf;

    public GameObject prefab;
    Vector3[] uniqueVertices;

    // Use this for initialization
    void Start()
    {

        cube = GameObject.Find("myCube");
        mf = cube.GetComponent<MeshFilter>();
        uniqueVertices = mf.mesh.vertices.Distinct().ToArray();
        Debug.Log(uniqueVertices.Length);
        for (int i = 0; i < uniqueVertices.Length; i++)
        {
            Instantiate(prefab, uniqueVertices[i], Quaternion.identity);
            //Quaternion.identity
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
