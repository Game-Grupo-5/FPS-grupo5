using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverControl : MonoBehaviour
{
    [Header("Pontos Player")]
    [SerializeField] int pontosPlayer;
    [SerializeField] TextMeshProUGUI textPontos;

    [SerializeField] private PlayerMovement player;
    [SerializeField] private bool playerIsDead;


    void Start()
    {
        
    }

    void Update()
    {
        //player.pontos = pontosPlayer;
        GuardarValores();

        if (Input.GetKeyDown(KeyCode.Space) && playerIsDead == true)
        {
           
            DontDestroyOnLoad(gameObject);
            SceneManager.LoadScene(0);
        }
        print(pontosPlayer);
        textPontos.text = pontosPlayer.ToString();

    }

    void GuardarValores()
    {
        pontosPlayer = player.pontos;
    }
}
