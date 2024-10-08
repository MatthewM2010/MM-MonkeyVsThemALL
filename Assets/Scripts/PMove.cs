using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PMove : MonoBehaviour
{
    public CharacterController controller;
    private Vector2 screenBounds;
    private float objectHeight;

    private Animator Anim;

    [Header("Death Screen")]
    public GameObject Smoke;
    public bool dead;

    [Header("Movement")]
    public float Speed;
    private Rigidbody rb;
    public float jumpforce = 5f;
    public float slamforce;
    public bool touchingGround;

    [Header("Health")]
    public int health = 5;
    public Text healthText;
    public bool invincible;
    public int IFrames;
    public Text iText;
    public GameObject iTextObj;

    // Start is called before the first frame update
    void Start()
    {
        Anim = GetComponent<Animator>();
        gameObject.SetActive(true);
        Smoke.SetActive(false);
        dead = false;
        invincible = true;
        IFrameCounter();
        health = 5;
        healthText.text = "Health: " + health.ToString();
        rb = GetComponent<Rigidbody>();
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        objectHeight = transform.GetComponent<MeshRenderer>().bounds.size.y / 2;
        Physics.gravity = new Vector3(0, -20, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            touchingGround = true;
        }
        if (collision.gameObject.tag == "Projectile")
        {
            if (invincible == false)
            {
                Respawn();
            }
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            touchingGround = false;
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Projectile")
        {
            if (invincible == false)
            {
                Respawn();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Projectile")
        {
            if (invincible == false)
            {
                Respawn();
            }
        }
        if (other.gameObject.tag == "Health")
        {
            health++;
            healthText.text = "Health: " + health.ToString();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Projectile")
        {
            if (invincible == false)
            {
                Respawn();
            }
        }
    }
    public void Update()
    {
        if (Input.GetKey("a") && !Input.GetKey("d"))
        {
            transform.rotation = Quaternion.Euler(0, -90, 0);
            transform.position += transform.TransformDirection(Vector3.forward) * Time.deltaTime * Speed;
            if (Anim != null && touchingGround == true)
            {
                Anim.Play("Walk");
            }
        }
        if (Input.GetKey("d") && !Input.GetKey("a"))
        {
            transform.rotation = Quaternion.Euler(0, 90, 0);
            transform.position += transform.TransformDirection(Vector3.forward) * Time.deltaTime * Speed;
            if (Anim != null && touchingGround == true)
            {
                Anim.Play("Walk");
            }
        }
        if (Input.GetKeyDown("space") && touchingGround == true || Input.GetKeyDown("w") && touchingGround == true)
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpforce, rb.velocity.z);
        }
        if (touchingGround == false)
        {
            if (Anim != null)
            {
                Anim.Play("Fly");
                Anim.Play("Shapekey.Eyes_Squint");
            }
        }
        else
        {
            if(Anim != null)
            {
                Anim.Play("Shapekey.Eyes_Blink");
            }
        }
        if (Anim != null && !Input.GetKeyDown("s") && !Input.GetKeyDown("a") && touchingGround == true && !touchingGround == false)
        {
           Anim.Play("Idle_A");
        }
        if (Input.GetKeyDown("s") && touchingGround == false)
        {
            rb.velocity = new Vector3(rb.velocity.x, -slamforce, rb.velocity.z);
        }
        if (transform.position.y < (screenBounds.y * -1 - objectHeight) - 10)
        {
            Respawn();
        }
        if (health >= 6)
        {
            health = 5;
            healthText.text = "Health: " + health.ToString();
        }
    }

    void Respawn()
    {
        health--;
        if (health <= 0)
        {
            gameObject.SetActive(false);
            Smoke.transform.position = gameObject.transform.position;
            Smoke.SetActive(true);
            dead = true;
            Invoke("Death", 7f);
        }
        transform.position = new Vector3(0, 10, 0);
        healthText.text = "Health: " + health.ToString();
        invincible = true;
        IFrameCounter();
    }
    void Death()
    {
        SceneManager.LoadScene(2);
    }
    public void IFrameCounter()
    {
        iTextObj.SetActive(true);
        IFrames = 2;
        iText.text = "Invincibility: " + IFrames.ToString();
        Invoke("IFrameDown", 1f);
    }

    public void IFrameDown()
    {
        IFrames--;
        if (IFrames <= 0)
        {
            iTextObj.SetActive(false);
            invincible = false;
        }
        else
        {
            iText.text = "Invincibility: " + IFrames.ToString();
            Invoke("IFrameDown", 1f);
        }
    }
}

