using UnityEngine;

public class AttackPlayer : MonoBehaviour
{
    public int damage;
    [SerializeField] float disableAttack = 1.5f;

    private void OnCollisionEnter(Collision collision)
    {
        EnemyController enemy = collision.gameObject.GetComponent<EnemyController>();

        if (enemy)
        {
            enemy.TakeDamage(damage);
        }

        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("Grounded"))
        {
            Invoke("DestroyAttack", disableAttack);
        }
    }

    void DestroyAttack()
    {
        Destroy(gameObject);
    }
}
