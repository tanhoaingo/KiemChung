﻿using BookStore.Model;
using BookStore.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace BookStore.ViewModel
{
    public class ListInvoiceViewModel : BaseViewModel
    {
        public bool addInvoice(string customerId, string userId, string date, string total, string pay)
        {
            int result = 0;
            if (int.TryParse(customerId, out result) == true && int.TryParse(userId, out result) && date.Split('/').Length == 3
                && int.TryParse(total, out result) == true && int.TryParse(pay, out result))
                return true;
            return false;
        }
        public ListInvoiceViewModel(bool a) { }
        public ListInvoiceViewModel()
        {
            ListInvoice = new ObservableCollection<HOADON>(DataProvider.Ins.DB.HOADONs);
            SelectedInvoice = null;
            SelectionChangedCommand = new RelayCommand<DataGrid>((p) => { return true; }, (p) => { loadDetail(); });
            ButtonEditClickCommand = new RelayCommand<Button>((p) => { return true; }, (p) => { loadEdit(); });
            ButtonKHClickCommand = new RelayCommand<Button>((p) => { return true; }, (p) => { loadKH(); });
        }
        //
        public void loadDetail()
        {

            Detail = new ObservableCollection<CT_HD>();
            foreach (var item in DataProvider.Ins.DB.CT_HD)
            {
                if (item.MaHoaDon == SelectedInvoice.MaHoaDon)
                {
                    Detail.Add(item);
                }
            }
        }
        public void loadKH()
        {
            if (SelectedInvoice == null)
                return;
            else
            {
                var khachHang = new ObservableCollection<KHACHHANG>(DataProvider.Ins.DB.KHACHHANGs);
                var kh = khachHang.Where(x => x.MaKhachHang == SelectedInvoice.MaKhachHang).First();
                CustomerWindow window = new CustomerWindow(kh);
                window.ShowDialog();
            }    
        }
        public void loadEdit()
        {
            if (SelectedInvoice == null)
            {
                return;
            }
            InvoiceWindow tmpWD = new InvoiceWindow();
            var tmVM = tmpWD.DataContext as InvoiceViewModel;
            tmVM.FlagIntent = 1;
            tmVM.Editor = SelectedInvoice;
            tmVM.LoadData();
            tmpWD.ShowDialog();
        }

        public ICommand SelectionChangedCommand { get; set; }
        public ICommand ButtonEditClickCommand { get; set; }
        public ICommand ButtonKHClickCommand { get; set; }

        private ObservableCollection<HOADON> _ListInvoice;
        private ObservableCollection<CT_HD> _Detail;
        private HOADON _SelectedInvoice;

        public ObservableCollection<HOADON> ListInvoice { get => _ListInvoice; set { _ListInvoice = value; OnPropertyChanged(); } }
        public ObservableCollection<CT_HD> Detail { get => _Detail; set { _Detail = value; OnPropertyChanged(); } }
        public HOADON SelectedInvoice { get => _SelectedInvoice; set { _SelectedInvoice = value; OnPropertyChanged(); } }
    }
}
