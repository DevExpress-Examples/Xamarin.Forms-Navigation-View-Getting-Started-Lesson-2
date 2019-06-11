using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace GettingStarted2.Views {
    public partial class NavPage : NavigationPage {
        public NavPage() {
            InitializeComponent();
        }

        public NavPage(Page mainPage): base(mainPage) {
            InitializeComponent();
        }
    }
}
