using UnityEngine;

public class UnitSpawner : MonoBehaviour
{
    public GameObject unitPrefab; // ������ ���� ������
    public Transform spawnPoint; // ������ ������ ��ġ
    public int unitCost = 50; // ���� ��ȯ ���

    public void SpawnUnit()
    {
        if (GameManager.instance.playerPoints >= unitCost) // ����Ʈ üũ
        {
            GameManager.instance.SpendPoints(unitCost); // ����Ʈ ����
            Instantiate(unitPrefab, spawnPoint.position, Quaternion.identity); // ���� ����
        }
    }
}
