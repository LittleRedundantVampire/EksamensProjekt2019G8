using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Gruppe8Eksamensprojekt2019
{
	class LevelOne : Level
	{
        public LevelOne()
        {
            GenerateLevel(new int[,]
            {

                {1,1,1,1,1,1,1,1,1},
                {1,0,0,0,1,0,0,0,1},
                {1,0,0,0,0,0,0,0,1},
                {1,0,0,0,0,0,0,0,1},
                {1,0,0,0,1,0,0,0,1},
                {1,1,1,1,1,1,0,1,1},

            }, 32);
        }

        public override void LoadContent(ContentManager content)
        {
            
        }

        protected override void Update(GameTime gameTime)
        {
           
        }

        protected override void ChangeLevel()
		{
		}

		protected override void LevelSetup()
		{
		}
	}
}
