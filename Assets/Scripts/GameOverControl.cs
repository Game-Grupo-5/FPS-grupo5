using JetBrains.Annotations;
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


    private void Update()
    {
        if (Input.GetKeyDown (KeyCode.Return))
        {
            SceneManager.LoadScene(0);
        }
    }
}
