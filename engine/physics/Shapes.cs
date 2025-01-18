using Microsoft.Xna.Framework;

namespace engine.physics;

// Class for handling various shape intersections
public class Shapes
{
    // TODO: Add constructors in each shape class
    // TODO: Triangle, Rectangle (not axis-aligned)

    // Check if a circle contains a point
    public static bool contains(Vector2 v, Circle c)
    {
        float minDist = c.radius;
        return (minDist * minDist) > Vector2.DistanceSquared(v, c.center);
    }

    // Reversed parameters for checking if a circle contains a point
    public static bool contains(Circle c, Vector2 v)
    {
        return contains(v, c);
    }

    // Check if an axis-aligned rectangle contains a point
    public static bool contains(Vector2 v, AARectangle r)
    {
        float minX = r.topLeft.X;
        float maxX = r.bottomRight.X;
        float minY = r.bottomRight.Y;
        float maxY = r.topLeft.Y;

        return v.X > minX && v.X < maxX && v.Y > minY && v.Y < maxY;
    }

    // Reversed parameters for checking if an axis-aligned rectangle contains a point
    public static bool contains(AARectangle r, Vector2 v)
    {
        return contains(v, r);
    }

    // Check if one circle intersects another
    public static bool intersects(Circle a, Circle b)
    {
        float minDist = a.radius + b.radius;
        return (minDist * minDist) > Vector2.DistanceSquared(a.center, b.center);
    }

    // Check if one axis-aligned rectangle intersects another
    public static bool intersects(AARectangle a, AARectangle b)
    {
        // TODO:
    }

    // Check if a circle intersects an axis-aligned rectangle
    public static bool intersects(Circle c, AARectangle r)
    {
        // todo
    }

    // Reversed parameters for testing Circle/AARectangle intersection
    public static bool intersects(AARectangle r, Circle c)
    {
        return intersects(c, r);
    }
}
