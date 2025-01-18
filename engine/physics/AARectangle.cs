using Microsoft.Xna.Framework;

namespace engine.physics;

// An axis-aligned rectangle
public struct AARectangle : Shape
{
    public Vector2 topLeft;
    public Vector2 bottomRight;
}
