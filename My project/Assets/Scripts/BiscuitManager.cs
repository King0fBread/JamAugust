using TMPro;
using UnityEngine;

public class BiscuitManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _biscuitsCounter;
    [SerializeField] private TextMeshProUGUI _notificationText;

    private int _biscuitsAmount;

    public static BiscuitManager instance { get { return _instance; } }
    private static BiscuitManager _instance;

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

        _biscuitsAmount = 0;
    }

    public void ChangeBiscuitsAmount(int amount, bool isAdding)
    {
        if (isAdding)
        {
            _biscuitsAmount += amount;

            _notificationText.text = "+";
        }
        else
        {
            _biscuitsAmount -= amount;

            _notificationText.text = "-";
        }

        _notificationText.text += amount;

        DisplayUpdatedBiscuits();
    }
    private void DisplayUpdatedBiscuits()
    {
        _biscuitsCounter.text = _biscuitsAmount.ToString();
        _notificationText.gameObject.SetActive(true);
    }

}
