using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public Text Counter;
  
    public Vector3 jump;
    public float jumpForce = 2.0f;
    public bool isGrounded;

    private Rigidbody rb;
    public int count;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
        count = 0;
        SetCounter();
    }

    void OnCollisionStay()
    {
        isGrounded = true;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {

            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
        LevelLoader();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Box"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCounter();
        }
    }

    void SetCounter()
    {
        Counter.text = "Cubes: " + count.ToString();
    }
    void LevelLoader()
    {
        if (count >= 10)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        if (SceneManager.GetActiveScene().name == "Level_Four" && count >= 10)
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
