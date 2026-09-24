using UnityEngine;

public class BackgroundScript : MonoBehaviour
{
    public float scrollSpeed;

    [SerializeField] 
    private Renderer BackgroundRenderer;

    // Update is called once per frame
    void Update()
    {
        BackgroundRenderer.material.mainTextureOffset += new Vector2(scrollSpeed * Time.deltaTime, 0);
    }
}
