using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class collect : MonoBehaviour
{
   private int apples = 0;

   [SerializeField] private Text applesText;

   private void OnTriggerEnter2D(Collider2D collision){
    if(collision.gameObject.CompareTag("Pump")) {
        Destroy(collision.gameObject);
        apples++;
        applesText.text = "x " + apples;
    }
   }
}
