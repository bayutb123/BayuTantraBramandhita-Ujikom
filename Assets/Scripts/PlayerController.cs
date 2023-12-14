using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator _animator;
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            _animator.SetBool("isMovingLeft", true);
            transform.Translate(-transform.right * 5f * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            _animator.SetBool("isMovingRight", true);
            transform.Translate(transform.right * 5f * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            
        }
    }
}
