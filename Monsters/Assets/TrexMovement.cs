using UnityEngine;
using System.Collections;

public class TrexMovement : MonoBehaviour
{
    Animator m_animator;

    private void Start()
    {
        m_animator = GameObject.Find("Trex_Animated").GetComponent<Animator>();
    }

    private void Update()
    {
        bool isWalkingPressed = Input.GetKey("right");
        m_animator.SetBool("isWalking", isWalkingPressed);

        bool isHit = Input.GetKey("up");
        m_animator.SetBool("isHit", isHit);

        bool isDead = Input.GetKey("down");
        m_animator.SetBool("isDead", isDead);

        bool isTurned = Input.GetKey("left");
        m_animator.SetBool("isTurned", isTurned);

    }
   
}