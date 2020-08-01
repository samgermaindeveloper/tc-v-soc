
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Person : Visual , HurtfulObjectDelegate {

    public Person() {
    }

    public void observerOnHealth;

    public Wealth readOnly health;

    public Image img;

    public World world;

    public boolean oneHit;

    public void Attribute1;

    public Int speed;

    public Motion collapse;

    public Int currentState;



    /// <summary>
    /// @return
    /// </summary>
    public void collapse() {
        // TODO implement here
        return null;
    }

    /// <summary>
    /// @param fromAttack 
    /// @return
    /// </summary>
    public void takeDamage(void fromAttack) {
        // TODO implement here
        return null;
    }

}