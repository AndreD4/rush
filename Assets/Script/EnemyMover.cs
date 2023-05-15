using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] List<WayPoint> path = new List<WayPoint>();
    void Start()
    {
        PrintWayPointName();
        InvokeRepeating("PrintWayPointName", 0, 1f);

    }

    void PrintWayPointName()
    {
      foreach(WayPoint waypoint in path)
      {
        Debug.Log(waypoint.name);
      }
    }

}
