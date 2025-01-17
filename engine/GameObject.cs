using System;
using engine.actor;
using engine.physics;
using engine.render;
using Microsoft.Xna.Framework;

namespace engine;

public class GameObject
{
    // Components

    private PhysicsComponent physicsComponent;
    private RenderComponent renderComponent;
    private ActorComponent actorComponent;

/*
    // Component Delegates
    
    private Func<Vector2> requestPosition = () => new Vector2(0.0f, 0.0f);
    private Func<Vector2> requestDimensions = () => new Vector2(0.0f, 0.0f);

    // Factory Methods

    public void addPhysicsComponent(PhysicsComponent component) {
        // TODO: add physics component and remap delegates
    }

    // Mock Functions (to disguise delegates)

    public Vector2 position {
        get => this.requestPosition();
    }

    public Vector2 getPosition() { return this.requestPosition(); }
    public Vector2 getDimensions() { return this.requestDimensions(); }
*/
}
