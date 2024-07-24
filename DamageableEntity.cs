using UnityEngine;

public class DamageableEntity : MonoBehaviour, ITakingDamage
{
    [SerializeField] protected float _health = 100f;

    public virtual void TakeDamage(int damage)
    {
        if (damage > 0)
        {
            _health -= damage;
        }
    }
}