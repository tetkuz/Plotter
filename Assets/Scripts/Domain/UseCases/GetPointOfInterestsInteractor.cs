using System;
using System.Collections.Generic;
using Domain.Repository;
using Domain.Entities;

namespace Domain.UseCases
{
  public class GetPointOfInterestsInteractor : IGetPointOfInterestsUseCase<PointOfInterest>
  {
    private readonly IPointOfInterestRepository _repository;

    public GetPointOfInterestsInteractor( IPointOfInterestRepository repository )
    {
      _repository = repository ?? throw new ArgumentNullException(nameof(repository));
    }

    public IEnumerable<PointOfInterest> Handle()
    {
      return _repository.FindAll();
    }
  }
}
