using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canDrag : MonoBehaviour
{
    //Initialising Variables
    Vector3 mousePositionOffset;
    public GameObject block;

    //[SerializeField] Camera camera;

    private Vector3 GetMouseWorldPosition()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void OnMouseDown()
    {
        //Get mouse position offset
        mousePositionOffset = block.transform.position - GetMouseWorldPosition();
    }

    private void OnMouseDrag()
    {
        block.transform.position = GetMouseWorldPosition() + mousePositionOffset;
    }
}