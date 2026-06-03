using UnityEngine;

public class TestTubePH : MonoBehaviour
{
    public float pH;

    public Renderer liquidRenderer;
    z
    public void AddIndicator()
    {
        liquidRenderer.material.color = GetPHColor();
    }

    Color GetPHColor()
    {
        if (pH <= 2)    
            return Color.red;

        if (pH <= 4)
            return new Color(1f, 0.2f, 0.6f);

        if (pH <= 6)
            return new Color(0.6f, 0f, 1f);

        if (pH <= 7)
            return new Color(0.3f, 0.3f, 1f);

        if (pH <= 9)
            return Color.cyan;

        if (pH <= 11)
            return Color.green;

        return Color.yellow;
    }
}