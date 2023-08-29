using Syncfusion.Maui.DataGrid;

namespace SfDataGridSample
{
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
#if WINDOWS || MACCATALYST
        dataGrid.CellRightTapped += DataGrid_CellRightTapped;
#endif

    }

    private void DataGrid_CellRightTapped(object sender, DataGridCellRightTappedEventArgs e)
    {
        viewModel.currentColumnName = dataGrid.Columns[e.RowColumnIndex.ColumnIndex].MappingName;
    }

        
}
}