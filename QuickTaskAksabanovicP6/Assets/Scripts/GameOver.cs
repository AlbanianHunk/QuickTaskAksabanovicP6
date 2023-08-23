using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOverManager : MonoBehaviour
{
    public TextMeshProUGUI gameOverText;

    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        
            gameOverText.gameObject.SetActive(true);
            
        
    }
}