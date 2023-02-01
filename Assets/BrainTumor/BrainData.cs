using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BrainData
{
    public string dataIndex; // ex: 007
    public string dataType; //val or train
    public int tumorNum; // 1 or 2
    public Vector3 boxCenter;
    public Vector3 boxDimension;
    public Vector3 boxCenter2;
    public Vector3 boxDimension2;
}