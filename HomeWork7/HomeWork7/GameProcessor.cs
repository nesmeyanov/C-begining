using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    class GameProcessor
    {
        private List<Car> cars = new List<Car>();

        delegate void DelStart(int distance);

        delegate int DelContinue();

        delegate int DelStop(int stop);

        DelStop delStop;
        DelContinue delContinue;
        DelStart delStart;

        public void PrepareCar()
        {
            Random random = new Random();
            
            for (int i = 0; i < 10; i++)
            {
                int rn = random.Next(1, 4);
                switch (rn)
                {
                    case 1:
                        cars.Add(new Bus());
                        break;
                    case 2:
                        cars.Add(new Truck());
                        break;
                    case 3:
                        cars.Add(new SportCar());
                        break;
                    case 4:
                        cars.Add(new Vehicle());
                        break;
                }
            }

            foreach(var car in cars)
            {
                delStart += car.Start;
                car.Finish += Car_Finish;
            }
        }

        private void Car_Finish(object sender, string e)
        {
            Console.WriteLine(e);
            Car car = (Car)sender;
            delContinue -= car.Move;

        }

        public void Start(int distance)
        {
            foreach (var car in cars)
            {
                delContinue += car.Move;
            }
            delStart.Invoke(distance);
            while (delContinue !=null)
            {
                delContinue.Invoke();
            }
        }

        public void Resault()
        {
           // List result;
           //foreach(var car in cars)
           // {
           //     result.Add(car.Name + car.Distance);
           // }
           // result.Sort(by Distance);
           // Console.WriteLine(result);
        }
    }
}
