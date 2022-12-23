using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTo : MonoBehaviour
{
    private Transform ThisTransform = null;
    public float RotSpeed = 90f;

    public Transform Target = null;

    private void Awake()
    {
        ThisTransform = GetComponent<Transform>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //ThisTransform.rotation *= Quaternion.AngleAxis(RotSpeed * Time.deltaTime, Vector3.up);
        
        Quaternion DestRot = Quaternion.LookRotation(Target.position - ThisTransform.position, Vector3.up);

        ThisTransform.rotation = Quaternion.RotateTowards(ThisTransform.rotation, DestRot, RotSpeed * Time.deltaTime);
    }
}
