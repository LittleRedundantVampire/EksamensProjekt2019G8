using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gruppe8Eksamensprojekt2019
{
	abstract class Level : GameObject
	{
		protected Song levelMusic;
		protected List<GameObject> levelList;
		protected Texture2D background;


		protected abstract void LoadContent(ContentManager content);

		protected abstract void ChangeLevel();

		protected abstract void LevelSetup();
	}
}
