using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class DragAndDrop : MonoBehaviour,IDragHandler,IBeginDragHandler,IEndDragHandler
{
    private RectTransform rectTransform;
    private Image image;

    public void OnBeginDrag(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
        //or
       
    }

    public void OnDrag(PointerEventData eventData)
    {
      rectTransform.anchoredPosition += eventData.delta;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
        //or
       
    }

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        image = GetComponent<Image>();
    }


}
