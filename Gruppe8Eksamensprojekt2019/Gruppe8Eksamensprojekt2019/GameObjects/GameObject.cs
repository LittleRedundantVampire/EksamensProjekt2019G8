using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gruppe8Eksamensprojekt2019
{
    abstract class GameObject
    {
        private Rectangle collisionBox;

        protected Texture2D sprite;
        protected byte currentIndex;
        protected float fps;
        protected Vector2 position;
        protected Vector2 velocity;
        protected int speed;
        protected bool hasShadow;

        public bool HasShadow
        {
            get { return hasShadow;  }
        }

        public Rectangle CollisionBox
        {
            get { return collisionBox; }
        }


        protected virtual void Draw(SpriteBatch spriteBatch)
        {

        }

        protected abstract void Update(GameTime gameTime);

        protected abstract void Load(ContentManager Content);

        protected virtual void CheckCollision(GameObject gameObject)
        {

        }

        protected virtual void OnCollision(GameObject other)
        {

        }

        protected virtual void Move()
        {

        }

    }
}
