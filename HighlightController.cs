//Author: Tuyen Nguyen
//Source: https://github.com/nntuyen/unity-highlight-selected-object

using UnityEngine;

public class HighlightController : MonoBehaviour
{
  private HighlightObject highlightObject;

  public void SelectObject(HighlightObject highlightObject)
 {
    if (this.highlightObject != null)
    {
      this.highlightObject.StopHighlight();
    }

    this.highlightObject = highlightObject;
    this.highlightObject.StartHighlight();
  }
}
