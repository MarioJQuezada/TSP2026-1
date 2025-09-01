using UnityEngine;

public class SunTextureAnimator : MonoBehaviour
{
    public Material sunMaterial;
    public float speed = 0.02f;

    void Update()
    {
        float offset = Time.time * speed;
        sunMaterial.mainTextureOffset = new Vector2(offset, offset);
    }
}

