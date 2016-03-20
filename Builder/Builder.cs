using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{

    public abstract class Door
    { }

    public abstract class Wall
    { }

    public abstract class Windwos
    { }

    public abstract class Floor
    { }

    public abstract class HouseCeiling
    { }
    public abstract class House
    {

    }

    public abstract class Builder
    {
        public abstract void BuildDoor();
        public abstract void BuildWall();
        public abstract void BuildWindows();

        public abstract void BuildFloor();
        public abstract void BuildHouseCeiling();

        public abstract House GetHouse();
    }
}
