using UnityEngine;

public class Player : MonoBehaviour, ICollectble
{
    [SerializeField] private float _health = 100f;
    [SerializeField] private float _wallet = 0f;

    public void CollectCoin(int coin)
    {
        if (coin > 0)
            _wallet += coin;
    }

    public void CollectFirstAidKit(int recoveryHealth)
    {
        if (recoveryHealth > 0)
            _health += recoveryHealth;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Collectible collectible))
        {
            collectible.Collect(this);
        }
    }
}