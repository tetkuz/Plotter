using Domain.Entities;
using Domain.Repository;
using Domain.UseCases;
using UnityEngine;
using VContainer;
using VContainer.Unity;

public class ApplicationLifetimeScope : LifetimeScope
{
  [ SerializeField ] private PointOfInterestView pointOfInterestView = default;
  [ SerializeField ] private PointOfInterestInfoView pointOfInterestInfoView = default;
  protected override void Configure( IContainerBuilder builder )
  {
    builder.Register<IPointOfInterestRepository, InMemoryRepository>( Lifetime.Singleton );
    builder.Register<IGetPointOfInterestsUseCase<PointOfInterest>, GetPointOfInterestsInteractor>( Lifetime.Singleton );
    builder.RegisterComponent( pointOfInterestView );
    builder.RegisterComponent( pointOfInterestInfoView );
  }
}