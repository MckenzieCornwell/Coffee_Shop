using UnityEngine;

public class ClickDetector : MonoBehaviour
{
    private void Update()
    //calls every frame
    {
        if (Input.GetMouseButtonDown(0))
        //checks if left mouse button is clicked
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //shoots a ray from the camera to the mouse cursor

            if (Physics.Raycast(ray, out RaycastHit hit))
            //checks if the ray hits something
            {
                IClickable clickable = hit.collider.GetComponent<IClickable>();

                clickable?.OnClick();
                //calls the interface "IClickable"
            }
        }
    }
}