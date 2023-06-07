using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using Microsoft.Spatial;

namespace IoSilownia.Utilities
{
    public class Btn : RadioButton
    {
        static Btn()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Btn), new FrameworkPropertyMetadata(typeof(Btn)));
        }


        public Uri Navlink
        { get { return (Uri)GetValue(NavlinkProperty); }
            set { SetValue(NavlinkProperty, value); } 
        
        }

        public static readonly DependencyProperty NavlinkProperty = DependencyProperty.Register("Navlink", typeof(Uri), typeof(Btn), new PropertyMetadata(null));


      
        

    }
}
