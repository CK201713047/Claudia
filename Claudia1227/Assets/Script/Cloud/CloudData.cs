using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudData : ScriptableObject
{
    [Header("Basic Data")]
    [Tooltip("기본 이동 속도")]
    public float moveSpeed;
    [Tooltip("플레이어를 잃어버리는 거리")]
    public float findDiatance;

    [Header("Layer Data")]
    [Tooltip("지날 수 없는 오브젝트 레이어")]
    public LayerMask CantPassLayer;

    // skill
    [Header("Skill Data")]
    [Tooltip("스킬 게이지 차는 속도")]
    public float chargeSpeed;

    // skill : Rain
    [Header("Skill Rain")]
    public GameObject RainPrefab;
    public float RainFrequency;
    public float RainUseGauge;

    // skill : Light
    [Header("Skill Light")]
    public GameObject LightPrefab;
    public float LightUseGauge;

    // skill : Box
    [Header("Skill Box")]
    public float BoxUseGauge;
}
