using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody _rb;
    [SerializeField] private LayerMask _layerMask;

    [SerializeField] private float _movemenetSpeed;
    [SerializeField] private float _jumpForce;

    private PlayerInputActions _playeInputActions;
    private Vector2 _horizontal;
    private bool _isFacingRight = true;
    private bool _isGrounded = true;


    private void Awake() => _playeInputActions = new PlayerInputActions();

    private void Update()
    {
        if ((!_isFacingRight && _horizontal.x > 0f) || (_isFacingRight && _horizontal.x < 0f))
            Flip();
    }

    private void FixedUpdate() => Move();

    public void GetHorizontalAxis(InputAction.CallbackContext context) => _horizontal = context.ReadValue<Vector2>();

    public void Jump(InputAction.CallbackContext context)
    {
        _isGrounded = Physics.Raycast(transform.position, Vector3.down, 1f, _layerMask);

        if (context.performed && _isGrounded)
            _rb.AddForce(0, _jumpForce, 0, ForceMode.Impulse);
    }

    private void Move() => _rb.velocity = new Vector3(_horizontal.x * _movemenetSpeed, _rb.velocity.y, _rb.velocity.z);

    private void Flip()
    {
        _isFacingRight = !_isFacingRight;
        Vector3 localScale = transform.localScale;
        localScale.x *= -1f;
        transform.localScale = localScale;
    }

    private void OnEnable() => _playeInputActions.Enable();

    private void OnDisable() => _playeInputActions.Disable();
}