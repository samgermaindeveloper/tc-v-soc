
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Warrior : Person , HurtfulObjectDelegate {

    public Warrior() {
    }

    public int health;

    public Wealth health;

    public Projectile projectile;

    /// <summary>
    /// Must be declared in subclass
    /// </summary>
    public List<Attack> attacks;



    /// <summary>
    /// @param dir 
    /// @return
    /// </summary>
    public void move(void dir) {
        // TODO implement here
        return null;
    }

    /// <summary>
    /// @return
    /// </summary>
    public void jump() {
        // TODO implement here
        return null;
    }

    /// <summary>
    /// @return
    /// </summary>
    public abstract void shoot();

    public void Operation1() {
        // TODO implement here
    }

}