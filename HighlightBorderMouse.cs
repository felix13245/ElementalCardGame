using UnityEngine;

public class HighlightBorderMouse : MonoBehaviour
{
    public MeshRenderer MouseHighlight;

    void OnMouseEnter()
    {
        MouseHighlight.enabled = true;
    }

    void OnMouseExit()
    {
        MouseHighlight.enabled = false;
    }
}