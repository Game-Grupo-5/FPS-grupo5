using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private float timer;
    private float GameOverTimer;
    private float minutos;
    private float segundos;
    [SerializeField] private TextMeshProUGUI timerText;

    [SerializeField] private PlayerMovement player;
    [SerializeField] private bool playerIsDead;
    void Start()
    {

    }


    void Update()
    {
        if (playerIsDead == false)
        {

            timer += Time.deltaTime;
            minutos = Mathf.FloorToInt(timer / 60);
            segundos = Mathf.FloorToInt(timer - minutos * 60);


        }
        timerText.text = string.Format("{0:00}:{1:00}", minutos, segundos);

     
     
    }
    
}
