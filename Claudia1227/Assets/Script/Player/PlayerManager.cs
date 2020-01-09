using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private static PlayerManager _Instance;
    public static PlayerManager Instance
    {
        get
        {
            if (_Instance == null) { _Instance = GameObject.FindObjectOfType<PlayerManager>(); }
            return _Instance;
        }
    }

    public Rigidbody2D Rigid { get; set; }
    public SpriteRenderer Renderer { get; set; }

    //땅 관련
    private Transform[] _groundPoints;
    public LayerMask groundLayer;
    public LayerMask MovableLayer;

    //점프 관련
    public float _jumpForce;
    public float _jumpDelay;

    // 체력
    private GameObject _HP;
    private Animator[] _HPAnim;
    [HideInInspector]
    public int _maxHP;
    [HideInInspector]
    public int _currentHP;
    private int _currentUIHP;

    public void Start()
    {
        Rigid = GetComponent<Rigidbody2D>();
        Renderer = GetComponent<SpriteRenderer>();

        // 발바닥 탐색
        _groundPoints = new Transform[transform.GetChild(0).childCount];
        for (int i = 0; i < _groundPoints.Length; i++) { _groundPoints[i] = transform.GetChild(0).GetChild(i); }

        // HP 세팅
        _HP = GameObject.Find("HP_Heart");
        _HPAnim = new Animator[_HP.transform.childCount];
        for (int i = 0; i < _HPAnim.Length; i++) { _HPAnim[i] = _HP.transform.GetChild(i).GetComponent<Animator>(); }
        _maxHP = _HP.transform.childCount;
        _currentHP = _maxHP;
        _currentUIHP = _currentHP;
    }

    private void Update()
    {
    }
}
