using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public abstract class Tank
    {
        protected TankPlatformImplementation tankImp;

        public Tank(TankPlatformImplementation tankImp)
        {
            this.tankImp = tankImp;
        }

        public TankPlatformImplementation TankImp
        {
            get
            {
                return this.tankImp;
            }
            set
            {
                this.tankImp = value;
            }
        }


        public abstract void Shot();
        public abstract void Run();
        public abstract void Stop();
    }

    public abstract class TankPlatformImplementation
    {
        public abstract void MoveTankTo(Point to);

        public abstract void DrawTank();

        public abstract void DoShot();
    }

    public class PCTankPlatformImplementation:TankPlatformImplementation
    {
        public override void MoveTankTo(Point to)
        { }

        public override void DrawTank()
        { }

        public override void DoShot()
        { }
    }

    public class MobileTankPlatformImplementation : TankPlatformImplementation
    {
        public override void MoveTankTo(Point to)
        { }

        public override void DrawTank()
        { }

        public override void DoShot()
        { }
    }

    public class T50 : Tank
    {
        public T50(TankPlatformImplementation tankImpl) : base(tankImpl)
        {

        }
        public override void Shot()
        {
            tankImp.DoShot();
        }

        public override void Run()
        {
            throw new NotImplementedException();
        }

        public override void Stop()
        {
            throw new NotImplementedException();
        }
    }

    public class T75 : Tank
    {
        public T75(TankPlatformImplementation tankImpl) : base(tankImpl)
        {

        }
        public override void Shot()
        {
            tankImp.DoShot();
        }

        public override void Run()
        {
            throw new NotImplementedException();
        }

        public override void Stop()
        {
            throw new NotImplementedException();
        }
    }

    public class T90 : Tank
    {
        public T90(TankPlatformImplementation tankImpl) : base(tankImpl)
        {

        }
        public override void Shot()
        {
            tankImp.DoShot();
        }

        public override void Run()
        {
            throw new NotImplementedException();
        }

        public override void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
