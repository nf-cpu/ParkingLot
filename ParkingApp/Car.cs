namespace ParkingApp
{
    public class Car
    {
        private string plate;
        private string owner;
        private string color;

        public Car(string plate, string owner , string color)
        {
            this.plate = plate;
            this.owner = owner;
            this.color = color;
        }

        public string GetPlate()
        {
            return plate;
        }

        public void SetPlate(string plate)
        {
            this.plate = plate;
        }

        public string GetOwner()
        {
            return owner;
        }

        public void SetOwner(string owner)
        {
            this.owner = owner;
        }

        public string GetColor()
        {
            return color;
        }

        public void SetColor(string color)
        {
            this.color = color;
        }

    }

}
