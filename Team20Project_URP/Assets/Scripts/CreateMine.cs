using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateMine : MonoBehaviour
{

    [SerializeField] private GameObject MinePrefab = null;          // Префаб мины
    [SerializeField] private int MaxCountMine = 5;                  // Кол-во мин на игру

    void Start()
    {
        
    }


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.S) && (gameObject.tag == "CreatorMines1"))
        {

            InstansMine();

        }

        if (Input.GetKeyDown(KeyCode.DownArrow) && (gameObject.tag == "CreatorMines2"))
        {

            InstansMine();



        }


    }
    /// <summary>
    /// Создание мины
    /// </summary>

    private void InstansMine() 
    {
        Instantiate(MinePrefab, transform.position, Quaternion.identity);  // создание мины 

        Debug.Log("Mine");
    }
}
