using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HashMate.Client.UI.Views
{
    /// <summary>
    /// Interaction logic for FileToHash.xaml
    /// </summary>
    public partial class FileToHashView : UserControl
    {
        public FileToHashView()
        {
            InitializeComponent();
        }

        public void DropArea_DragOver(object sender, DragEventArgs args)
        {
            dropArea.BorderBrush = new SolidColorBrush(Colors.Red);
        }

        public void DropArea_DragLeave(object sender, DragEventArgs args)
        {
            dropArea.BorderBrush = new SolidColorBrush(Colors.Black);
        }
    }
}
