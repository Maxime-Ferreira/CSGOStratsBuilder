using System;
using System.Windows;

namespace CSGOStratsBuilder {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void Quit_Click(object sender, RoutedEventArgs e) {
            Environment.Exit(0);
        }
    }
}
