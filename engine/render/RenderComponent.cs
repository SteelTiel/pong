using Microsoft.Xna.Framework.Graphics;

namespace engine.render;

public interface RenderComponent
{
    public Texture2D glance(double elapsedTime);
}
