using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LapsManager : MonoBehaviour
{
    private GameController gameController;

    private int currentCheckpointIndex = 0;
    private int scores = 0;
    private int lapsDone = 0;

    // Start is called before the first frame update
    void Start()
    {
        gameController = FindObjectOfType<GameController>();

        currentCheckpointIndex = 0;
        scores = 0;
        lapsDone = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        int contactedColliderIndex = GetCheckpointIndex(other);
        Debug.Log($"contactedColliderIndex - {contactedColliderIndex}");
        Debug.Log($"currentCheckpointIndex - {currentCheckpointIndex}");
        Debug.Log("--------------");

        if (currentCheckpointIndex < contactedColliderIndex)
        {
            currentCheckpointIndex = contactedColliderIndex;
            //Debug.Log($"currentCheckpointIndex - {currentCheckpointIndex}");
        }
        else if (contactedColliderIndex == 0 &&
                 currentCheckpointIndex == gameController.P1Checkpoints.Length - 1)
        {
            currentCheckpointIndex = contactedColliderIndex;
            lapsDone++;
            scores += 10;
            //Debug.Log($"currentCheckpointIndex - {currentCheckpointIndex}");
            Debug.Log($"lapsDone - {lapsDone}");
            Debug.Log($"scores - {scores}");
        }
    }


    /// <summary>
    /// Возвращает индекс чекпоинта с которым произошло столкновение
    /// </summary>
    /// <param name="other">Коллайдер триггер с которым проверяется столкновение</param>
    /// <returns></returns>
    private int GetCheckpointIndex(Collider other)
    {
        if (gameObject.tag == "Player")
        {
            for (int i = 0; i < gameController.P1Checkpoints.Length; i++)
            {
                if (gameController.P1Checkpoints[i].name == other.gameObject.name)
                {
                    return i;
                }
            }
        }

        if (gameObject.tag == "Player2")
        {
            for (int i = 0; i < gameController.P2Checkpoints.Length; i++)
            {
                if (gameController.P2Checkpoints[i].name == other.gameObject.name)
                {
                    return i;
                }
            }
        }
        Debug.Log("Collider does not exist in P1Checkpoints and P2Checkpoints");
        return 0;

    }
}
