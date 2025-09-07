using UnityEngine;

public class WeaponPickup : MonoBehaviour
{
    [SerializeField] private WeaponData _currentWeaponData;
    [SerializeField] private GameObject _selectWeaponPrompt;
    [SerializeField] private Sprite _emptyBoxSprite;

    private bool _canPickupWeapon;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<PlayerMovement>())
        {
            ToggleCanPickup(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayerMovement>())
        {
            ToggleCanPickup(false);
        }
    }
    private void TryPickUpWeapon()
    {
        if(_canPickupWeapon)
        {
            PlayerWeaponManager.instance.EquipWeapon(_currentWeaponData);
            gameObject.GetComponent<SpriteRenderer>().sprite = _emptyBoxSprite;

            ToggleCanPickup(false);
        }
    }
    private void ToggleCanPickup(bool state)
    {
        if (state)
        {
            _selectWeaponPrompt.SetActive(true);
            _canPickupWeapon = true;
        }
        else
        {
            _selectWeaponPrompt.SetActive(false);
            _canPickupWeapon = false;
        }
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && _canPickupWeapon)
        {
            TryPickUpWeapon();
        }
    }
}
