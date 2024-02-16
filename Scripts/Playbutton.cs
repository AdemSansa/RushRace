using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonImageChanger : MonoBehaviour, IPointerEnterHandler
{
    public Sprite newImage;
    public Sprite oldImage;
    public Image buttonImage;

    void Start()
    {
        // Get the Image component attached to the button
        
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        // Change the sprite of the button image
        buttonImage.sprite = newImage;
        
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        // Revert the sprite of the button image to the normal image
        buttonImage.sprite = oldImage;
    }
}
