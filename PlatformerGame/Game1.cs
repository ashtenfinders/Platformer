

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PlatformerGame.Entities;
using PlatformerGame.Objects;
using PlatformerGame.Environment;
using PlatformerGame.Services;

namespace PlatformerGame
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Player _player;
        private Platform _platform;
        public static int screenWidth;
        public static int screenHeight;
        private Texture2D pixel;
        private Level level;

        private Camera camera;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            

        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _graphics.PreferredBackBufferWidth = 1920;
            _graphics.PreferredBackBufferHeight = 1080;
            _graphics.ApplyChanges();
            screenWidth = GraphicsDevice.Viewport.Width;
            screenHeight = GraphicsDevice.Viewport.Height;
            _player = new Player(new Vector2(0,0));
            _platform = new Platform();
            camera = new Camera(this);
            level = new Level(Tilemap.CreateTilemap());
            var input = new InputManager(this, _player);
            var collision = new CollisionManager(this, _player, _platform);
            
            Components.Add(input);
            Components.Add(collision);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            var layer = new LayerManager(this, _spriteBatch);
            var background = new BackgroundLayer();


            pixel = new Texture2D(GraphicsDevice, 1, 1);
            pixel.SetData(new[] { Color.White }); // white pixel
            _player.Texture = pixel;

            background.Texture = pixel;
            layer.AddLayer(background);
            Components.Add(layer);







            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            _player.CollisionBox = new Rectangle((int)_player.Position.X, (int)_player.Position.Y, 50, 100);
            Debug.WriteLine(_player.Position.X);


            
            camera.Position = _player.Position;

            

            // TODO: Add your update logic here
            


            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin(transformMatrix: camera.GetTranslationMatrix());
            //_spriteBatch.Draw(pixel, _platform.CollisionBox, Color.Black);
            //Try out the basic tile map
            for (int i =0; i < 128; i ++)
            {
                var tile = level.Tilemap.GetTile(i, 58);
                _spriteBatch.Draw(pixel, tile.BoundingBox, Color.Black);
            }
            _spriteBatch.Draw(_player.Texture, _player.CollisionBox,  Color.White);
            _spriteBatch.End();
            
            base.Draw(gameTime);
        }
    }
}
