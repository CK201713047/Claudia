using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creature : MonoBehaviour
{
    [SerializeField]
    private CreatureData _CD;

    /* Draw */
    // 오른쪽을 보고있는가
    public bool isRight;
    public Animator Anim { get; private set; }

    public virtual void Start()
    {
        isRight = true;
        Anim = GetComponent<Animator>();
    }

    void Dead()
    {

    }

    void Shock()
    {

    }

    void Damaged(float inDamage)
    {

    }

    float Attack()
    {
        return _CD.ATK;
    }
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.Equals("Rain"))
        {

        }
        else if (collision.Equals("Lightning"))
        {

        }
    }
}
