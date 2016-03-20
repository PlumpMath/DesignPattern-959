using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**************************************************************/
/* Author:LiChao
/* Date:2016/03/01
/* Description:AbstractFactory Pattern
/* Target:抽象工厂想要解决的问题是，就像一个游戏场景，假如游戏场景中的各种景物已经固定，
          但是风格在不断的变化（对象结构稳定，风格不断变化），如果游戏场景风格不变，而
          各种景物在不断的变化，那抽象工厂就反而不适用了                                       
/**************************************************************/

namespace AbstractFactory
{
    #region 抽象工厂和抽象方法的定义
    public abstract class AbstractFactory
    {
        public abstract Road CreateRoad();

        public abstract Building CreateBuilding();

        public abstract Tunnel CreateTunnel();

        public abstract Jungle CreateJungle();
    }

    //道路
    public abstract class Road
    {

    }

    //建筑
    public abstract class Building
    {

    }

    //地道
    public abstract class Tunnel
    {

    }

    //丛林
    public abstract class Jungle
    {

    }
    #endregion

    #region 抽象类和抽象工厂多态情况的一种实现(具体工厂)
    public class ModelAbstractFactory:AbstractFactory
    {
        public override Road CreateRoad()
        {
            return new ModelRoad();
        }

        public override Building CreateBuilding()
        {
            return new ModelBuilding();
        }

        public override Tunnel CreateTunnel()
        {
            return new ModelTunnel();
        }

        public override Jungle CreateJungle()
        {
            return new ModelJungle();
        }
    }

    //道路
    public class ModelRoad:Road
    {

    }

    //建筑
    public class ModelBuilding:Building
    {

    }

    //地道
    public class ModelTunnel:Tunnel
    {

    }

    //丛林
    public class ModelJungle:Jungle
    {

    }
    #endregion

    //客户程序
    class GameManager
    {
        AbstractFactory abstractFactory;

        Road road;

        Building building;

        Tunnel tunnel;

        Jungle jungle;


        public GameManager(AbstractFactory abstractFactory)
        {
            this.abstractFactory = abstractFactory;
        }

        public void BuildGameFacilities()
        {
            road = abstractFactory.CreateRoad();
            building = abstractFactory.CreateBuilding();
            tunnel = abstractFactory.CreateTunnel();
            jungle = abstractFactory.CreateJungle();
        }

        public void Run()
        {

        }
    }

    class App
    {

        public static void Main()
        {
            GameManager g = new GameManager(new ModelAbstractFactory());

            g.BuildGameFacilities();
            g.Run();
        }
    }
}
