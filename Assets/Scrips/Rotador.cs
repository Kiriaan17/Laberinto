using UnityEngine;

public class ComponenteRotador : MonoBehaviour
{
    [SerializeField]
    public float rotacionY = 10f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0.0f, rotacionY * Time.deltaTime, 0f);
    }
}