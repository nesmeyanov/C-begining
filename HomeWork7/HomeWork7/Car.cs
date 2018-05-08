using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    abstract class Car

    {
        public event EventHandler<string> Finish;

        public int MaxSpeed { get; set; }

        public int CurrentSpeed { get; set; }

        public int Acceleration { get; set; }

        public int Distance { get; set; }
        public string Name { get; set; }

        private int _totalMoves;

        public void Start(int totalDistance)
        {
            CurrentSpeed = Acceleration;
            Distance = 0;
            TotalDistance = totalDistance;
            _totalMoves = 0;
        }

        public int TotalDistance { get; set; }

        public int Stop()
        {
            Acceleration = 0;
            CurrentSpeed = 0;
            Finish.Invoke(this, $"{Name} drivig: {Distance} miles by {_totalMoves} moves");
            return Distance;
        }

        public int SpeedUp()
        {
            CurrentSpeed += Acceleration;
            return CurrentSpeed;
        }

        public int SpeedDown()
        {
            CurrentSpeed -= Acceleration;
            return CurrentSpeed;
        }

        public int Move()
        {
            _totalMoves++;
            Distance += CurrentSpeed;
            if (TotalDistance <= Distance)
            {
                Stop();
            }
            return Distance;
        }
    }
}
