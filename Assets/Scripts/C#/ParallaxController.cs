using UnityEngine;

public class ParallaxController : MonoBehaviour
{
    Transform cam;
    Vector3 camStartPos;
    float distance;

    GameObject[] backgrounds;
    Material[] mat;
    float[] backSpeed;

    float farthestBack;
    public float parallaxSpeed = 0.02f;

    [Header("Background Transition Settings")]
    public float changePointX = 50f; // X đầu tiên để đổi nền
    public float changeInterval = 50f; // Mỗi lần đổi nền, X sẽ tăng thêm bao nhiêu
    public GameObject[] backgroundPrefabs; // Danh sách Background thay thế

    private int currentBackgroundIndex = 0; // Background đang dùng

    void Start()
    {
        cam = Camera.main.transform;
        camStartPos = cam.position;

        int backCount = transform.childCount;
        mat = new Material[backCount];
        backSpeed = new float[backCount];
        backgrounds = new GameObject[backCount];

        for (int i = 0; i < backCount; i++)
        {
            backgrounds[i] = transform.GetChild(i).gameObject;
            mat[i] = backgrounds[i].GetComponent<Renderer>().material;
        }

        BackSpeedCalculate(backCount);
    }

    void BackSpeedCalculate(int backCount)
    {
        for (int i = 0; i < backCount; i++)
        {
            if ((backgrounds[i].transform.position.z - cam.position.z) > farthestBack)
            {
                farthestBack = backgrounds[i].transform.position.z - cam.position.z;
            }
        }

        for (int i = 0; i < backCount; i++)
        {
            backSpeed[i] = 1 - (backgrounds[i].transform.position.z - cam.position.z) / farthestBack;
        }
    }

    private void LateUpdate()
    {
        distance = cam.position.x - camStartPos.x;
        float verticalDistance = cam.position.y - camStartPos.y; // Khoảng cách theo Y

        // 🔹 Camera di chuyển theo cả X và Y
        transform.position = new Vector3(cam.position.x, cam.position.y, 0);

        for (int i = 0; i < backgrounds.Length; i++)
        {
            float speed = backSpeed[i] * parallaxSpeed;

            // 🔹 Background vẫn có hiệu ứng di chuyển cả X và Y
            mat[i].SetTextureOffset("_MainTex", new Vector2(distance, verticalDistance) * speed);
        }

        // 🔥 Nếu camera đi qua điểm X, đổi background (nhưng không cần Y)
        if (cam.position.x >= changePointX)
        {
            ChangeBackground();
        }
    }


    void ChangeBackground()
    {
        if (backgroundPrefabs.Length == 0) return; // Không có background thay thế thì thoát

        // Tắt background hiện tại
        backgrounds[currentBackgroundIndex].SetActive(false);

        // Chuyển sang background tiếp theo (vòng lặp)
        currentBackgroundIndex = (currentBackgroundIndex + 1) % backgroundPrefabs.Length;

        // Bật background mới
        backgrounds[currentBackgroundIndex].SetActive(true);

        // Tăng điểm X để đổi nền lần sau
        changePointX += changeInterval;
    }
}
