using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var map = new Map(width:5, height: 5);
            var dynamicMap = new MapDynamic(width: 5, height: 5);
            var player = new Player(hp:5);
            var enemy = new Enemy();

            var moveableObjects = new List<IMoveable> { player, enemy };

            var movementController = new MovementController(moveableObjects, dynamicMap);

            var damageController = new DamageController(moveableObjects.Select(m=>m as IHavePosition).ToList(), player);

            var updatableObjects = new List<IUpdatable> { movementController, damageController, dynamicMap };

            var updatableController = new Updatable(updatableObjects);

            while (player.Alive)
            {
                updatableController.Update();
            }
        }
    }
}
