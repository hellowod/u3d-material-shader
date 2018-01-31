using UnityEngine;

public class Matrix : MonoBehaviour
{
    [SerializeField]
    private Matrix4x4 m_matrix;
    [SerializeField]
    private bool m_isTest;

    private Transform m_transform;

    private void Awake()
    {
        m_transform = transform;
    }

    private void Update()
    {
        m_matrix.SetTRS(
            m_transform.position,
            m_transform.rotation,
            m_transform.lossyScale);

        if (m_isTest) {
            m_isTest = false;
            Debug.LogError(m_matrix);
        }
    }
}
