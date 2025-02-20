using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float moveSpeed = 5f; // 카메라 이동 속도
    public float minX = 0f; // 최소 이동 가능 X값
    public float maxX = 10f; // 최대 이동 가능 X값

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
