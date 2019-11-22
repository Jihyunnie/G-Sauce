using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public Transform player1;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = player1.position + offset; 
    }
}
