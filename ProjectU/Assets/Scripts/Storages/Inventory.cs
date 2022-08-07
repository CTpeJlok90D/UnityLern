using UnityEngine;
using UnityEngine.InputSystem;

public class Inventory : Container
{
    [SerializeField] private UIItem[] _testItem;

    public void RotateSelectedItem(InputAction.CallbackContext context)
    {
        if (_selectedItem != null)
        {
            _selectedItem.Rotate();
            SelectedItemFollowMouse();
        }
    }
    public void DropSelectedItem()
    {
        if (_selectedItem != null)
        {
            _selectedItem.Drop(_character.transform.position);
        }
    }
    private void Start()
    {
        for (int i = 0; i < _testItem.Length; i++)
        {
            TryAddItem(_testItem[i], new Vector2Int(0, i));
        }
    }
}
