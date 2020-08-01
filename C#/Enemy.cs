
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Enemy : Warrior {

    public Enemy() {
    }

    public List<Attack> attacks;

    public void hurtfulObjectDelegate;

}