﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Presentation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class ConfigModifyUI : Window
    {
        public ConfigModifyUI()
        {
            InitializeComponent();
        }
        private void ToggleButton_Loaded(object sender, RoutedEventArgs e)
        {
            var btn = (ToggleButton)sender;

            btn.SetBinding(ToggleButton.IsCheckedProperty, new Binding("IsOpen") { Source = btn.ContextMenu });
            btn.ContextMenu.PlacementTarget = btn;
            btn.ContextMenu.Placement = PlacementMode.Bottom;
        }
    }
}
