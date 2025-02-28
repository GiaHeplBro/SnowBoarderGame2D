using UnityEngine;

public class SnowFollowPlayer : MonoBehaviour
{
    public Transform player;  // Gán nhân vật vào đây
    public Vector3 offset;    // Để điều chỉnh vị trí ban đầu
    public float followSpeed = 2f; // Tốc độ di chuyển của tuyết (chậm hơn nhân vật)

    private Vector3 targetPosition;

    void Update()
    {
        if (player != null)
        {
            // Tạo vị trí mục tiêu nhưng không di chuyển ngay lập tức
            targetPosition = new Vector3(player.position.x, player.position.y, transform.position.z) + offset;

            // 🔹 Di chuyển mượt theo nhân vật thay vì bám chặt
            transform.position = Vector3.Lerp(transform.position, targetPosition, followSpeed * Time.deltaTime);
        }
    }
}
