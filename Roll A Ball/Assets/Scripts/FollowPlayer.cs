using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform playerTransform;
    private Vector3 offset;

    // Start is called before the first frame update
    private void Start()
    {
        offset = transform.localPosition - playerTransform.localPosition;
    }

    // Update is called once per frame
    private void Update()
    {
        transform.localPosition = playerTransform.localPosition + offset;
    }
}