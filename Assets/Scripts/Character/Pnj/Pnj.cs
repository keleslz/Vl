using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Pnj : MonoBehaviour
{
    private Transform[] points;

    private int targetIndex = 0; 

    private float speed = 2f;

    private static int maxPointsCount = 10;

    public string name = "Andy";

    void Start()
    {
        DefinePoints();
    }

    void Update()
    {
        Vector3 dir = points[targetIndex].position - transform.position;

        if(Vector3.Distance(transform.position, points[targetIndex].position) <= 0.2f)
        {
            DefinePoints();
            GetNextPoint();
        }

        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);
    }

    private void DefinePoints()
    {
        points = new Transform[maxPointsCount];

        var rand = new System.Random();

        for (int i = 0; i < maxPointsCount; i++)
        {
            int randomIndex = rand.Next(0, MovePoints.points.Length);
            points[i] = MovePoints.points[randomIndex];  
        }
    }

    private void GetNextPoint()
    {
        if(targetIndex == (maxPointsCount - 1))
        {
            targetIndex = 0;
            return;
        }
        targetIndex++;
    }
}
