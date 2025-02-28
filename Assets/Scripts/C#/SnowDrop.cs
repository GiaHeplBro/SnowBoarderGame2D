using UnityEngine;

public class SnowDrop : MonoBehaviour
{
    public GameObject snowPrefab; // Prefab của bông tuyết
    public float minX = -5f, maxX = 5f; // Phạm vi ngang để spawn tuyết
    public float spawnHeight = 6f; // Vị trí tuyết bắt đầu rơi
    public float fallSpeed = 2f; // Tốc độ rơi của tuyết
    public float destroyTime = 5f; // Thời gian để hủy tuyết tránh lag

    void Start()
    {
        InvokeRepeating(nameof(SpawnSnow), 0.5f, 0.5f); // Tạo tuyết liên tục
    }

    void SpawnSnow()
    {
        Vector3 spawnPos = new Vector3(Random.Range(minX, maxX), spawnHeight, 0);
        GameObject snow = Instantiate(snowPrefab, spawnPos, Quaternion.identity, transform); // Gán vào Canvas
        snow.GetComponent<RectTransform>().anchoredPosition = spawnPos; // Đặt vị trí đúng
        Destroy(snow, destroyTime);
    }

}
