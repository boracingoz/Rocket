using Input;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _force;
    private Rigidbody _rigidbody;
    private DefaultInput _input;

    private bool _isForceUp;

    // Start is called before the first frame update
    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _input = new DefaultInput();
    }

    // Update is called once per frame
    void Update()
    {
        if (_input.IsForceUp)
        {
            _isForceUp = true;
        }
        else
        {
            _isForceUp = false;
        }
    }

    private void FixedUpdate() //Fizik işlemleri için
    {
        if (_isForceUp)
        {
            _rigidbody.AddForce(Vector3.up * Time.deltaTime * _force);
        }
    }
}
