using UnityEngine;

public class Jump : MonoBehaviour
{
    private void Update()
    {
        getJump();
    }
    void getJump()
    {
        if (Input.GetMouseButtonDown(0))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 5f), ForceMode2D.Impulse);
        }
    }
}
