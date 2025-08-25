using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 5f;

    private Rigidbody2D _rigidbody;
    private Vector2 _movementVector;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        if (moveX != 0)
        {
            _movementVector = new Vector2(moveX, 0);
        }
        else if (moveY != 0)
        {
            _movementVector = new Vector2(0, moveY);
        }
        else
        {
            _movementVector = Vector2.zero;
        }
    }

    void FixedUpdate()
    {
        _rigidbody.linearVelocity = _movementVector.normalized * _moveSpeed;
    }
}
