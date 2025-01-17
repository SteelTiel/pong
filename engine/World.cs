using System;
using System.Collections.Generic;
using System.Linq;
using engine.physics;
using engine.render;
using Microsoft.Xna.Framework.Graphics;

namespace engine;

class World
{
    private List<GameObject> gameObjects;

    private int activePhysicsCptIndex;
    private List<PhysicsComponent> physicsComponents;

    private int activeRenderCptIndex;
    private List<RenderComponent> renderComponents;

    private Dictionary<String, Texture2D> texture2Ds;

    private Texture2D requestTexture(String name)
    {
        // TODO: load and return single texture object
        return null;
    }

    public World()
    {
        // TODO: init lists
    }

    public GameObject createObject()
    {
        return new GameObject();
    }

    public GameObject createObject(String textureName) {
        GameObject obj = new GameObject();

        Texture2D texture = requestTexture(textureName);
        renderComponents.Append<RenderComponent>(new RenderComponent(texture));

        return obj;
    }

    public void render(double elapsedTime)
    {
        // TODO: loop over active render components and call their glance functions
    }
}
