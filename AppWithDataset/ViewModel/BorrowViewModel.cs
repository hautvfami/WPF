using AppWithDataset.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AppWithDataset.ViewModel
{
    class BorrowViewModel : PropertyChangedBase
    {
        public String Time { get { return DateTime.Now.ToShortDateString(); } }

        // Storage UserList
        private ObservableCollection<USER> _userList;
        private ObservableCollection<BOOK> _bookList;
        public ObservableCollection<USER> UserList
        {
            get { return _userList; }
            set
            {
                if (_userList != value)
                {
                    _userList = value;
                    OnPropertyChanged("UserList");
                }
            }
        }
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

        private USER_BOOK ub = new USER_BOOK();
        public USER_BOOK UB
        {
            get { return ub; }
            set
            {
                ub.USERID = SelectedUser.ID;
                ub.BOOKID = SelectedBook.ID;
                ub.BORROW_DATE = DateTime.Now;
                ub.RETURN_DATE = DateTime.Now.AddMonths(6);
                ub.IS_RETURN = false;
            }
        }

        private USER _selectedUser;
        public USER SelectedUser
        {
            get { return _selectedUser; }
            set
            {
                if (_selectedUser != null)
                {
                    _selectedUser = value;
                }
                else
                {
                    _selectedUser = new USER();
                } OnPropertyChanged("SelectedUser");
            }
        }

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

        public String SearchByUserId { get; set; }
        private void sortByUserId()
        {
            List<USER> sortedList = UserList.OrderBy(x => x.ID.ToString() == Convert.ToString(SearchByUserId)).ToList();
            sortedList.Reverse();
            UserList.Clear();
            foreach (var sortedItem in sortedList)
                UserList.Add(sortedItem);
            SelectedUser = UserList.First();
            OnPropertyChanged("UserList");
        }

        public String SearchByBookId { get; set; }
        private void sortByBookId()
        {
            List<BOOK> sortedList = BookList.OrderBy(x => x.ID.ToString() == Convert.ToString(SearchByBookId)).ToList();
            sortedList.Reverse();
            BookList.Clear();
            foreach (var sortedItem in sortedList)
                BookList.Add(sortedItem);
            SelectedBook = BookList.First();
            OnPropertyChanged("BookList");
        }


        public BorrowViewModel()
        {
            UserList = new ObservableCollection<USER>(Model.Users.getAllUsers() as List<USER>);
            BookList = new ObservableCollection<BOOK>(Model.Books.getAllUsers() as List<BOOK>);
            registerCommand();
            SelectedUser = UserList.First();
            SelectedBook = BookList.First();
        }

        private void Refresh()
        {
            if (UserList != null)
            {
                UserList = null;
            }
            UserList = new ObservableCollection<USER>(Model.Users.getAllUsers() as List<USER>);
        }

        // Begin action commands
        private void registerCommand()
        {
            DeleteCommand = new RelayCommand<USER>(null, u => { Refresh(); });
            BorrowCommand = new RelayCommand<USER>(null, u => { UB = null; Model.UserBook.handleBorrow(UB);});
            UpdateCommand = new RelayCommand<USER>(null, u => { Refresh(); });
            SearchBookCommand = new RelayCommand<BOOK>(null, u => { this.sortByBookId(); });
            SearchUserCommand = new RelayCommand<USER>(null, u => { this.sortByUserId(); });
        }

        public ObservableCollection<USER> Users { get; set; }
        public ObservableCollection<BOOK> Books { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand BorrowCommand { get; set; }
        public ICommand UpdateCommand { get; set; }
        public ICommand SearchBookCommand { get; set; }
        public ICommand SearchUserCommand { get; set; }
        // End action commands
    }
}
