using UnityEngine;

public class BiscuitGainableObject : MonoBehaviour
{
    [SerializeField] private int _amountToGain;
    [SerializeField] private bool _isPositive;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayerMovement>())
        {
            BiscuitManager.instance.ChangeBiscuitsAmount(_amountToGain, _isPositive);

            gameObject.SetActive(false);
        }
    }

}
