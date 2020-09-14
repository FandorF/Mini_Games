using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace Mini_Games.Game
{
    class MovementController : IUpdatable
    {
        private readonly IMap _map;
        private Random _rnd = new Random();
        private List<IHavePosition> _havePositionObject = new List<IHavePosition>();
      
        private Vector2[] _possibleMovements =
        {
                new Vector2(0,1),
                new Vector2(0,-1),
                new Vector2(1,0),
                new Vector2(-1,0)
        };

        public MovementController( IMap map, params IHavePosition[] havePositionObject)
        {
            _map = map;
            _havePositionObject.AddRange(havePositionObject);
        }
        public void GetPosition(List<IHavePosition> havePositions)
        {
           
        }

        public void Update()
        {
             
            foreach(var havePos in _havePositionObject)
            {
              var currentPos = havePos.Position;
              var randomMovemnts = _possibleMovements[_rnd.Next(0,_possibleMovements.Length)];
              if(randomMovemnts.X <= _map.Width && randomMovemnts.X >= 0 && randomMovemnts.Y <= _map.Height && randomMovemnts.Y >= 0)   
              havePos.SetPosition(randomMovemnts); 
            }
                
            
        }
    }
}
