using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureData : ScriptableObject
{
    [Header("Basic Data")]
    [Tooltip("최대 체력")]
    public float HP;
    [Tooltip("공격력")]
    public int ATK;
    [Tooltip("이동속도")]
    public int SPD;
    [Tooltip("점프속도")]
    public int JMP;


}
