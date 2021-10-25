using UnityEngine.InputSystem;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector3 newPosition;
    public float speed;
    public Rigidbody rg;
    // Start is called before the first frame update
    void Start()
    {
        rg = this.GetComponent<Rigidbody>();
    }
    void  Update () {
        //OnMove();
        FixedUpdate();
    }

    public void OnMovement(InputAction.CallbackContext value)
    {
        Vector2 inputMovement = value.ReadValue<vector2>();
        rawInputMovement = new Vector3(inputMovement.x, 0, inputMovement.y);
    }

    public void OnAttack(InputAction.CallbackContext value)
    {
        if (value.started)
        {
            Debug.Log("Att");
        }
    }
    //void OnMove(InputValue inputValue)
    //{
    //newPosition = rg.position + new Vector3(inputValue.Get<Vector2>().x * speed, 0f, inputValue.Get<Vector2>().y * speed);
    //}

    // Update is called once per frame
    void FixedUpdate()
    {
        rg.position = newPosition;
    }
}
