using System;
using System.Collections.Generic;
using System.Text;

namespace Mini_Games.Game
{
    class DamageController : IUpdatable
    {
        private List<IHavePosition> _iHavePosition = new List<IHavePosition>();
        public DamageController(params IHavePosition[] havePositions)
        {
            _iHavePosition.AddRange(havePositions);
        }

        public void Update()
        {
          
        }

        //public void RandomDamage()
        //{
        //    Random rnd = new Random();

        //    for(int i = 0; i < _aliveEntity.Count; i++)
        //    {
        //        int rndDamage = rnd.Next(1,7);
        //        _aliveEntity[i].Hp -= rndDamage;//need rnd
        //    }
        //}

        //public void Update()
        //{
        //    RandomDamage();
        //}
    }
}
