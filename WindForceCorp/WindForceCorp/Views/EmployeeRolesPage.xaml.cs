﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WindForceCorp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EmployeeRolesPage : ContentPage
    {
        public EmployeeRolesPage(List<Models.Employee> allEmployee)
        {
            InitializeComponent();
        }
    }
}