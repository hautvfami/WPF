using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using AppWithDataset.Model;
using System.IO;

namespace AppWithDataset.ViewModel
{
    class BookViewModel : PropertyChangedBase
    {
        

        // Storage UserList
        private ObservableCollection<BOOK> _bookList;
        public ObservableCollection<BOOK> BookList
        {
            get { return _bookList; }
            set
            {
                if (_bookList != value)
                {
                    _bookList = value;
                    OnPropertyChanged("BookList");
                }
            }
        }
        // End storage UserList


        private BOOK _selectedBook;
        public BOOK SelectedBook
        {
            get { return _selectedBook; }
            set
            {
                if (_selectedBook != null)
                {
                    _selectedBook = value;
                }
                else
                {
                    _selectedBook = new BOOK();
                } OnPropertyChanged("SelectedBook");
            }
        }


        public String SortByName { get; set; }
        private void sortByName()
        {
            List<BOOK> sortedList = BookList.OrderBy(x => x.NAME.ToUpper().Contains(SortByName.ToUpper())).ToList();
            sortedList.Reverse();
            BookList.Clear();
            foreach (var sortedItem in sortedList)
                BookList.Add(sortedItem);
            SelectedBook = BookList.First();
            OnPropertyChanged("BookList");
        }

        public BookViewModel()
        {
            BookList = new ObservableCollection<BOOK>(Model.Books.getAllUsers() as List<BOOK>);
            registerCommand();
            SelectedBook = BookList.First();
        }

        private void Refresh()
        {
            if (BookList != null)
            {
                BookList = null;
            }
            BookList = new ObservableCollection<BOOK>(Model.Books.getAllUsers() as List<BOOK>);
        }

        public void _setPic()
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.ShowDialog();
            if (dlg.FileName != null)
            {
                FileStream fs = new FileStream(dlg.FileName, FileMode.Open, FileAccess.Read);
                byte[] data = new byte[fs.Length];
                fs.Read(data, 0, System.Convert.ToInt32(fs.Length));
                SelectedBook.COVER = data;
                fs.Close();
                OnPropertyChanged("SelectedBook");
            }
        }


        // Begin action commands
        private void registerCommand()
        {
            DeleteCommand = new RelayCommand<BOOK>(u => u != null, u => { Model.Books.handleDelete(u.ID); Refresh(); });
            AddCommand = new RelayCommand<BOOK>(null, u => { Model.Books.handleInsert(u); Refresh(); });
            UpdateCommand = new RelayCommand<BOOK>(u => u != null, u => { Model.Books.handleUpdate(u); Refresh(); });
            EmptyCommand = new RelayCommand<BOOK>(u => u != null, u => { SelectedBook = new BOOK(); });
            SetPicCommand = new RelayCommand<BOOK>(null, u => { this._setPic(); });
            SearchCommand = new RelayCommand<USER>(null, u => { this.sortByName(); });
        }

        public ObservableCollection<BOOK> Books { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand AddCommand { get; set; }
        public ICommand UpdateCommand { get; set; }
        public ICommand EmptyCommand { get; set; }
        public ICommand SetPicCommand { get; set; }
        public ICommand SearchCommand { get; set; }
        // End action commands
    }
}
