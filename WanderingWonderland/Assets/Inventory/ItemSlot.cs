
using UnityEngine;
using UnityEngine.UI;


public class ItemSlot : MonoBehaviour
{

    [SerializeField] Image Image;
    private Item _item;
    public Item item
    {
        get { return _item; }
        set
        {
            _item = value;
            if (item = null)
            {
                Image.enabled = false;
            }
            else
            {
                Image.sprite = _item.Icon;
                Image.enabled = true;
            }
        }
    }

    private void OnValidate()
    {
        if (Image == null)
          Image = GetComponent<Image>();
        
    }
}
