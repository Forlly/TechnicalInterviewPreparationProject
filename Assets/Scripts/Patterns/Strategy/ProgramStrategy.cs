using UnityEngine;

public class ProgramStrategy : MonoBehaviour
{
    private Hero _hero;
    private void Start()
    {
        _hero = new Hero("Seraphina");
        _hero.Attack();
        _hero.SetWeapon(new Gun());
        _hero.Attack();
    }
}
