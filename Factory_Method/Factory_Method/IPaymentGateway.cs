﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IPaymentGateway
{
    void ProcessPayment(double amount);
}

