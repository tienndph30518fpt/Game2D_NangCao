using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DịChyenVatCan : MonoBehaviour
{
 
    
    public float travelHeight = 2f;  // Độ cao di chuyển lên
    public float speed = 2f;// tốc đọ di chuyển

    private Vector3 initialPosition;//ưu trữ vị trí ban đầu của game object khi nó được khởi tạo.
    private bool movingUp = true;//theo dõi hướng di chuyển của game object

    void Start()
    {
        // Lưu vị trí ban đầu
        initialPosition = transform.position;
    }

    void Update()
    {
        // Di chuyển lên và xuống
        float verticalMovement = speed * Time.deltaTime * (movingUp ? 1 : -1);
        transform.Translate(Vector3.up * verticalMovement);
        
        // Nếu đạt tới độ cao cần đạt, đổi hướng
        if (Mathf.Abs(transform.position.y - initialPosition.y) >= travelHeight)
        {
            initialPosition = transform.position;
            movingUp = !movingUp;
        }
       
    }
}
