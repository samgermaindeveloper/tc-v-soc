
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Setting : Visual , HurtfulObjectDelegate {

    public Setting() {
    }

    public Img backgroundImage;

    public Boss boss;

    public Obstacle obstacles[];

    public Int width;

    public Int height;

    public Ted ted;



}