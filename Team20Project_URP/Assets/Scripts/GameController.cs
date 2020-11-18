using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private GameObject[] p1Checkpoints;
    /// <summary>
    /// Массив чекпоинтов для игрока 1
    /// </summary>
    public GameObject[] P1Checkpoints { get { return p1Checkpoints; } }

    [SerializeField] private GameObject[] p2Checkpoints;
    /// <summary>
    /// Массив чекпоинтов для игрока 2
    /// </summary>
    public GameObject[] P2Checkpoints { get { return p2Checkpoints; } }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
