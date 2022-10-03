using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageList : MonoBehaviour
{
    [SerializeField]
    private List<string> StageNames;

    public string GetStageName(int num)
    {
        if (num > -1 && num < StageNames.Count)
        {
            return StageNames[num];
        }

        return "";
    }
}
