﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace NewExamTask
{
     public class ViewModel : INotifyPropertyChanged
     {
        private ObservableCollection<string> tiles;



        public ObservableCollection<string> Tiles
        {
            get { return tiles; }
            set 
            {
                tiles = value;
                OnPropertyChanged(nameof(tiles)); 
            }
        }

        public ViewModel()
        {
            Tiles = new ObservableCollection<string>();

            Random random = new Random();

        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
