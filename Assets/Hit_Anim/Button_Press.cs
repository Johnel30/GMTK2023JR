using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Press : MonoBehaviour
{
    public bool canContinue;
    private float delayTime =1f;

    public void OnButtonPress()
{
    StartCoroutine(OnButtonPressCoroutine());
}
   public IEnumerator OnButtonPressCoroutine()
   {

      canContinue = true;
      yield return new WaitForSeconds(delayTime);
      canContinue = false;
      

   }
}
