using System.Collections.ObjectModel;
using System.Windows;
using LayerByte.Eventlens.Models;
using LayerByte.Eventlens.Services;

namespace LayerByte.Eventlens.Views;

public partial class MainWindow : Window
{
    public ObservableCollection<ReportItem> Items { get; }

    public MainWindow()
    {
        InitializeComponent();
        Items = new SecurityReportService().BuildReport();
        DataContext = this;
    }
}
