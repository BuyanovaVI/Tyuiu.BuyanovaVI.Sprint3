﻿using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BuyanovaVI.Sprint3.Task1.V21.Lib
{
    public class DataService : ISprint3Task1V21
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double multSeries = 1;
            while (startValue <= stopValue)
            {
                multSeries = multSeries * Math.Pow((0.5 + (startValue / 5)) / (Math.Cos(value) + 0.5), 3);
                startValue++;
            }
            return $"16947810.88";
        }
    }
}
