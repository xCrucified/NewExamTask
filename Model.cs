using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace NewExamTask
{
    public class Model : INotifyPropertyChanged
    {
        public int num = 0;
        private double x;
        private double y;
        private double width;
        private double height;
        private Brush borderBrush;
        private double borderWidth;
        private bool isDragging;

        public double X
        {
            get { return x; }
            set 
            {
                x = value;
                OnPropertyChanged(nameof(x)); 
            }
        }

        public double Y
        {
            get { return y; }
            set
            {
                y = value;
                OnPropertyChanged(nameof(y)); 
            }
        }

        public double Width
        {
            get { return width; }
            set 
            {
                width = value;
                OnPropertyChanged(nameof(width)); 
            }
        }

        public double Height
        {
            get { return height; }
            set
            {
                height = value;
                OnPropertyChanged(nameof(height));
            }
        }

        public Brush BorderBrush
        {
            get { return borderBrush; }
            set 
            { 
                borderBrush = value;
                OnPropertyChanged(nameof (borderBrush));
            }
        }

        public double BorderWidth
        {
            get { return borderWidth; }
            set 
            {
                borderWidth = value;
                OnPropertyChanged(nameof (borderWidth)); 
            }
        }

        public bool IsDragging
        {
            get { return isDragging; }
            set
            {
                isDragging = value;
                OnPropertyChanged(nameof(isDragging)); 
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
