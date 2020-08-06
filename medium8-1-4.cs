using System;

class Player
{
  public string Name { get; private set; }
  public int Age { get; private set; }
  Mover Mover { get; set; }
  Weapon Weapon { get; set; }

  public void Move()
  {
    Mover.DoMove();
  }

  public void Attack()
  {
    if(Weapon.IsReloading()) 
      return;
    Weapon.Attack();
  }
}

class Mover
{
  public float DirectionX { get; private set; }
  public float DirectionY { get; private set; }
  public float Speed { get; private set; }

  public void DoMove()
  {
    // Do move
  }
}

class Weapon
{
  public float Cooldown { get; private set; }
  public int Damage { get; private set; }

  public void Attack()
  {
    //attack
  }
  
  public bool IsReloading()
  {
    throw new NotImplementedException();
  }
}