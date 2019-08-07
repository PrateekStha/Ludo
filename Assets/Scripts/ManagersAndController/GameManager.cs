using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   public static GameManager gm;

    public int numberOfStepsToMove;

   private void Awake() {
       gm = this;
   }
}
