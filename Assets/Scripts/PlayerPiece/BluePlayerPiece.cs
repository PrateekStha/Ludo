using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BluePlayerPiece : PlayerPiece
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnMouseDown()
    {
    //   Debug.Log(this.gameObject.name);  
      canMove = true;
      MoveSteps();
        // StartCoroutine("MoveStepsEnum");
    }
    //to move in common paths we take public for data
    // public void MoveSteps()
    // {
    //     for(int i= 0;i<3;i++)
    //     {
    //         transform.position = pathsParent.commonPathPoints[i].transform.position;
    //     }
    // }

    
}
