using UnityEngine;

public class FirstAidKit : Collectible
{
    [SerializeField] private int _recoveryHealth = 10;

    public override void Collect(ICollectble collector)
    {
        base.Collect(collector);
        collector.CollectFirstAidKit(_recoveryHealth);
    }
}