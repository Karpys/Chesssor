namespace Chessor.Helpers;

using System.Numerics;

public static class MouseEvent
{
    public static Vector2 MousePosition =Vector2.Zero;
    public static Action<Vector2> OnClick = null;

    public static void OnMouseClick(Vector2 position)
    {
        OnClick?.Invoke(position);
    }

    public static void OnMouseMove(Vector2 position)
    {
        MousePosition = position;
    }
}