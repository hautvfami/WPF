   M S B A M L   `   `   `  ���� I  EAppWithDataset, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:AppWithDataset.ViewModelAppWithDataset.ViewModel  $    AppWithDataset.View.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     9custom&clr-namespace:AppWithDataset.ViewModel       � Title$  Library Management System��$
��auto��$
��1000�� � 	Resources ,  &AppWithDataset.ViewModel.UserViewModel   User,  &AppWithDataset.ViewModel.BookViewModel  Book��%   &	        &	          .���� .@��� $��Users Management��.���  � DataContext# [  .+��� $��Id��{�.  $
��Left=�$��	30,40,0,0q�$	��Top=��� $
��Name��$
��Left=�$��	30,71,0,0q�$	��Top=��� $��Address��$
��Left=�$��
30,104,0,0q�$	��Top=��� $��Phone��$
��Left=�$��
30,135,0,0q�$	��Top=��� $��Username��$
��Left=�$��
30,166,0,0q�$	��Top=��� $��Password��$
��Left=�$��
30,198,0,0q�$	��Top=��� $
��Code��$
��Left=�$��
30,229,0,0q�$	��Top=��� -   $��Id��{�.  $
��Left=�$��25��$��
133,41,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��300������ *SelectedUser.ID+ �� Mode$ TwoWay=��� -   $
��Name��$
��Left=�$��26��$��
133,71,0,0q�$
 Wrap=�$	��Top=�$	��300������ *SelectedUser.NAME+$ TwoWay=��� -   $��Address��$
��Left=�$��26��$��133,104,0,0q�$
 Wrap=�$	��Top=�$	��300������ *SelectedUser.ADDRESS+$ TwoWay=��� -   $��Phone��$
��Left=�$��25��$��133,136,0,0q�$
 Wrap=�$	��Top=�$	��300������ *SelectedUser.PHONE+$ TwoWay=��� -   $��Username��$
��Left=�$��26��$��133,166,0,0q�$
 Wrap=�$	��Top=�$	��300������ *SelectedUser.USERNAME+$ TwoWay=��� -   $��Password��$
��Left=�$��26��$��133,198,0,0q�$
 Wrap=�$	��Top=�$	��300������ *SelectedUser.PASSWORD+$ TwoWay=��� $
��Left=�$	��Top=�$	��300��$��26��$��133,230,0,0q� �� SelectedIndex �� *SelectedUser.CODE+$ TwoWay=�.@��� .��Admin�� .��	Manager�� .��Client&   System.Windows.Controls.DataGrid  -   $��UserDataGrid��   SelectionMode$ Extended=�   SelectionUnit$ FullRow=�   AutoGenerateColumns .  $
��Left=�$	��982��$	��217��$��	0,287,0,0q�$	��Top=����� *
UserList+	 �� SelectedItem	 �� *SelectedUser+$ TwoWay=�
   Columns
 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 200    Header$ Ho Ten��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *NAME+  $	 600 $ Dia chi�� �� *	ADDRESS+  $	 200 $ So dien thoai�� �� *PHONE+�� -   $	��Add��$	��Add��$
��Left=�$��
853,40,0,0q�$	��Top=�$��75������ *
AddCommand+���� *SelectedUser+�� -	   $��Update��$��Update��$
��Left=�$��
853,71,0,0q�$	��Top=�$��75������ *UpdateCommand+���� *SelectedUser+�� -
   $��Delete��$��Delete��$
��Left=�$��853,104,0,0q�$	��Top=�$��75������ *DeleteCommand+���� *SelectedUser+�� -   $��Empty��$��Empty��$
��Left=�$��853,136,0,0q�$	��Top=�$��75������ *EmptyCommand+���� *SelectedUser+�� $��2q�
�������$
��Left=�$	��145��$��
471,41,0,0q�$	��Top=�$	��145���� $
��Fill=�$"��../Resources/Images/User.png��$
��Left=�$	��145��$��
471,41,0,0q�$	��Top=�$	��145���� $
��Fill=�$
��Left=�$	��145��$��
471,41,0,0q�$	��Top=�$	��145������ *SelectedUser.AVATAR+�� 
��� ���$
��Left=�$	��145��$��
471,41,0,0q�$	��Top=�$	��145����Z� �� $��Books Management��.��� # [ .+��� $��Id��{�.  $
��Left=�$��	30,40,0,0q�$	��Top=��� $
��Name��$
��Left=�$��	30,71,0,0q�$	��Top=��� $��Address��$
��Left=�$��
30,104,0,0q�$	��Top=��� $��Phone��$
��Left=�$��
30,135,0,0q�$	��Top=��� $��Username��$
��Left=�$��
30,166,0,0q�$	��Top=��� $��Password��$
��Left=�$��
30,198,0,0q�$	��Top=��� $
��Code��$
��Left=�$��
30,229,0,0q�$	��Top=��� {�.  $
��Left=�$��25��$��
133,41,0,0q�$
 Wrap=�$	��Top=�$	��300������ *SelectedBook.ID+$ TwoWay=��� $
��Left=�$��26��$��
133,71,0,0q�$
 Wrap=�$	��Top=�$	��300������ *SelectedBook.NAME+$ TwoWay=��� $
��Left=�$��26��$��133,104,0,0q�$
 Wrap=�$	��Top=�$	��300������ *SelectedBook.ADDRESS+$ TwoWay=��� $
��Left=�$��25��$��133,136,0,0q�$
 Wrap=�$	��Top=�$	��300������ *SelectedBook.PHONE+$ TwoWay=��� $
��Left=�$��26��$��133,166,0,0q�$
 Wrap=�$	��Top=�$	��300������ *SelectedBook.USERNAME+$ TwoWay=��� $
��Left=�$��26��$��133,198,0,0q�$
 Wrap=�$	��Top=�$	��300������ *SelectedBook.PASSWORD+$ OneWayToSource=��� $
��Left=�$��25��$��133,230,0,0q�$
 Wrap=�$	��Top=�$	��300������ *SelectedBook.CODE+$ TwoWay=�  $ Extended=�$ FullRow=� .  $
��Left=�$	��982��$	��217��$��	0,287,0,0q�$	��Top=����� *
UserList+	 �� *SelectedUser+$ TwoWay=�
   $	 200 $ Ho Ten�� �� *NAME+  $	 600 $ Dia chi�� �� *	ADDRESS+  $	 200 $ So dien thoai�� �� *PHONE+�� $	��Add��$
��Left=�$��
853,40,0,0q�$	��Top=�$��75������ *
AddCommand+���� *SelectedBook+�� $��Update��$
��Left=�$��
853,71,0,0q�$	��Top=�$��75������ *UpdateCommand+���� *SelectedBook+�� $��Delete��$
��Left=�$��853,104,0,0q�$	��Top=�$��75������ *DeleteCommand+���� *SelectedBook+�� $��Empty��$
��Left=�$��853,136,0,0q�$	��Top=�$��75������ *EmptyCommand+���� *SelectedBook+�� $��2q�
�������$
��Left=�$	��145��$��
471,41,0,0q�$	��Top=�$	��145���� $
��Fill=�$"��../Resources/Images/User.png��$
��Left=�$	��145��$��
471,41,0,0q�$	��Top=�$	��145���� $
��Fill=�$
��Left=�$	��145��$��
471,41,0,0q�$	��Top=�$	��145������ *SelectedBook.AVATAR+