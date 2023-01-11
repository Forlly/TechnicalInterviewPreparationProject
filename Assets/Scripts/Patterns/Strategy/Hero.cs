using UnityEngine;

public class Hero
{
    private string _name;
    private IWeapon _weapon;

    public Hero(string name)
    {
        _name = name;
    }

    public void SetWeapon(IWeapon weapon)
    {
        _weapon = weapon; 
    }

    public void Attack()
    {
        Debug.Log("Attack");
        if (_weapon is null)
        {
            Debug.Log($"{_name} can't attack. Set weapon");
            return;
        }
        
        Debug.Log($"{_name} start attack");
        _weapon.Shoot();
    }
}
