
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class HurtfulObject {

    public HurtfulObject() {
    }

    public int damage;

    public Projectile projectile?;

    /// <summary>
    /// The key pressed to activate attack
    /// </summary>
    public char key;

    public Person target;

    public HurtfulObjectDelegate target;

    public Ted ted;

    public HashSet<Warrior> has a list of;


    public void checkIfCollided() {
        // TODO implement here
    }

}