
using HRManagementSystem.Services.Interfaces;

namespace HRManagementSystem.Services.Implementation
{
    public class CircleService : ICircleService
    {
        public double CalculateArea(double radius)
        {
            return Math.PI * radius * radius;
        }
        
    }
}
