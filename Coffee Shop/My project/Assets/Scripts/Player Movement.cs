using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    [Header("Movement Controls")]
    [SerializeField]
    private CharacterController controller;

    void Start()
    {
        Debug.LogWarning("Warning Message");
        Debug.LogError("Error Message");
    }
}
