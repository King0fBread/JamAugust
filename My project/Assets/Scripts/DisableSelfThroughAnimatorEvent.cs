using UnityEngine;

public class DisableSelfThroughAnimatorEvent : MonoBehaviour
{
    public void DisableSelfOnAnimationEvent()
    {
        gameObject.SetActive(false);
    }
}
