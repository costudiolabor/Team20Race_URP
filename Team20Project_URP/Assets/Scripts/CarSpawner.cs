using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    [SerializeField] private GameObject player1CarPrefab = null;// Переменная для хранения ссылки на префаб машины игрока 1
    [SerializeField] private GameObject player1SpawnPoint = null;// Переменная для хранения ссылки на точку спавна для машины игрока 1

    [SerializeField] private GameObject player2CarPrefab = null;// Переменная для хранения ссылки на префаб машины игрока 2
    [SerializeField] private GameObject player2SpawnPoint = null;// Переменная для хранения ссылки на точку спавна для машины игрока 2

    // Start is called before the first frame update
    void Start()
    {
        SpawnPlayersCars();
    }

    /// <summary>
    /// Спавн префабов машин игрока 1 и 2 в соответствующих точках спавна
    /// </summary>
    private void SpawnPlayersCars()
    {
        Instantiate(player1CarPrefab, player1SpawnPoint.transform.position, Quaternion.Euler(0, 180, 0));
        Instantiate(player2CarPrefab, player2SpawnPoint.transform.position, Quaternion.Euler(0, 0, 0));
    }
}
