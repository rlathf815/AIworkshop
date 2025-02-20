using UnityEngine;

public class UnitSpawner : MonoBehaviour
{
    public GameObject unitPrefab; // 생성할 유닛 프리팹
    public Transform spawnPoint; // 유닛이 생성될 위치
    public int unitCost = 50; // 유닛 소환 비용

    public void SpawnUnit()
    {
        if (GameManager.instance.playerPoints >= unitCost) // 포인트 체크
        {
            GameManager.instance.SpendPoints(unitCost); // 포인트 차감
            Instantiate(unitPrefab, spawnPoint.position, Quaternion.identity); // 유닛 생성
        }
    }
}
