using System;
using UnityEngine;
using UnityEngine.UI;

public class TextField : MonoBehaviour
{

  [ Header( "Properties" ) ]
  public string label = "";
  public string placeholder = "";
  public string text = "";

  [SerializeField] private Text labelObject;
  [SerializeField] private Text placeholderObject;
  [SerializeField] private Text textObject;

  private void Awake()
  {
    labelObject.text = label;
    placeholderObject.text = placeholder;
    textObject.text = text;
  }
}