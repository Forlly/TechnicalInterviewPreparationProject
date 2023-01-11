using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GymPlusPoolMembership : IMembership
{
    private readonly string _name;
    private readonly float _price;

    public GymPlusPoolMembership(float price)
    {
        _name = "Gym + Pool membership";
        _price = price;
    }

    public string Name => _name;
    public string Description { get; set; }

    public float GetPrice() => _price;
}
