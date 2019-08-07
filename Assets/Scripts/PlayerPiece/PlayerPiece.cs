using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPiece : MonoBehaviour
{
    public bool canMove;  
    public bool moveNow;//all script accessible ko laagi move garna
    public int numberOfStepsAlreadyMoved = 0;
    
    Coroutine moveSteps_Coroutine;
    public PathObjectParent pathsParent;
    private void Awake() {
        pathsParent = FindObjectOfType<PathObjectParent>();
    }

    public void MoveSteps(){
        moveSteps_Coroutine = StartCoroutine(MoveSteps_Enum());
    }
    IEnumerator MoveSteps_Enum(){
        
        int numberOfStepsToMove = GameManager.gm.numberOfStepsToMove;
        
        if(canMove)
        {
            for(int i =numberOfStepsAlreadyMoved; i<(numberOfStepsAlreadyMoved+numberOfStepsToMove) ; i++)
            {
                transform.position = pathsParent.commonPathPoints[i].transform.position;
                yield return new WaitForSeconds(0.5f);
            }
        }
        numberOfStepsAlreadyMoved += numberOfStepsToMove;
        if(moveSteps_Coroutine != null)
        {
            StopCoroutine(moveSteps_Coroutine);
        }
    }
}
