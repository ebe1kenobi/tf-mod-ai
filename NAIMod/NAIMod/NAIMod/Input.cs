using TowerFall;

namespace NAIMod
{
  public class Input : KeyboardInput
  {
    public InputState prevInputState;
    public InputState inputState;

    public Input(int index) : base()
    {
      this.Config = KeyboardConfigs.Configs[index];
      InitIcons();
    }

    public Input(KeyboardConfig config, int id) : base(config, id) {}
    public InputState GetCopy(InputState inputState)
    {
      return new InputState
      {
        AimAxis = inputState.AimAxis,
        ArrowsPressed = inputState.ArrowsPressed,
        DodgeCheck = inputState.DodgeCheck,
        DodgePressed = inputState.DodgePressed,
        JumpCheck = inputState.JumpCheck,
        JumpPressed = inputState.JumpPressed,
        MoveX = inputState.MoveX,
        MoveY = inputState.MoveY,
        ShootCheck = inputState.ShootCheck,
        ShootPressed = inputState.ShootPressed
      };
    }

    public override InputState GetState()
    {
      this.prevInputState = GetCopy(this.inputState);
      return GetCopy(this.prevInputState);
    }
  }
}
