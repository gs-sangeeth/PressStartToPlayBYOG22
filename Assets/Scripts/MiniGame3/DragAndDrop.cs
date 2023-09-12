using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDrop : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    SpriteRenderer sr;
    Color color;

    GameObject outline;

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        color = sr.color;

        outline = transform.GetChild(0).gameObject;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        gameObject.GetComponent<SpriteRenderer>().color = new Color(color.r, color.g, color.b, .95f);
        outline.SetActive(true);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        gameObject.GetComponent<SpriteRenderer>().color = new Color(color.r, color.g, color.b, 1);
        outline.SetActive(false);
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector3 newPos = new(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y, 0);
        transform.position = newPos;
    }
}
