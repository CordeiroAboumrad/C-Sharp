using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Services
{
    interface ITaxService
    {
        double Tax(double amount);
    }
}
