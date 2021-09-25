using System;
using System.Collections.Generic;
using Domain.Entities;
using UnityEngine;

public class PointOfInterestView : MonoBehaviour
{
  private readonly Dictionary<string, GameObject> _pointOfInterestMakers = new Dictionary<string, GameObject>();
  private PointOfInterestView _instance;

  public event Action<PointOfInterest> OnPointOfInterestMarkerClicked;

  private void Awake()
  {
    _instance = this;
  }

  public void UpdatePointOfInterests( IEnumerable<PointOfInterest> pointOfInterests )
  {
    if ( _pointOfInterestMakers == null )
      throw new NullReferenceException( nameof( _pointOfInterestMakers ) );

    foreach ( var pointOfInterest in pointOfInterests ) {
      // Get or Instantiate GameObject
      var obj = ( _pointOfInterestMakers.ContainsKey( pointOfInterest.Id ) )
        ? _pointOfInterestMakers[ pointOfInterest.Id ]
        : Instantiate( Resources.Load<GameObject>( "PointOfInterestMarker" ) );
      obj.transform.position = pointOfInterest.Position;
      obj.transform.parent = _instance.gameObject.transform;

      // Update PointOfInterest
      var marker = obj.GetComponent<PointOfInterestMarker>();
      if ( marker != null ) {
        marker.UpdatePointOfInterest( pointOfInterest );
        marker.OnClicked += interest => OnPointOfInterestMarkerClicked?.Invoke(interest);
      }

      _pointOfInterestMakers[ pointOfInterest.Id ] = obj;
    }
  }
}