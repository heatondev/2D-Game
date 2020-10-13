using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Transform Player;
    public int speed = 5;
    public int jump = 5;
    float _moveX;
    float _moveY;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _moveX = Input.GetAxis("Horizontal");
        _moveY = Input.GetAxis("Vertical");

        movePlayer(speed);
        
        /*  if (Input.GetKeyDown(KeyCode.D)){
              transform.Translate(Vector2.right * Time.deltaTime * _speed);
          } */
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpPlayer(jump);
        }
    }
    void movePlayer(int pSpeed)
    {
        transform.Translate(new Vector2(_moveX, _moveY) * Time.deltaTime * pSpeed);
    }
        void jumpPlayer(int pJump)
        {
            transform.Translate(new Vector2(0, 1) * Time.deltaTime * pJump);
        }
}
