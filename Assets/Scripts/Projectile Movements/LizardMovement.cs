using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LizardMovement : MonoBehaviour
{
    private Animator Anim;
    public float xForce;
    public float yForce;
    public float xDirection;
    public Rigidbody enemyRigidBody;
    // Start is called before the first frame update
    void Start()
    {
        enemyRigidBody = GetComponent<Rigidbody>();
        Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if( Anim != null)
        {
            Anim.Play("Eat");
            Anim.Play("Shapekey.Eyes_Spin");
        }
        if (transform.position.x <= -15)
        {
            xDirection = 1;
        }
        if (transform.position.x >= 15)
        {
            xDirection = -1;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Platform" || collision.gameObject.tag == "Ball")
        {
            Vector3 jumpForce = new Vector3(xForce * xDirection, yForce, 0);
            enemyRigidBody.AddForce(jumpForce);
        }
    }
}
