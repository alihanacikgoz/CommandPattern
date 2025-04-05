using UnityEngine;

namespace Runtime.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        private Animator _anim;
        [SerializeField] private float _speed = 2.0f;
        [SerializeField] private float _rotationSpeed = 100.0f;
    
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            _anim = this.GetComponent<Animator>();
        }

        // Update is called once per frame
        void LateUpdate()
        {
            float translation = Input.GetAxis("Vertical") * _speed;
            float rotation = Input.GetAxis("Horizontal") * _rotationSpeed;
        
            translation *= Time.deltaTime;
            rotation *= Time.deltaTime;

            // Hareket
            Vector3 move = transform.forward * translation * _speed * Time.deltaTime;
            transform.Translate(move, Space.World);

            // Dönüş
            transform.Rotate(0, rotation * _rotationSpeed * Time.deltaTime, 0);
        
            bool isMoving = Mathf.Abs(translation) > 0.01f || Mathf.Abs(rotation) > 0.01f;
            _anim.SetBool("isWalking", isMoving);

            if (Input.GetKeyDown(KeyCode.Space))
                _anim.SetTrigger("isJumping");
            if (Input.GetKeyDown(KeyCode.E))
                _anim.SetTrigger("isPunching");
            if (Input.GetKeyDown(KeyCode.R))
                _anim.SetTrigger("isKicking");
        }
    }
}
