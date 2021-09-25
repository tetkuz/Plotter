using UnityEngine;
using UnityEngine.UI;

public class TextField : MonoBehaviour
{
  [ Header( "Properties" ) ] public string label = "";
  public string placeholder = "";
  public string text = "";

  [ SerializeField ] private Text labelObject = default;
  [ SerializeField ] private Text placeholderObject = default;
  [ SerializeField ] private Text textObject = default;

  private void Awake()
  {
    labelObject.text = label;
    placeholderObject.text = placeholder;
    textObject.text = text;
  }

  public void SetText( string data )
  {
    textObject.text = data;
  }
}