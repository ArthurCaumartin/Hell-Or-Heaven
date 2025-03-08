using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FileSetter : MonoBehaviour
{
    [SerializeField] private FileData _fileData;

    [Header("ID : ")]
    [SerializeField] private TextMeshProUGUI _firstNameText;
    [SerializeField] private TextMeshProUGUI _lastNameText;
    [SerializeField] private TextMeshProUGUI _marticuleText;

    [Header("Human Value : ")]
    [SerializeField] private TextMeshProUGUI _competenceText;
    [SerializeField] private TextMeshProUGUI _succesText;

    [Header("Carte Regret : ")]
    [SerializeField] private TextMeshProUGUI _prideText;
    [SerializeField] private TextMeshProUGUI _regretText;

    [Header("Human Value : ")]
    [SerializeField] private Image _socialValuePoint;
    [SerializeField] private RectTransform _socialValuePivotA;
    [SerializeField] private RectTransform _socialValuePivotB;
    [SerializeField] private Image _useIaImage;
    private float _socialValue;

    private void Start()
    {
        GenerateFiles();
    }

    private void GenerateFiles()
    {
        _firstNameText.text = _fileData.firstNames.GetRandom();
        _lastNameText.text = _fileData.lastNames.GetRandom();
        _marticuleText.text = _fileData.matricules.GetRandom();

        _competenceText.text = _fileData.competence.GetRandom();
        _succesText.text = _fileData.succes.GetRandom();

        _prideText.text = _fileData.prides.GetRandom();
        _regretText.text = _fileData.regrets.GetRandom();

        _socialValue = Random.Range(0, 11);
        _socialValuePoint.transform.position = Vector3.Lerp(_socialValuePivotA.position, _socialValuePivotB.position, _socialValue / 10);

        _useIaImage.enabled = Random.value > .5f;
    }
}


// public class MouseEnabler : MonoBehaviour
// {
//     [SerializeField] private 
// }