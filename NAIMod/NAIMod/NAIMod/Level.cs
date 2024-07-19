using System;
using System.Xml;
using Monocle;
using Patcher;
using TowerFall;

namespace TowerfallAi.Mod {
  [Patch]
  public class ModLevel : Level {
    Action originalUpdate;

    Action originalHandlePausing;

    private int nbUpdate = 0;

    public ModLevel(Session session, XmlElement xml) : base(session, xml) {

      if (NAIMod.NAIMod.NAIModEnabled)
      {
        NAIMod.NAIMod.SetAgentLevel(this);
      }

      var ptr = typeof(Level).GetMethod("$original_Update").MethodHandle.GetFunctionPointer();
      originalUpdate = (Action)Activator.CreateInstance(typeof(Action), this, ptr);

      ptr = typeof(Level).GetMethod("$original_HandlePausing").MethodHandle.GetFunctionPointer();
      originalHandlePausing = (Action)Activator.CreateInstance(typeof(Action), this, ptr);
    }

    public override void HandlePausing() {
      originalHandlePausing();
    }

    public override void Update() {
      nbUpdate++;

      if (NAIMod.NAIMod.NAIModEnabled)
      {
        NAIMod.NAIMod.AgentUpdate(this);
      }

      originalUpdate();
    }
  }
}
