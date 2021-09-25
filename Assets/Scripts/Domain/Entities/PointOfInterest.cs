using System;
using UnityEngine;

namespace Domain.Entities
{
  public class PointOfInterest
  {
    public string Id { get; }
    public string Name { get; }
    public string Description { get; }
    public Vector3 Position { get; }

    public PointOfInterest( string name )
    {
      Id = Guid.NewGuid().ToString();
      Name = name;
    }

    public PointOfInterest( string name, string description, Vector3 position )
    {
      Id = Guid.NewGuid().ToString();
      Name = name;
      Description = description;
      Position = position;
    }
  }
}