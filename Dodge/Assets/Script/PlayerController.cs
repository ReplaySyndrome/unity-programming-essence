using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRigidbody;
    public float speed = 8.0f;




    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //수평축과 수직축의 입력값을 감지하여 저장
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        //실제 이동속도를 입력값과 이동 속력을 사용해 결정
        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;
        //Vector3 속도를 (xSpeed, 0 , ySpeed로 설정)
        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);

        playerRigidbody.velocity = newVelocity;
    }

    public void Die()
    {
        gameObject.SetActive(false);

        GameManager gameManager = FindObjectOfType<GameManager>();
        gameManager.EndGame();
    }
}
