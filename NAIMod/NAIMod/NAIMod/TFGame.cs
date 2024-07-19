using System;
using Microsoft.Xna.Framework;
using Patcher;
using TowerFall;

namespace TowerfallAi.Mod {
  [Patch]
  public class ModTFGame : TFGame {

    Action originalInitialize;
    Action<GameTime> originalUpdate;

    [STAThread]
    public static void Main(string[] args) {
      try {
        NAIMod.NAIMod.ParseArgs(args);
        typeof(TFGame).GetMethod("$original_Main").Invoke(null, new object[] { args });
      } catch (Exception exception) {
        TFGame.Log(exception, false);
        TFGame.OpenLog();
      }
    }

    public ModTFGame(bool noIntro) : base(noIntro) {
      var ptr = typeof(TFGame).GetMethod("$original_Initialize").MethodHandle.GetFunctionPointer();
      originalInitialize = (Action)Activator.CreateInstance(typeof(Action), this, ptr);

      ptr = typeof(TFGame).GetMethod("$original_Update").MethodHandle.GetFunctionPointer();
      originalUpdate = (Action<GameTime>)Activator.CreateInstance(typeof(Action<GameTime>), this, ptr);

    }

    public override void Initialize() {
      originalInitialize();
    }

    public override void Update(GameTime gameTime) {

      if (NAIMod.NAIMod.NAIModEnabled)
      {
        NAIMod.NAIMod.gameTime = gameTime;
        NAIMod.NAIMod.Update(originalUpdate);
        return;
      }

      originalUpdate(gameTime);
    }
  }
}
