using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 3.5f;
    private Rigidbody rigidbody;
    public float vert, hor;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        vert = Input.GetAxis("Vertical");
        hor = Input.GetAxis("Horizontal");

        Vector3 moveDir = vert * transform.forward + hor * transform.right;

        rigidbody.MovePosition(transform.position + moveDir.normalized * Time.deltaTime * moveSpeed);
    }
}
