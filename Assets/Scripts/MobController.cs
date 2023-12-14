using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobController : MonoBehaviour
{
    private Animator _animator;
    private float moveSpeed = 1f;

    void Start()
    {
        _animator = GetComponent<Animator>();
        Destroy(gameObject, 15f);
    }

    void Update()
    {
        transform.Translate(-transform.forward * moveSpeed * Time.deltaTime);
        _animator.SetBool("isMoving", true);
    }
    
}
