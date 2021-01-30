using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoverFollow : MonoBehaviour
{

  // Object You want to Follow
  public Transform FollowTarget;
  // The Max Distance (in Unity units)
  // this Object must be from the Target
  public float MaxDistance;
  // How fast you want to Follow the Target
  public float MoveSpeed;

  public void Update()
  {
    // How far away are we from the Target
    float dist = (FollowTarget.position - transform.position).sqrMagnitude;
    // Is the distance larger than our Max Distance?
    if (dist > (MaxDistance * MaxDistance))
    {
      //If so, Start to Follow the target
      transform.position = Vector3.Lerp(transform.position, FollowTarget.position, MoveSpeed * Time.deltaTime);
    }
  }
}
