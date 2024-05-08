using System;
using System.Collections.Generic;
using System.IO;
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

namespace readfile
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Путь к файлу (измените на ваш путь)
            string filePath = "data.txt";

            try
            {
                // Чтение содержимого файла
                string fileContent = File.ReadAllText(filePath);

                // Отображение содержимого в TextBlock
                ContentTextBlock.Text = fileContent;
            }
            catch (Exception ex)
            {
                // Обработка ошибок (например, файл не найден)
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
    }
}