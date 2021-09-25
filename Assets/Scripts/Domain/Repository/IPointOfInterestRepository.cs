using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Repository
{
  public interface IPointOfInterestRepository
  {
    void Save(PointOfInterest poi);
    PointOfInterest FindByName(string poiName);
    IEnumerable<PointOfInterest> FindAll();
  }
}
