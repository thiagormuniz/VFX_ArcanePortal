using UnityEngine;

[ExecuteAlways]
public class AutoRotator : MonoBehaviour
{    
    public bool autoRotateOnEditor = false;
    [SerializeField]
    private Vector3 rotationSpeed = new Vector3(0f, 30f, 0f);

    private void Update()
    {
        if (!Application.isPlaying && !autoRotateOnEditor) return;

        transform.Rotate(rotationSpeed * Time.deltaTime);
    }
}
