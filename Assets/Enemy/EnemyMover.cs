using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
  [SerializeField] List<WayPoint> path = new List<WayPoint>();
  [SerializeField] [Range(0f, 5f)] float SpeedTime = 1f;
  void Start()
  {

    StartCoroutine(FollowPath());

  }

  /*
    LOGIC!!!!!
    We're going to start our routine, which starts our for loop.
    We're going to set up the start and end position we want to move to.
    And then while our travel percent is less than one, so while we're not at our end position, this is
    really saying we're going to update the travel percent with the Times, Delta time and then move the
    position of our enemy.
    We're then going to yield back to the update function until the end of the frame has been completed
    and then we'll jump back to our routine, which will continue our while loop and go through our lines
    here.
    And this will carry on until our travel percent is greater than one, at which point our wall loop will
    be broken out of, and then we'll go onto the next waypoint in our path.
    That whole system will continue to loop until we've run out of waypoints to visit.
  */

  IEnumerator FollowPath()
  {
    foreach (WayPoint waypoint in path)
    {
      Vector3 startPosition = transform.position;
      Vector3 endPosition = waypoint.transform.position;
      float travelPercent = 0f;

      transform.LookAt(endPosition);

      while (travelPercent < 1f)
      {
        travelPercent += Time.deltaTime * SpeedTime;
        transform.position = Vector3.Lerp(startPosition, endPosition, travelPercent);
        yield return new WaitForEndOfFrame();
      }
    }
  }

}
