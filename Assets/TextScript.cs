using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScript : MonoBehaviour
{
    [SerializeField]
    private Text _title;


    public void AddedItem()
    {
        _title.text = "Updated Text";
    }
}
