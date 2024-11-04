using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class CharController2 : MonoBehaviour
{
    private CharController2 _character;
    private Animator _animator;
    // Start is called before the first frame update
    void Start()
    {
        _character = GetComponent<CharController2>();
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");

        float vertical = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(horizontal, 0, vertical);


        if (dir != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(dir);

            _animator.SetBool("isRun", true);


            transform.Translate(Vector3.forward * 2 * Time.deltaTime);



        }else
        {
            _animator.SetBool("isRun", false);
        }

       

   

    }
}
