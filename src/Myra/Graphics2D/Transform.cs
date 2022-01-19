using Microsoft.Xna.Framework;

namespace Myra.Graphics2D
{
	public class Transform
	{
		public Vector2 Position { get; set; }

		public Vector2 Apply(Vector2 source)
		{
			return source + Position;
		}

		public Rectangle Apply(Rectangle source)
		{
			return new Rectangle(source.X + (int)Position.X,
				source.Y + (int)Position.Y,
				source.Width,
				source.Height);
		}
	}
}
