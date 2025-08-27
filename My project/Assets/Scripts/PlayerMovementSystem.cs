using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 5f;

    private Animator _playerAnimator;

    private Rigidbody2D _rigidbody;
    private Vector2 _movementVector;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _playerAnimator = GetComponent<Animator>();
    }

    private void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        _movementVector = new Vector2(moveX, moveY).normalized;

        if (moveX != 0 || moveY != 0)
        {
            _playerAnimator.CrossFade("PlayerShakeMovement", 0, 0);
        }
        else
        {
            _movementVector = Vector2.zero;
            _playerAnimator.CrossFade("PlayerShakeIdle", 0, 0);
        }

        //RotatePlayerSprite(moveX, moveY);
    }

    private void FixedUpdate()
    {
        _rigidbody.linearVelocity = _movementVector * _moveSpeed;
    }
    //public void RotatePlayerSprite(float vectorX, float vectorY)
    //{
    //    if(vectorX < 0 || vectorY < 0)
    //    {
    //        gameObject.transform.localScale = new Vector2(-1, 1);
    //    }
    //    else
    //    {
    //        gameObject.transform.localScale = new Vector2(1, 1);
    //    }
    //}
}
