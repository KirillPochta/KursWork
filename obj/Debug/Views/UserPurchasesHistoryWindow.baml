   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WpfApp1.ViewsWpfApp1.Views  5   	   !clr-namespace:WpfApp1WpfApp1  5   	   7 clr-namespace:WpfApp1.ViewModelsWpfApp1.ViewModels  6/   /clr-namespace:WpfApp1.ModelsWpfApp1.Models  5   	   .    (WpfApp1.Views.UserPurchasesHistoryWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:WpfApp1.Views     5   	   )WpfApp1clr-namespace:WpfApp1     5   	   7
viewmodels clr-namespace:WpfApp1.ViewModels     6/   ,Modclr-namespace:WpfApp1.Models     5   	     � Title$   UserPurchasesHistoryWindow��5
   	   $��459.6��6,   $��533.971��6;    � 
ResizeMode$ NoResize=�6K    � WindowStartupLocation$ CenterOwner=�6a    � DataContext 5      *   $WpfApp1.UserPurchasesHistoryWindowVm  5   
   .��5      � $��111,10,3.6,0q�6   .+�5   
      WpfApp1.ContextHolder  $��-112,-28,-8.4,-0.4q�6       Commands 5         WpfApp1.CommandBinding  .  (System.Windows.Input.ApplicationCommands   Open   RoutedCommand# Z 6)      RelayCommand 5   '   �� *ShowСhequeOfProductCommand+  5      
   New# Z 6)    5   '   �� *DeletaProductCommand+.��5      �� $
��Left=�6J   $	��394��6e   $��	34,10,0,0q�6r   $	��Top=�6�   $	��358��6�   ��6   �� *ItemsForPurchaseHistoryBox+��5      �� 5      	 �� DataType$   WpfApp1.Models.PurchaseHistory"	  6#   .R�5      � 
 � ColumnDefinitions
 5      �� 5   "   �� 5   "   $
��Auto �63   �� 5   "   $
��Auto �63   �� 5   "   $
��Auto �63   .+�5       �� $��Center=�6)   .+�5!   "   ]� $��Center=�6,   .+�5"   &   �� $��16(�60   $&�� Название товара - ��6>   $��Center=�6X   �� 5#   &   $��16(�60   $��Center=�6c   ��6>   �� *NameOfBoughtProduct+6c   5$   #   �� 5%   "   $��5q�6)   $#��Просмотреть чек��65   #��Z 5&   %   ��5'   %   �� �� 5(   "   $��5q�6)   $%��Отменить покупку��65   #��Z 5)   %   ��5*   %   �� 5+      5,      5-      5/      50      �� 51   
   $��В кабинет��6   $
��Left=�6%   $��
304,10,0,0q�6@   $	��Top=�6T   $��99��6l   ��6w   �� *ReturnToTheUserCabinet+�� 52   
   $��
Выйти��6   $
��Left=�6!   $��304,353,0,0q�6<   $	��Top=�6Q   $��99��6i   ��6t   �� *Exit+�� 53   
   $��Сортировать��6   $
��Left=�6'   $��287,134,0,0q�6B   $	��Top=�6W   $	��120��6o   ��6{   �� *MadeASortByName+�� 54   
   $0��*Сортировка по названию��6   $��9(�61   $
��Left=�6>   $��287,105,0,0q�6Y   $	��Top=�6n   �� 55   
   $��Сортировать��6   $
��Left=�6'   $��287,204,0,0q�6B   $	��Top=�6W   $	��120��6o   ��6{   �� *MadeASortByIdPurchase+�� 56   
   $(��"Сортировка по чеку��6   $��10(�6-   $
��Left=�6;   $��287,175,0,0q�6V   $	��Top=�6k   58      59      