using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class DragAndDrop : MonoBehaviour,IDragHandler,IBeginDragHandler,IEndDragHandler
{
    private RectTransform rectTransform;
    private Image image;

    private Camera cam;
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

        cam = Camera.main;
    }
    void onGUI()
    {
        Vector3 point = new Vector3();
        Event currentEvent = Event.current;
        Vector2 mousePos = new Vector2();
        mousePos.x = currentEvent.mousePosition.x;
        mousePos.y = currentEvent.mousePosition.y;
        point = cam.ScreenToWorldPoint(new Vector3(mousePos.x,mousePos.y, cam.nearClipPlane));

        GUILayout.BeginArea(new Rect(mousePos.x, mousePos.y, 100, 100));
        GUILayout.Label("Screen pixels:" + cam.pixelWidth + ":" + cam.pixelHeight);
        GUILayout.Label("Mousew.position:" + mousePos);
        GUILayout.Label("Mousew.position:" + point.ToString("F3"));
        GUILayout.EndArea();
    }

}
