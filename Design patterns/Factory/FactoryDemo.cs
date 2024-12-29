using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.Factory
{
    internal class FactoryDemo
    {
        #region Product 
        public interface IVehicle
        { 
            void GetVehicleType();
        }
        #endregion

        #region Concrete Products
        public class TwoWheeler : IVehicle
        {
            public void GetVehicleType()
            {
                Console.WriteLine("Two wheeler");
            }
        }

        public class FourWheeler : IVehicle
        {
            public void GetVehicleType()
            {
                Console.WriteLine("Four wheeler");
            }
        }
        #endregion

        #region Creator
        public interface IVehicleFactory
        {
             IVehicle CreateVehicle();
        }
        #endregion

        #region Concrete Products
        public class TwoWheelerFactory : IVehicleFactory
        {
            public IVehicle CreateVehicle()
            {
                return new TwoWheeler();    
            }
        }
        public class FourWheelerFactory : IVehicleFactory
        {
            public IVehicle CreateVehicle()
            {
                return new FourWheeler();
            }
        }
        #endregion

        public class Client()
        {
            public static IVehicle GetVehicle(IVehicleFactory vehicleFactory) => vehicleFactory.CreateVehicle();
        }

        public static void Main()
        {
            IVehicleFactory twoWheelerFactory = new TwoWheelerFactory();
            IVehicle twoWheeler = Client.GetVehicle(twoWheelerFactory);
            twoWheeler.GetVehicleType();

            IVehicleFactory fourWheelerFactory = new FourWheelerFactory();
            IVehicle fourWheeler = Client.GetVehicle(fourWheelerFactory);
            fourWheeler.GetVehicleType();
        }
    }
}
