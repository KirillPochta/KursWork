   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WpfApp1.ViewsWpfApp1.Views  5   	   7 clr-namespace:WpfApp1.ViewModelsWpfApp1.ViewModels  63   !clr-namespace:WpfApp1WpfApp1  6g   (    "WpfApp1.Views.AdminPurchaseHistory   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:WpfApp1.Views     5   	   7
viewmodels clr-namespace:WpfApp1.ViewModels     63   )WpfApp1clr-namespace:WpfApp1     6g     � Title$  AdminPurchaseHistory��5   	   $	��450��6&   $��537.2��63    � 
ResizeMode$ NoResize=�6A    � WindowStartupLocation$ CenterOwner=�6W    � DataContext 5	      /   )WpfApp1.ViewModels.AdminPurchaseHistoryVm  5
   
   .��5      � $��111,10,3.6,0q�6   .+�5   
      WpfApp1.ContextHolder  $��-112,-30,-0.4,0q�6       Commands 5         WpfApp1.CommandBinding  .  (System.Windows.Input.ApplicationCommands   Open   RoutedCommand# Z 6)      RelayCommand 5   '   �� *ShowСhequeOfProductCommand+.��5      �� $
��Left=�6I   $	��394��6d   $��	34,10,0,0q�6q   $	��Top=�6�   $	��358��6�   ��6   �� *ItemsForPurchaseHistoryBox+��5      �� 5      .R�5      �  � ColumnDefinitions 5      �� 5   "   �� 5   "   $
��Auto �63   �� 5   "   $
��Auto �63   �� 5   "   $
��Auto �63   .+�5      �� $��Center=�6)   .+�5   "   ]� .+�5    &   �� $��16(�60   $2��,Идентификатор покупки - ��6>   $��Center=�6^   �� 5!   &   $��16(�60   $��Center=�6b   ��6>   �� 	 �� Path$	 IdOfPurchases�6b   5"   #   ]� 5#   "   .+�5$   &   �� $��16(�60   $&�� Название товара - ��6>   $��Center=�6X   �� 5%   &   $��16(�60   $��Center=�6h   ��6>   �� $	 NameOfBoughtProduct�6h   5&   #   �� 5'   "   $��5q�6)   $1��+Просмотреть ифнормацию��65   #��Z 5(   %   ��5)   %   �� 5*      5+      5,      5.      5/      �� 51   
   $��В кабинет��6   $
��Left=�6%   $��287,363,0,0q�6@   $	��Top=�6U   $	��120��6m   ��6y   �� *ReturnToTheAdminCabinet+�� 52   
   $��
Выйти��6   $
��Left=�6!   $��
287,10,0,0q�6<   $	��Top=�6P   $	��120��6h   ��6t   �� *Exit+�� 53   
   $��Сортировать��6   $
��Left=�6'   $��287,134,0,0q�6B   $	��Top=�6W   $	��120��6o   ��6{   �� *MadeASortByLogin+�� 54   
   $,��&Сортировка по логину��6   $��10(�6/   $
��Left=�6=   $��287,105,0,0q�6X   $	��Top=�6m   �� 55   
   $��Сортировать��6   $
��Left=�6'   $��287,204,0,0q�6B   $	��Top=�6W   $	��120��6o   ��6{   �� *MadeASortByIdPurchase+�� 56   
   $(��"Сортировка по чеку��6   $��10(�6-   $
��Left=�6;   $��287,175,0,0q�6V   $	��Top=�6k   57      58      