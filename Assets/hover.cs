using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class hover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    // Start is called before the first frame update
public SpriteRenderer spriteRenderer;
public Color color1 = new Color(169,169,169);
public Color color2 = new Color(0,0,0);
    void Start()
    {
    
    }
    void Update()
    {
        
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        spriteRenderer.color = color1;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        spriteRenderer.color = color2;
    }
}
