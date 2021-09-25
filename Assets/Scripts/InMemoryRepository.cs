using System.Collections.Generic;
using System.Linq;
using Domain.Entities;
using Domain.Repository;
using UnityEngine;

public class InMemoryRepository : IPointOfInterestRepository
{
  private readonly Dictionary<string, PointOfInterest> _data = new Dictionary<string, PointOfInterest>();

  public InMemoryRepository()
  {
    for ( int i = 0 ; i < 5 ; i++ ) {
      Save( new PointOfInterest( "door" + i, "", new Vector3( -10.0f + i * 5.0f, 0.0f, -20.0f + i * 5.0f ) ) );
    }
  }

  public void Save( PointOfInterest poi )
  {
    _data[ poi.Id ] = clonePointOfInterest( poi );
  }

  public PointOfInterest FindByName( string poiName )
  {
    return _data.Select( x => x.Value ).FirstOrDefault( x => x.Name == poiName );
  }

  public IEnumerable<PointOfInterest> FindAll()
  {
    return _data.Values;
  }

  private PointOfInterest clonePointOfInterest( PointOfInterest poi )
  {
    return new PointOfInterest( poi.Name, poi.Description, poi.Position );
  }
}