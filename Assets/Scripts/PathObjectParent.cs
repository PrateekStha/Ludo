using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathObjectParent : MonoBehaviour
{
   //Serialise means like a private but can be seen in inspect bro😝
//    [SerializeField] Transform[] commonPathPoints;
//    [SerializeField] Transform[] redPathPoints;
//    [SerializeField] Transform[] bluePathPoints;
//    [SerializeField] Transform[] yellowPathPoints;
//so we used public for connection 
   public PathPoint[] commonPathPoints;
   public PathPoint[] redPathPoints;
   public PathPoint[] greenPathPoints;
   public PathPoint[] yellowPathPoints;
   public PathPoint[] bluePathPoints;
}
