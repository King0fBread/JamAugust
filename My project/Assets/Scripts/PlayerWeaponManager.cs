using UnityEngine;

public class PlayerWeaponManager : MonoBehaviour
{
    private static PlayerWeaponManager _instance;
    public static PlayerWeaponManager instance { get { return _instance; } }
    private void Awake()
    {
        if(_instance != null && _instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            _instance = this;
        }
    }
    public void EquipWeapon(WeaponData weaponData)
    {
        //equip manager
        print("equipped: " + weaponData.name);
    }
}
