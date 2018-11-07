using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using Infragistics.Windows.DataPresenter;
using System.Windows.Media.Effects;
using Infragistics.Windows;
using System.Diagnostics;

namespace DragRecordsXDG
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {

        BindingList<Employee> data;
        public MainWindow()
        {
            InitializeComponent();
            data = EmployeeData.GenerateEmployeeData();
            xamDataGrid1.DataSource = data;
            xamDataGrid1.KeyDown += OnKeyDown;
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            Key key = e.Key;
            if (key == Key.Delete)
            {
                // Delete the selected record
                var emp = xamDataGrid1.ActiveRecord as DataRecord;
                Employee p = emp.DataItem as Employee;

                XamDataGrid dg = sender as XamDataGrid;
                var dd = dg.DataSource as BindingList<Employee>;

                dd.Remove(p);
            }
        }

        private void DragSource_Drop(object sender, Infragistics.DragDrop.DropEventArgs e)
        {
            Employee emp = new Employee();
            emp = dp.DataRecord.DataItem as Employee;

            data.Remove(emp);
            data.Insert(overIndex, emp);           
        }

        DataRecordPresenter dp;
        DataRecordPresenter dragOver;
        int currentIndex;
        private void DragSource_DragStart(object sender, Infragistics.DragDrop.DragDropStartEventArgs e)
        {
           dp= Utilities.GetAncestorFromType(e.DragSource as DependencyObject, typeof(DataRecordPresenter), false) as DataRecordPresenter;
           currentIndex = dp.Record.Index;

        }

        private void CardPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            e.Handled = true;

        }
        int overIndex;
        private void DragSource_DragOver(object sender, Infragistics.DragDrop.DragDropMoveEventArgs e)
        {
            dragOver = Utilities.GetAncestorFromType(e.DropTarget as DependencyObject, typeof(DataRecordPresenter), false) as DataRecordPresenter;
            overIndex = dragOver.Record.VisibleIndex;

        }


    }
}
