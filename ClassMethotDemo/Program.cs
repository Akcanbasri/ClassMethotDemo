﻿using ClassMethotDemo;


Customer Custumer1 = new Customer();
Custumer1.SetId(1);
Custumer1.Name = "Hasan Basri";
Custumer1.Surname = "Akcan";
Custumer1.OpenDate = "01.01.2015";
Custumer1.Wealth = 100000;
Custumer1.Email = "akcanhasanbasri@gmail.com";
Custumer1.GetId();
Custumer1.ShowCustomer();

Customer Custumer2 = new Customer();
Custumer2.SetId(2);
Custumer2.Name = "Mustafa";
Custumer2.Surname = "Saban";
Custumer2.OpenDate = "01.11.2016";
Custumer2.Wealth = 1000;
Custumer2.Email = "Mustafasaban@hotmail.com";
Custumer2.GetId();
Custumer2.ShowCustomer();

Customer Custumer3 = new Customer();
Custumer3.SetId(3);
Custumer3.Name = "Mukadder";
Custumer3.Surname = "Akcan";
Custumer3.OpenDate = "9.01.2015";
Custumer3.Wealth = 10000000000;
Custumer3.Email = "Muakaaderakcan@outlock.com";
Custumer3.GetId();
Custumer3.ShowCustomer();

Custumer1.AddCustomer(Custumer1);
Custumer2.AddCustomer(Custumer2);
Custumer3.AddCustomer(Custumer3);
Custumer1.DeleteCustomer(Custumer1);