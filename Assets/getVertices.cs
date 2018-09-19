using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class getVertices : MonoBehaviour {
    public GameObject mycube;
    //Matrix 4x4 localToWorld = transform.localToWorldMatrix;
    // Use this for initialization
    void Start()
    {
        Mesh mf = mycube.GetComponent<MeshFilter>().mesh;

        Vector3[] vertices = mf.vertices.Distinct().ToArray();
        int p = 0;

        Debug.Log(vertices.Length);
        while (p < vertices.Length) { 

            Debug.Log(transform.TransformPoint(vertices[p]));
            p++;
    }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
