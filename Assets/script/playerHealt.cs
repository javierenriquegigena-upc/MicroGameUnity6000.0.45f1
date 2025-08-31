using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerHealt : MonoBehaviour
{
    public int lives;
    public TextMeshProUGUI vidasText;

    private void Start()
    {
        vidasText.text = lives.ToString();
    }
    private void Update() //hacer daño al jugador presionando L
    {
        
         if (lives <= 0 || Input.GetKeyDown(KeyCode.R))
         {
             SceneManager.LoadScene("SampleScene");
         }

    }

    //hacer daño al jugador
    public void DamagePlayer(int danio)
    {
        lives = lives - danio;
        //Debug.Log("vidas = " + lives);

        if (lives >= 0)
        {
            vidasText.text = lives.ToString();
        }
        else
        {
            vidasText.text = "0";
        }
    }



}
