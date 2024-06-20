namespace Assignement_7._4
{
    public class ParkingSystem
    {
        private int[] slots; // Index 0: big, Index 1: medium, Index 2: small

        public ParkingSystem(int big, int medium, int small)
        {
            slots = new int[] { big, medium, small };
        }

        public bool AddCar(int carType)
        {
            if (carType >= 1 && carType <= 3 && slots[carType - 1] > 0)
            {
                slots[carType - 1]--;
                return true;
            }
            return false;
        }
    }

    class Program
    {
        static void Main()
        {
            ParkingSystem parkingSystem = new ParkingSystem(1, 1, 0);
            Console.WriteLine(parkingSystem.AddCar(1)); // Output: True
            Console.WriteLine(parkingSystem.AddCar(2)); // Output: True
            Console.WriteLine(parkingSystem.AddCar(3)); // Output: False
            Console.WriteLine(parkingSystem.AddCar(1)); // Output: False
        }
    }
}