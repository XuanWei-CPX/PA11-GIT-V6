using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float speed;
    public int score;
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        float verticalInput = Input.GetAxis("Vertical");

        transform.position = transform.position + new Vector3(0 , verticalInput * speed * Time.deltaTime, 0);

        scoreText.text = "Score : " + score;

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Obstacle"))
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Score"))
        {
            score += 1;
        }
    }
}
