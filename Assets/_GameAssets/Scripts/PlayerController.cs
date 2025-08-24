using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] private Transform _orientationTransform;
    private Rigidbody _playerRigidbody;
    private float _horizontalInput, _verticalInput;
    private Vector3 _movementDirection;

    private void Awake()
    {
        _playerRigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        SetInputs();
    }

    private void FixedUpdate()
    {
        SetPlayerMovement();
    }

    private void SetInputs()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        _verticalInput = Input.GetAxis("Vertical");
    }

    private void SetPlayerMovement()
    {
        _movementDirection = _orientationTransform.forward * _verticalInput +
                        _orientationTransform.right * _horizontalInput;

        _playerRigidbody.AddForce(_movementDirection * 10f, ForceMode.Force);                     
        
    }
}
