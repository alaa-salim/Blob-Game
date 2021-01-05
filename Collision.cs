//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.SceneManagement;

//public class SwitchScenes : MonoBehaviour
//{
//    public GameObject death;
//    Rigidbody2D body;
//    float x;

//    [SerializeField]
//    float moveSpeed = 5f;

//    void Update()
//    {
//        x = Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime;
//        transform.position = new Vector2(transform.position.x + x, transform.position.y);
//    }

//    void Dead()
//    {
//        Instantiate(death, transform.position, Quaternion.identity);
//        Destroy(gameObject);
//    }

//    void OnTriggerEnter2D(Collider2D collision)
//    {
//        if (collision.tag == "Enemy")
//        {
//            Dead();
//        }
//    }