using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace NewExamTask
{
     public class ViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Model> borders;

        public ObservableCollection<Model> Borders
        {
            get { return borders; }
            set 
            {
                borders = value;
                OnPropertyChanged(nameof(borders)); 
            }
        }

        public ViewModel()
        {
            Borders = new ObservableCollection<Model>();

            // Создаем и добавляем 3 случайных бордера
            Random random = new Random();

            for (int i = 0; i < 3; i++)
            {
                double x = random.Next(0, 400);
                double y = random.Next(0, 400);

                Model border = new Model
                {
                    X = x,
                    Y = y,
                    Width = 100,
                    Height = 100,
                    BorderBrush = Brushes.Black,
                    BorderWidth = 2
                };

                Borders.Add(border);
            }
        }
        Model border1 = new Model
        {
            X = 50,
            Y = 50,
            Width = 100,
            Height = 100,
            BorderBrush = Brushes.Red,
            BorderWidth = 4
        };

        Model border2 = new Model
        {
            X = 200,
            Y = 200,
            Width = 150,
            Height = 150,
            BorderBrush = Brushes.Blue,
            BorderWidth = 4
        };

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        
    }
}
