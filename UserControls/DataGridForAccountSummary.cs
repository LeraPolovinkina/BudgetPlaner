using System;
using Avalonia.Controls;
using Lunar.Avalonia1.ViewModels;

namespace Lunar.Avalonia1.UserControls;

public partial class DataGridForAccountSummary : UserControl
{
    public DataGridForAccountSummary()
    {
        InitializeComponent();
        DataContext = new AccountSummaryViewModel();
    }
}