using UnityEngine;
using System.Collections.Generic;

public class AbstractItem : IBag, IHasWeight
{
    public float Weight { get; set; }

    public AbstractItem(float weight)
    {
        Weight = weight;
    }

    public void Add(AbstractItem item)
    {
        // Implementation for adding an item to the bag
    }

    public void Remove(AbstractItem item)
    {
        // Implementation for removing an item from the bag
    }

    public IEnumerator<AbstractItem> GetEnumerator()
    {
        // Implementation for getting an enumerator for the bag
        return null;
    }

    private IEnumerator<AbstractItem> GetEnumerator()
    {
        return null;
    }
}
