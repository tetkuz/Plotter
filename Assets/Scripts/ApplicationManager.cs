using System;
using System.Linq;
using Domain.Entities;
using UnityEngine;
using VContainer;

public class ApplicationManager : MonoBehaviour
{
  private IGetPointOfInterestsUseCase<PointOfInterest> _getPointOfInterestsUseCase;
  private PointOfInterestView _pointOfInterestView;
  private PointOfInterestInfoView _pointOfInterestInfoView;

  [ Inject ]
  public void Construct( IGetPointOfInterestsUseCase<PointOfInterest> getPointOfInterestsUseCase,
    PointOfInterestView pointOfInterestView,
    PointOfInterestInfoView pointOfInterestInfoView )
  {
    _getPointOfInterestsUseCase = getPointOfInterestsUseCase;
    _pointOfInterestView = pointOfInterestView;
    _pointOfInterestInfoView = pointOfInterestInfoView;

    _pointOfInterestView.OnPointOfInterestMarkerClicked += pointOfInterest =>
      _pointOfInterestInfoView.SetPointOfInterest( pointOfInterest );
  }

  private void Start()
  {
    ShowPointOfInterest();
  }

  private void ShowPointOfInterest()
  {
    var pois = _getPointOfInterestsUseCase.Handle();
    _pointOfInterestView.UpdatePointOfInterests( pois );
  }
}