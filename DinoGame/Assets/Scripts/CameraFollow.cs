using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector2 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = target.position * offset;
    }
}
