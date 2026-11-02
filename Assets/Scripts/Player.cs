using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public enum Items
{
    Espresso,
    Latte,
    Cappuccino,
    Americano,
    Water,
    Milk,
    Cup,
    None
}

public class Player : MonoBehaviour
{
    public Items holding = Items.None;

    public int customersServed = 0;

    [SerializeField] private Camera camera;
    [SerializeField] private TextMesh desc;
    [SerializeField] private GameObject heldCup;
    [SerializeField] private TextMesh holdingText;

    public TextMesh servedText;
    public TextMesh orderText;

    private float textTimer = 2.0F;

    public Vector2 mouse;

    private int sensitivity = 30;

    void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        mouse.x += Input.GetAxis("Mouse X") * (sensitivity / 10);
        mouse.y += Input.GetAxis("Mouse Y") * (sensitivity / 10);

        if (mouse.x >= 90)
        {
            mouse.x = 90;
        }
        else if (mouse.x <= -90)
        {
            mouse.x = -90;
        }

        if (mouse.y >= 90)
        {
            mouse.y = 90;
        }
        else if (mouse.y <= -90)
        {
            mouse.y = -90;
        }

        camera.transform.localRotation = Quaternion.Euler(-mouse.y, mouse.x, 0);

        if (textTimer > 0)
        {
            textTimer -= Time.deltaTime;
        }
        else
        {
            desc.text = "";
        }
    }

    public void textUpdate(string text)
    {
        desc.text = text;
        textTimer = 2;
    }

    public void pickUp(Items item)
    {
        heldCup.SetActive(true);
        holding = item;
        holdingText.text = "" + holding;
        textUpdate("Got " + holding);
    }

    public void dropItem()
    {
        heldCup.SetActive(false);
        holding = Items.None;
        holdingText.text = "";
    }
}
