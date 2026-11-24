using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp.Tests
{
    public class CarTests
    {
        [Fact]
        public void Car_GetColor_ReturnsCorrectColor()
        {
            // יצירת רכב עם צבע "אדום" (הפרמטרים תלויים בבנאי שלך, למשל מספר רישוי, בעלים וצבע)
            var car = new Car("123-45-678", "Owner", "red");

            // בדיקה שהמתודה מחזירה את הצבע המצופה
            Assert.Equal("red", car.GetColor());
        }
    }
}
