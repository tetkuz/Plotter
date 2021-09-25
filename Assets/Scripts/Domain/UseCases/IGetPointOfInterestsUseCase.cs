using System.Collections.Generic;

public interface IGetPointOfInterestsUseCase<out TResponse>
{
  IEnumerable<TResponse> Handle();
}