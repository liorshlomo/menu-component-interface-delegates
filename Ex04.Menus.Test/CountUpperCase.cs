﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class CountUpperCase : IActionMethods
    {
        public void ActivateMethod()
        {
            UsersMethods actionMethods = new UsersMethods();
            actionMethods.CountUpperCase();
        }
    }
}
