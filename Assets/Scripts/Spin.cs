using UnityEngine;

public class Spin : MonoBehaviour
{
    public float spinSpeed = 45f;
    public Vector3 rotationAxis = new Vector3(0, 1, 0);

    private void Update() => transform.eulerAngles += rotationAxis * (spinSpeed * Time.deltaTime);
}
