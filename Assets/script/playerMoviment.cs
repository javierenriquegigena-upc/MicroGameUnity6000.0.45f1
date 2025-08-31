using UnityEngine;

public class playerMoviment : MonoBehaviour
{
    
    public float speed;
    private Rigidbody2D _rigidbody2D;
    public float _horizontalDirection;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        _horizontalDirection = Input.GetAxisRaw("Horizontal");

        //transform.position = new Vector2(transform.position.x + horizontalDirection * speed * Time.deltaTime, transform.position.y);
        _rigidbody2D.linearVelocityX = _horizontalDirection * speed;
    }

}