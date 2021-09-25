using System;
using Domain.Entities;
using UnityEngine;
using UnityEngine.EventSystems;

public class PointOfInterestMarker : MonoBehaviour, IPointerClickHandler
{
  private PointOfInterest _pointOfInterest;

  public event Action<PointOfInterest> OnClicked;

  public void UpdatePointOfInterest( PointOfInterest pointOfInterest )
  {
    _pointOfInterest = pointOfInterest;
  }

  public string GetId()
  {
    return _pointOfInterest?.Id;
  }

  public void OnPointerClick( PointerEventData eventData )
  {
    OnClicked?.Invoke( _pointOfInterest );
  }
}