using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Assets;
using System.Xml.Serialization;
using System.IO;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class loadPoints : MonoBehaviour {
    public CorrespondenceAcquisition pointsHolder;

    // Use this for initialization
    void Start () {

       var recording = Recording.LoadFromFile(Application.dataPath + "/pointData/03.xml");
        pointsHolder.ReplayRecordedPoints(recording.worldPointsV3, recording.ImagePointsV3((double)Screen.width, (double)Screen.height));
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
