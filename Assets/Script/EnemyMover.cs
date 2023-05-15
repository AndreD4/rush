using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] List<WayPoint> path = new List<WayPoint>();
    void Start()
    {
      Debug.Log("start here");
       StartCoroutine(FollowPath());
      Debug.Log("finishing start");
    }

    /*

    */

    IEnumerator FollowPath()
    {
      foreach(WayPoint waypoint in path)
      {
        Debug.Log(waypoint.name);
        yield return new WaitForSeconds(1);
      }
    }

}
