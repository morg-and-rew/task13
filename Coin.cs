using UnityEngine;

public class Coin : Collectible
{
    [SerializeField] private int _coinValue = 10;

    public override void Collect(ICollectble collector)
    {
        base.Collect(collector);
        collector.CollectCoin(_coinValue);
    }
}