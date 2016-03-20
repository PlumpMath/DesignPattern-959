using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public abstract class NormalActor
    {
        public abstract NormalActor Clone();
    }

    public abstract class FlyActor
    {
        public abstract FlyActor Clone();
    }

    public abstract class WaterActor
    {
        public abstract WaterActor Clone();
    }

    public class NormalActorA : NormalActor
    {
        public override NormalActor Clone()
        {
            return (NormalActor)this.MemberwiseClone();
        }
    }

    public class NormalActorB : NormalActor
    {
        public override NormalActor Clone()
        {
            return (NormalActor)this.MemberwiseClone();
        }

    }

    public class FlyActorA : FlyActor
    {
        public override FlyActor Clone()
        {
            return (FlyActor)this.MemberwiseClone();
        }
    }

    public class FlyActorB : FlyActor
    {
        public override FlyActor Clone()
        {
            return (FlyActor)this.MemberwiseClone();
        }
    }

    public class WaterActorA : WaterActor
    {
        public override WaterActor Clone()
        {
            return (WaterActor)this.MemberwiseClone();
        }
    }

    public class WaterActorB : WaterActor
    {
        public override WaterActor Clone()
        {
            return (WaterActor)this.MemberwiseClone();
        }
    }

    class Prototype
    {

    }

    public class GameSystem
    {
        public  void Run(NormalActor normalActor,FlyActor flyActor,WaterActor waterActor)
        {
            NormalActor normalActor1 = normalActor.Clone();

            NormalActor normalActor2 = normalActor.Clone();

            NormalActor normalActor3 = normalActor.Clone();

            NormalActor normalActor4 = normalActor.Clone();

            NormalActor normalActor5 = normalActor.Clone();

            FlyActor flyActor1 = flyActor.Clone();

            FlyActor flyActor2 = flyActor.Clone();

            WaterActor waterActor1 = waterActor.Clone();

            WaterActor waterActor2 = waterActor.Clone();

        }
    }
}
