using Microsoft.Xna.Framework.Input;
using TowerFall;

namespace NAIMod {
  public static class KeyboardConfigs {

    public static KeyboardConfig[] Configs = new KeyboardConfig[8]; 

    static KeyboardConfigs() {
      for (int i = 0; i < Configs.Length; i++) {
        /* Towerfall defauly
        KeyboardConfig keyboardConfig = new KeyboardConfig();
        keyboardConfig.Left = new Keys[1] { Keys.Left };
        keyboardConfig.Right = new Keys[1] { Keys.Right };
        keyboardConfig.Up = new Keys[1] { Keys.Up };
        keyboardConfig.Down = new Keys[1] { Keys.Down };
        keyboardConfig.Jump = new Keys[1] { Keys.C };
        keyboardConfig.Shoot = new Keys[1] { Keys.X };
        keyboardConfig.AltShoot = new Keys[1] { Keys.Z };
        keyboardConfig.Dodge = new Keys[1] { Keys.LeftShift };
        keyboardConfig.Arrows = new Keys[1] { Keys.S };
        keyboardConfig.MenuAlt = new Keys[1] { Keys.Tab };
        keyboardConfig.Start = new Keys[1] { Keys.Enter };
        */
        Configs[i] = KeyboardConfig.GetDefault();
      }

      int j = 0;
      Configs[j].Down = new Keys[] { Keys.A };
      Configs[j].Up = new Keys[] { Keys.Z };
      Configs[j].Left = new Keys[] { Keys.E };
      Configs[j].Right = new Keys[] { Keys.R };
      Configs[j].Jump = new Keys[] { Keys.NumPad1 }; 
      Configs[j].Shoot = new Keys[] { Keys.F1 };
      Configs[j].Dodge = new Keys[] { Keys.T };

      j++;
      Configs[j].Down = new Keys[] { Keys.Q };
      Configs[j].Up = new Keys[] { Keys.S };
      Configs[j].Left = new Keys[] { Keys.D };
      Configs[j].Right = new Keys[] { Keys.F };
      Configs[j].Jump = new Keys[] { Keys.NumPad2 };
      Configs[j].Shoot = new Keys[] { Keys.F2 }; 
      Configs[j].Dodge = new Keys[] { Keys.G };

      j++;
      Configs[j].Down = new Keys[] { Keys.W };
      Configs[j].Up = new Keys[] { Keys.X };
      Configs[j].Left = new Keys[] { Keys.C };
      Configs[j].Right = new Keys[] { Keys.V };
      Configs[j].Jump = new Keys[] { Keys.NumPad3 };
      Configs[j].Shoot = new Keys[] { Keys.F3 };
      Configs[j].Dodge = new Keys[] { Keys.B };

      j++;
      Configs[j].Down = new Keys[] { Keys.Y };
      Configs[j].Up = new Keys[] { Keys.U };
      Configs[j].Left = new Keys[] { Keys.I };
      Configs[j].Right = new Keys[] { Keys.O };
      Configs[j].Jump = new Keys[] { Keys.NumPad4 };
      Configs[j].Shoot = new Keys[] { Keys.F4 };
      Configs[j].Dodge = new Keys[] { Keys.P };

      j++;
      Configs[j].Down = new Keys[] { Keys.H };
      Configs[j].Up = new Keys[] { Keys.J };
      Configs[j].Left = new Keys[] { Keys.K };
      Configs[j].Right = new Keys[] { Keys.L };
      Configs[j].Jump = new Keys[] { Keys.NumPad5 }; 
      Configs[j].Shoot = new Keys[] { Keys.F5 };
      Configs[j].Dodge = new Keys[] { Keys.M };

      j++;
      Configs[j].Down = new Keys[] { Keys.F9 };
      Configs[j].Up = new Keys[] { Keys.F10 };
      Configs[j].Left = new Keys[] { Keys.F11 };
      Configs[j].Right = new Keys[] { Keys.F12 };
      Configs[j].Jump = new Keys[] { Keys.NumPad6 };
      Configs[j].Shoot = new Keys[] { Keys.F6 };
      Configs[j].Dodge = new Keys[] { Keys.N };

      j++;
      Configs[j].Down = new Keys[] { Keys.Down };
      Configs[j].Up = new Keys[] { Keys.Up };
      Configs[j].Left = new Keys[] { Keys.Left };
      Configs[j].Right = new Keys[] { Keys.Right };
      Configs[j].Jump = new Keys[] { Keys.NumPad7 };
      Configs[j].Shoot = new Keys[] { Keys.F7 };
      Configs[j].Dodge = new Keys[] { Keys.LeftControl };

      j++;
      Configs[j].Down = new Keys[] { Keys.RightShift };
      Configs[j].Up = new Keys[] { Keys.RightAlt };
      Configs[j].Left = new Keys[] { Keys.RightControl };
      Configs[j].Right = new Keys[] { Keys.Enter };
      Configs[j].Jump = new Keys[] { Keys.NumPad8 };
      Configs[j].Shoot = new Keys[] { Keys.F8 };
      Configs[j].Dodge = new Keys[] { Keys.LeftWindows };
    }
  }
}
