namespace Chessor.Interfaces;

using System.Numerics;

public interface IPickable
{
    public bool IsSelect { get; }
    public Vector2 Coordinate { get; }
}