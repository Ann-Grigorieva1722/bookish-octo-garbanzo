﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic8Ball.Presenter
{
    public interface IView
    {
        void DisplayAnswer(string answer);
    }
}