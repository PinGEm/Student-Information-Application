using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StudentData : MonoBehaviour
{
    [SerializeField] private TMP_InputField _inputID;
    [SerializeField] private TMP_Text _name;
    [SerializeField] private TMP_Text _overallGrade;
    [SerializeField] private TMP_Text _birthDay;
    [SerializeField] private TMP_Text _age;
    [SerializeField] private TMP_Text _studentID;
    [SerializeField] private Image _pfp;

    [SerializeField] private GameObject _error;

    private void Start()
    {
        Setup();
    }

    public void Setup()
    {
        // Setup Details for Marcus
        PlayerPrefs.SetString("24-743Name", "Marcus Timothy Ureta");
        PlayerPrefs.SetFloat("24-743OverallGrade", 93);
        PlayerPrefs.SetString("24-743Birthday", "October 28, 2007");
        PlayerPrefs.SetInt("24-743Age", 17);

        // Setup Details for Warleyne
        PlayerPrefs.SetString("24-759Name", "Warleyne Espano Casanova");
        PlayerPrefs.SetFloat("24-759OverallGrade", 95);
        PlayerPrefs.SetString("24-759Birthday", "January 22, 2008");
        PlayerPrefs.SetInt("24-759Age", 17);

        // Setup Details for Arjan
        PlayerPrefs.SetString("24-752Name", "Arjan Jhames Manzano");
        PlayerPrefs.SetFloat("24-752OverallGrade", 97);
        PlayerPrefs.SetString("24-752Birthday", "October 12, 2007");
        PlayerPrefs.SetInt("24-752Age", 17);

        // Setup Details for Mateo
        PlayerPrefs.SetString("24-668Name", "Christian Mateo Adora");
        PlayerPrefs.SetFloat("24-668OverallGrade", 96);
        PlayerPrefs.SetString("24-668Birthday", "June 17, 2007");
        PlayerPrefs.SetInt("24-668Age", 17);

        // Setup Details for Isaiah
        PlayerPrefs.SetString("24-748Name", "Isaiah Will So See");
        PlayerPrefs.SetFloat("24-748OverallGrade", 93);
        PlayerPrefs.SetString("24-748Birthday", "February 24, 2006");
        PlayerPrefs.SetInt("24-748Age", 18);
    }

    public void Search()
    {
        string id = _inputID.text;

        if (PlayerPrefs.HasKey(id + "Name"))
        {
            _studentID.text = id;
            _name.text = PlayerPrefs.GetString(id + "Name");
            _overallGrade.text = PlayerPrefs.GetFloat(id + "OverallGrade").ToString();
            _birthDay.text = PlayerPrefs.GetString(id + "Birthday");
            _age.text = PlayerPrefs.GetInt(id + "Age").ToString();

            _pfp.sprite = Resources.Load<Sprite>("Images/" + id);
        }
        else
        {
            _error.SetActive(true);
        }
    }
}
