using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingDice : MonoBehaviour
{
  [SerializeField] int numberGot;
  [SerializeField] GameObject rollingDiceAnim;
  [SerializeField] SpriteRenderer numberedSpritesHolder;
  [SerializeField] Sprite[] numberedSprites;
    Coroutine generateRandomNumberOnDice_Couritine;
    
    bool canDiceRoll=true;
    private void OnMouseDown() 
    {
            generateRandomNumberOnDice_Couritine = StartCoroutine(GenerateRandomNumberOnDice_Enum());
         
    }

    IEnumerator GenerateRandomNumberOnDice_Enum()
    {
        yield return new WaitForEndOfFrame();
        if(canDiceRoll){
            canDiceRoll = false;
        numberedSpritesHolder.gameObject.SetActive(false);
        rollingDiceAnim.SetActive(true);
        yield return new WaitForSeconds(1f);
               numberGot = Random.Range(0,6);
             numberedSpritesHolder.sprite = numberedSprites[numberGot];
        numberGot +=1;

        GameManager.gm.numberOfStepsToMove = numberGot;
        numberedSpritesHolder.gameObject.SetActive(true);
        rollingDiceAnim.SetActive(false);
        yield return new WaitForEndOfFrame();
        canDiceRoll = true;
        if(generateRandomNumberOnDice_Couritine != null)
        {
            StopCoroutine(generateRandomNumberOnDice_Couritine);
        }
        }
    }

}