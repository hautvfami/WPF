   M S B A M L   `   `   `  ����I  EAppWithDataset, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:AppWithDataset.ServicesAppWithDataset.Services  5   	   C&clr-namespace:AppWithDataset.ViewModelAppWithDataset.ViewModel  5   	   %    AppWithDataset.View.LoginWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   4ff%clr-namespace:AppWithDataset.Services     5   	   5vm&clr-namespace:AppWithDataset.ViewModel     5   	     � Title$  Login��5   	   $	��300��6   $	��300��6$    � DataContext 5      -  'AppWithDataset.ViewModel.LoginViewModel  5   
   .��5
      � .+�5   
   �� $
��Left=�65   $��23��6P   $��	56,86,0,0q�6\    �� TextWrapping$
 Wrap=�6o   $	��Top=�6�   $	��181��6�   ��6   �� *UserInfo.USERNAME+6�   G� 5   
   -   5         G�Name$ PasswordBox��5      2   ,AppWithDataset.Services.PasswordBoxAssistant   BindPassword . $
��Left=�6�   $��23��6�   $��
56,135,0,0q�6�   $	��Top=�6  $	��181��6'     BoundPassword 6X   ��  �� Path$ UserInfo.PASSWORD� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6'  �� 5   
   $��Login��62   $��97,180,100,51q�6B   ��6   �� *LoginCommand+6[   �� 5   
   $��	Username:��6   $
��Left=�6$   $��	56,60,0,0q�6?   $	��Top=�6R   $	��120��6j   �� 5   
   $��	Password:��6   $
��Left=�6$   $��
56,109,0,0q�6?   $	��Top=�6S   $	��120��6k   �� 5   
   $��LIBRARY MANAGEMENT��6   $��16(�6-   $
��Bold"�6;   $
��Left=�6M   $��	47,10,0,0q�6h   $	��Top=�6{   $	��195��6�   �� 5   
   ���#ff0000���#999999$
��Left=�6[   $��0,235,-0.4,0q�6v   $	��Top=�6�   $	��294��6�   $��25��6�   ��6   �� $ Message�6�   5      5      