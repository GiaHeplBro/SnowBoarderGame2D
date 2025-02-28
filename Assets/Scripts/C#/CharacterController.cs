using UnityEngine;

public class CharacterRotation : MonoBehaviour
{
    public Score scoreManager; // Tham chiếu đến script Score.cs
    private float totalRotation = 0f; // Tổng góc quay
    private float lastRotation = 0f; // Lưu góc quay trước đó

    void Update()
    {
        float currentRotation = transform.eulerAngles.z; // Lấy góc quay theo trục Z
        float deltaRotation = Mathf.DeltaAngle(lastRotation, currentRotation); // Tính góc xoay thực tế giữa 2 frame
        totalRotation += Mathf.Abs(deltaRotation); // Cộng vào tổng góc quay

        // Nếu quay đủ 360 độ thì cộng điểm
        if (totalRotation >= 360f)
        {
            totalRotation = 0f; // Reset sau khi đủ 1 vòng
            scoreManager.AddScore(10); // Cộng 10 điểm mỗi vòng quay
        }

        lastRotation = currentRotation; // Cập nhật góc quay trước đó
    }
}
