using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Ex4
{
    /// <summary>
    /// Interaction logic for UserSoundControls.xaml
    /// </summary>
    public partial class UserSoundControls : UserControl
    {
        public UserSoundControls()
        {
            InitializeComponent();
            this.DataContext = this;
          
        }
        public string ControllerType { get; set; }
        public double MaxValue { get => ViewModelValues.MaxValueGetter(); set => this.MaxValue = value; }
        public double CurrentValue
        {
            get
            {
                return ViewModelValues.InitialValueGetter();
            }
           set
           {
                   CurrentValue = value;
                    
           }
        }
        public string IsError { get => ViewModelValues.GetError(); }
        

    } }  
