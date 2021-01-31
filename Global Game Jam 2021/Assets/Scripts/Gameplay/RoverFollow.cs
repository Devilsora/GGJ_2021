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

  SpriteRenderer renderer;
  bool movingLeft = false;

  public void Start()
  {
    renderer = GetComponent<SpriteRenderer>();
  }

  public void Update()
  {

    if(movingLeft)
    {
      renderer.flipX = false;
    }
    else
    {
      renderer.flipX = true;
    }

    // How far away are we from the Target
    float dist = (FollowTarget.position - transform.position).sqrMagnitude;

    float lastX = transform.position.x;
    // Is the distance larger than our Max Distance?
    if (dist > (MaxDistance * MaxDistance))
    {
      //If so, Start to Follow the target
      transform.position = Vector3.Lerp(transform.position, FollowTarget.position, MoveSpeed * Time.deltaTime);
      if (lastX > transform.position.x)
        movingLeft = false;
      else
        movingLeft = true;
    }
  }
}
