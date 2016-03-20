using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class GameManager
    {
        public static House CreateHouse(Builder builder)
        {
            builder.BuildDoor();
            builder.BuildDoor();

            builder.BuildWall();
            builder.BuildWall();
            builder.BuildWall();
            builder.BuildWall();

            builder.BuildWindows();
            builder.BuildWindows();
        }
    }
}
