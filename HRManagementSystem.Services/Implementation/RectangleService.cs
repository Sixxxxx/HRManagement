﻿
using HRManagementSystem.Services.Interfaces;

namespace HRManagementSystem.Services.Implementation
{
    public class RectangleService : IRectangleService
    {
        public double CalculateArea(double basee, double height)
        {
            return basee * height;
        }
    }
}
