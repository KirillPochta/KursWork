   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WpfApp1.ViewsWpfApp1.Views  5   	   7 clr-namespace:WpfApp1.ViewModelsWpfApp1.ViewModels  63   !clr-namespace:WpfApp1WpfApp1  6g   +clr-namespace:WpfApp1.ElseWpfApp1.Else  6�   &     WpfApp1.Views.UserProductsWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:WpfApp1.Views     5   	   7
viewmodels clr-namespace:WpfApp1.ViewModels     63   )WpfApp1clr-namespace:WpfApp1     6g   :xctk)http://schemas.xceed.com/wpf/xaml/toolkit     6�   +elseclr-namespace:WpfApp1.Else     6�     � Title$  UserProductsWindow��5   	   $	��450��6$   $��537.238��61    � 
ResizeMode$ NoResize=�6A    � WindowStartupLocation$ CenterOwner=�6W    � DataContext 5	      -  'WpfApp1.ViewModels.UserProductsWindowVm  5
   
   .��5      � $��111,10,-0.4,0q�6   .+�5   
      WpfApp1.ContextHolder  $��-112,0,10,0q�6       Commands 5         WpfApp1.CommandBinding  .  (System.Windows.Input.ApplicationCommands   Find   RoutedCommand# Z 6)      RelayCommand 5   '   �� *BuyProductCommand+  5         Open# Z 6)    5   '   �� *ShowInfoOfProductCommand+.��5      �� $
��Left=�6p   $	��394��6�   $��	34,10,0,0q�6�   $	��Top=�6�   $	��358��6�   	 �� SelectedItem	 6   �� *SelectetListBoxItem+��6D   �� *ItemsForProductsBox+��5      �� 5      .R�5      � 
 � ColumnDefinitions
 5      �� 5   "   �� 5   "   $
��Auto �63   �� 5   "   $
��Auto �63   �� 5   "   $
��Auto �63   .+�5      �� $��Center=�6)   .+�5   "   �� $��16(�6,   $��Center=�6^   ��6:   ��  �� Path$ NameOfProduct�6^   ]� 5    "   .+�5!   &   �� $��16(�60   $2��,Цена товара за литр (б.р):��6>   $��Center=�6`   �� 5"   &   $��16(�60   $��Center=�6Y   ��6>   �� $
 Cost�6Y   5#   #   ]� 5$   "   .+�5%   &   �� $��16(�60   $��Количество: ��6>   $��Center=�6R   �� 5&   &   .��6.   ��5'   *   �� 5(   .   $ Count�66    �� UpdateSourceTrigger$ PropertyChanged=�6C    �� ValidationRules 5)   2   ,   &WpfApp1.Else.StringToIntValidationRule  5*   6   ,  &System.Windows.Controls.ValidationRule   ValidationStep$ RawProposedValue=�6U   5,   /   .��5-   8   5.   '   5/   #   �� 50   "   $��5q�6)   $��Читать��65   #��Z 51   %   ��52   %   �� �� 53   "   $��5q�6)   $��Купить��65   #��Z 54   %   ��55   %   �� 56      57      58      5:      5;      �� 5<   
   $��В кабинет��6   $
��Left=�6%   $��298,323,0,0q�6@   $	��Top=�6U   $��99��6m   ��6x   �� *ReturnToTheUserCabinet+�� 5=   
   $��Новости��6   $
��Left=�6#   $��298,372,0,0q�6>   $	��Top=�6S   $��99��6k   ��6v   �� *MoveToTheUserAdvertWindow+�� 5>   
   $��
Выйти��6   $
��Left=�6!   $��
298,29,0,0q�6<   $	��Top=�6P   $��99��6h   ��6s   �� *Exit+5?      5@      