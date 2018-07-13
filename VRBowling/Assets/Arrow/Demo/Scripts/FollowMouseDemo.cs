using UnityEngine;

public class FollowMouseDemo : MonoBehaviour
{
    public ArrowRenderer arrowRenderer;
    public float distanceFromScreen = 5f;
    
    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = distanceFromScreen;
        
        Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        arrowRenderer.SetPositions(Vector3.zero, worldMousePosition);
    }
}
