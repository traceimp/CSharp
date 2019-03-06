using System;

namespace AccessModifier
{
    class WaterHeater
    {
        protected int temperature;

        // SetTemperature()는 -5~42 사이의 값만 받아들이고, 이 범위를 벗어난 값에 대해서는 예외를 발생시킨다.
        public void SetTemperature(int temperature)
        {
            if(temperature < -5 || temperature > 42)
            {
                throw new Exception("Out of temperature range");
            }                                                       

            this.temperature = temperature; // temperature 필드는 protected로 수식되었으므로 외부에서 직접 접근할 수 없습니다.
        }                                   // 이렇게 public 메소드를 통해 접근해야 합니다.

        internal void TurnOnWater()
        {
            Console.WriteLine($"Turn on warter : {temperature}");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                WaterHeater heater = new WaterHeater();
                heater.SetTemperature(20);
                heater.TurnOnWater();

                heater.SetTemperature(-2);
                heater.TurnOnWater();

                heater.SetTemperature(50);  // 예외 발생! catch 블록으로 실행 위치가 이동
                heater.TurnOnWater();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
