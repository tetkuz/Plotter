using System;
using Domain.Entities;
using UnityEngine;
using UnityEngine.UI;

public class PointOfInterestInfoView : MonoBehaviour
{
  [ SerializeField ] private InputField nameField = default;
  [ SerializeField ] private InputField descriptionField = default;

  public void SetPointOfInterest( PointOfInterest pointOfInterest )
  {
    nameField.text = pointOfInterest.Name;
    descriptionField.text = pointOfInterest.Description;
  }
}