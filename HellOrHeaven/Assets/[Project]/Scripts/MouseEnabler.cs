using UnityEngine;
using UnityEngine.UI;

public class MouseEnabler : MonoBehaviour
{
    [SerializeField] private GameObject _obj;

    private void Start()
    {
        _obj.SetActive(false);
    }

    private void OnMouseEnter()
    {
        _obj.SetActive(true);
    }

    private void OnMouseExit()
    {
        _obj.SetActive(false);
    }
}