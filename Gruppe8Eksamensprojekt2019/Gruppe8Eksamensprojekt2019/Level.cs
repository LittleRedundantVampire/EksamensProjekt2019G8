using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gruppe8Eksamensprojekt2019
{
	abstract class Level
	{
		protected Song levelMusic;
		protected List<GameObject> levelList;
		protected Texture2D background;


		public abstract void LoadConContent();
		public abstract void ChangeLevel();
		public abstract void LevelSetup();
	}
}
