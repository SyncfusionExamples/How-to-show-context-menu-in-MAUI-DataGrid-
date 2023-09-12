using Syncfusion.Maui.DataGrid;

namespace SfDataGridSample
{
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        dataGrid.CellRightTapped += DataGrid_CellRightTapped;

    }

    private void DataGrid_CellRightTapped(object sender, DataGridCellRightTappedEventArgs e)
    {
        viewModel.currentColumnName = dataGrid.Columns[e.RowColumnIndex.ColumnIndex].MappingName;
    }

        
}
}