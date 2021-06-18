﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio10
{
    public class MonkeysPageViewModel : ViewModelBase
    {
        public IList<Monkey> Monkeys { get { return MonkeyData.Monkeys; } }

        Monkey selectedMonkey;
        public Monkey SelectedMonkey
        {
            get { return selectedMonkey; }
            set
            {
                if (selectedMonkey != value)
                {
                    selectedMonkey = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
