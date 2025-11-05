namespace Chessor.Helpers;

using System.Numerics;

public static class PositionHelper
{
    public static T GetClosest<T>(this List<T> list, Vector2 position) where T : ICoordinate
    {
        T closest = list[0];
        float distance = Vector2.Distance(position, closest.Coordinate);

        foreach (T element in list)
        {
            float currentDistance = Vector2.Distance(position,element.Coordinate);
            if (currentDistance < distance)
            {
                distance = currentDistance;
                closest = element;
            }
        }

        return closest;
    }
}

public interface ICoordinate
{
    public Vector2 Coordinate { get; }
}