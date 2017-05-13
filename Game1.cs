using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
namespace MoodLight2
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
   public class Game1 : Game
   {
      GraphicsDeviceManager graphics;
      SpriteBatch spriteBatch;
      byte redIntensity;
      byte greenIntensity;
      byte blueIntensity;
      bool redcountingUp = true;
      bool greencountingUp = true;
      bool bluecountingUp = true;
      Texture2D texture1, texture2;
      Rectangle textureRect, texture2Rect;
      public Game1()
      {
         graphics = new GraphicsDeviceManager(this);
         Content.RootDirectory = "Content";
         redIntensity = 50;
         greenIntensity = 180;
         blueIntensity = 210;

      }

      /// <summary>
      /// Allows the game to perform any initialization it needs to before starting to run.
      /// This is where it can query for any required services and load any non-graphic
      /// related content.  Calling base.Initialize will enumerate through any components
      /// and initialize them as well.
      /// </summary>
      protected override void Initialize()
      {
         // TODO: Add your initialization logic here

         textureRect = new Rectangle(30, 20, 200, 300);
         texture2Rect = new Rectangle(400, 500, 400, 500);
         base.Initialize();
      }

      /// <summary>
      /// LoadContent will be called once per game and is the place to load
      /// all of your content.
      /// </summary>
      protected override void LoadContent()
      {
         // Create a new SpriteBatch, which can be used to draw textures.
         spriteBatch = new SpriteBatch(GraphicsDevice);
         //The statementloads the texture content 
         texture1 = this.Content.Load<Texture2D>("mickey");
         texture2 = this.Content.Load<Texture2D>("dog");
         // TODO: use this.Content to load your game content here
      }

      /// <summary>
      /// UnloadContent will be called once per game and is the place to unload
      /// game-specific content.
      /// </summary>
      protected override void UnloadContent()
      {
         // TODO: Unload any non ContentManager content here
      }

      /// <summary>
      /// Allows the game to run logic such as updating the world,
      /// checking for collisions, gathering input, and playing audio.
      /// </summary>
      /// <param name="gameTime">Provides a snapshot of timing values.</param>
      protected override void Update(GameTime gameTime)
      {
         if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))

            GamePad.SetVibration(PlayerIndex.One, 0, 0);
         ;
         GamePadState pad1 = GamePad.GetState(PlayerIndex.One);
         KeyboardState keys = Keyboard.GetState();
         if (pad1.Buttons.B == ButtonState.Pressed || keys.IsKeyDown(Keys.R)) redIntensity++;
         if (pad1.Buttons.X == ButtonState.Pressed || keys.IsKeyDown(Keys.B)) blueIntensity++;
         if (pad1.Buttons.A == ButtonState.Pressed || keys.IsKeyDown(Keys.G)) greenIntensity++;
         if (pad1.Buttons.Y == ButtonState.Pressed || keys.IsKeyDown(Keys.Y))
         {
            redIntensity++;
            greenIntensity++;
         }

         if (redIntensity > 200 || greenIntensity > 200 || blueIntensity > 200)
         {
            GamePad.SetVibration(PlayerIndex.One, 0, 1);
         }
         else
         {
            GamePad.SetVibration(PlayerIndex.One, 0, 0);
         }


         //make each color brighter
         /*  if (redIntensity==255) redcountingUp=false;
           if (redIntensity == 0) redcountingUp = true;
           if (redcountingUp) redIntensity++; else redIntensity--;

           if (greenIntensity == 255) greencountingUp = false;
           if (greenIntensity == 0) greencountingUp = true;
           if (greencountingUp) greenIntensity++; else greenIntensity--;

           if (blueIntensity == 255) bluecountingUp = false;
           if (blueIntensity == 0) bluecountingUp = true;
           if (bluecountingUp) blueIntensity++; else blueIntensity--;*/
         // TODO: Add your update logic here

         base.Update(gameTime);
      }

      /// <summary>
      /// This is called when the game should draw itself.
      /// </summary>
      /// <param name="gameTime">Provides a snapshot of timing values.</param>
      protected override void Draw(GameTime gameTime)
      {
         Color Backgroundcolor;
         Backgroundcolor = new Color(redIntensity, greenIntensity, blueIntensity);
         GraphicsDevice.Clear(Backgroundcolor);
         spriteBatch.Begin();
         spriteBatch.Draw(texture1, textureRect, Color.White);
         spriteBatch.Draw(texture2, texture2Rect, Color.White);
         spriteBatch.End();

         // TODO: Add your drawing code here

         base.Draw(gameTime);
      }
   }
}
