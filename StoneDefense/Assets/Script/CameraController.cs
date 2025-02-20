using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float moveSpeed = 5f; // ī�޶� �̵� �ӵ�
    public float minX = 0f; // �ּ� �̵� ���� X��
    public float maxX = 10f; // �ִ� �̵� ���� X��

    private bool isMovingLeft = false;
    private bool isMovingRight = false;

    void Update()
    {
        if (isMovingLeft)
        {
            transform.position = new Vector3(
                Mathf.Clamp(transform.position.x - moveSpeed * Time.deltaTime, minX, maxX),
                transform.position.y,
                transform.position.z
            );
        }

        if (isMovingRight)
        {
            transform.position = new Vector3(
                Mathf.Clamp(transform.position.x + moveSpeed * Time.deltaTime, minX, maxX),
                transform.position.y,
                transform.position.z
            );
        }
    }

    public void StartMoveLeft() => isMovingLeft = true;
    public void StopMoveLeft() => isMovingLeft = false;

    public void StartMoveRight() => isMovingRight = true;
    public void StopMoveRight() => isMovingRight = false;
}
