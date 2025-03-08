using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "FileData")]
public class FileData : ScriptableObject
{
    public List<string> firstNames;
    public List<string> lastNames;
    public List<string> matricules;
    [Space]
    public List<string> competence;
    public List<string> succes;
    [Space]
    public List<string> prides;
    public List<string> regrets;
}