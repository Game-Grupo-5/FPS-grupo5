using UnityEngine;

public class AttackEnemy : MonoBehaviour
{
    [Header("Timer Projetil")]
    private float projectTimer;


    public int damage;

    private void Start()
    {

    }

    private void FixedUpdate()
    {

    }


    private void OnCollisionEnter(Collision collision)
    {
        PlayerMovement player = collision.gameObject.GetComponent<PlayerMovement>();

        if (player) player.TakeDamage(damage);

        

        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Grounded"))
        {
            Destroy(gameObject);


        };
    }
}
