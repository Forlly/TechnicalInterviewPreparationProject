using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMembership
{
    public string Name { get; }
    public string Description { get; set; }

    public float GetPrice();
}
