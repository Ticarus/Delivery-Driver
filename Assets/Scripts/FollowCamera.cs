using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject objectFollow;
    void LateUpdate()
    {
        transform.position = objectFollow.transform.position + new Vector3(0f, 0f, -10f);
    }
}
