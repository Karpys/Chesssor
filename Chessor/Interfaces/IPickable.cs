namespace Chessor.Interfaces;

using System.Numerics;
using Helpers;

public interface IPickable : ICoordinate
{
    public bool IsSelect { get; }
    public Vector2 Coordinate { get; }

    public void TryPick(Vector2 mousePosition,out bool isNewPicked);
    public void InPickMovement(Vector2 mousePosition);
    public void Release(Vector2 mousePosition);
}