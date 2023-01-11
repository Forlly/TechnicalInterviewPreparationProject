using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Program : MonoBehaviour
{

    [SerializeField] private TMP_InputField _membershipIF;
    [SerializeField] private Button _createMembership;

    public void Start()
    {
        Debug.Log(" Factory Method example");
        _createMembership.onClick.AddListener(EnterParameters);

    }

    public void EnterParameters()
    {
        string membershipType = _membershipIF.text;

        MembershipFactory factory = GetFactory(membershipType);
        if (factory == null) return;
        
        IMembership membership = factory.GetMembership();
        
        Debug.Log("Membership you have created:");
        Debug.Log(membership.Name + membership.Description + membership.GetPrice());
    }

    private MembershipFactory GetFactory(string membershipType) =>
        membershipType.ToLower() switch
        {
            "g" => new GymMembershipFactory(100, "Base membreship"),
            "p" => new GymPlusPoolMembershipFactory(250, "Good price"),
            "t" => new PersonalTrainingMembershipFactory(500, "For professionals"),
            _ => null
        };

}
