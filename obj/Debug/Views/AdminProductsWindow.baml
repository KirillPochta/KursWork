   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WpfApp1.ViewsWpfApp1.Views  5   	   7 clr-namespace:WpfApp1.ViewModelsWpfApp1.ViewModels  63   !clr-namespace:WpfApp1WpfApp1  6g   '    !WpfApp1.Views.AdminProductsWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:WpfApp1.Views     5   	   7
viewmodels clr-namespace:WpfApp1.ViewModels     63   )WpfApp1clr-namespace:WpfApp1     6g     � Title$  Товары��5   	   $	��450��6   $��537.2��6%    � 
ResizeMode$ NoResize=�63    � WindowStartupLocation$ CenterOwner=�6I    � DataContext 5	      .   (WpfApp1.ViewModels.AdminProductsWindowVM  5
   
   .��5      � $��111,10,-0.4,0q�6   .+�5   
      WpfApp1.ContextHolder  $��-112,0,10,0q�6       Commands 5         WpfApp1.CommandBinding  .  (System.Windows.Input.ApplicationCommands   Delete   RoutedCommand# Z 6)      RelayCommand 5   '   �� *RemoveCommand+  5         Open# Z 6)    5   '   �� *ShowInfoOfProductCommand+  5      
	   New# Z	 6)    5   '   �� *ChangeProductCommand+.��5      �� $
��Left=�6p   $	��394��6�   $��	34,10,0,0q�6�   $	��Top=�6�   $	��358��6�   
 �� SelectedItem
 6   �� *SelectetListBoxItem+��6D   �� *ItemsForProductsBox+��5      �� 5      .R�5      �  � ColumnDefinitions 5      �� 5   "   �� 5   "   $
��Auto �63   �� 5   "   $
��Auto �63   �� 5   "   $
��Auto �63   .+�5       �� $��Center=�6)   .+�5!   "   �� $��16(�6,   $��Center=�6^   ��6:   ��  �� Path$ NameOfProduct�6^   ]� 5"   "   .+�5#   &   �� $��16(�60   $%��Цена за литр (б.р):��6>   $��Center=�6Y   �� 5$   &   $��16(�60   $��Center=�6Y   ��6>   �� $
 Cost�6Y   5%   #   �� 5&   "   $��5q�6)   $��Читать��65   #��Z 5'   %   ��5(   %   �� �� 5)   "   $��5q�6)   $��Удалить��65   #��Z 5*   %   ��5+   %   �� �� 5,   "   $��5q�6)   $��Изменить��65   #��Z	 5-   !   ��5.   !   �� 5/      50      51      53      54      �� 55   
   $��13(�6   $��Новый товар��6   $
��Left=�65   $��298,268,0,0q�6P   $	��Top=�6e   $��99��6}   $��30��6�   �� 56   
   $��В кабинет��6   $
��Left=�6%   $��298,231,0,0q�6@   $	��Top=�6U   $��99��6m   ��6x   �� *ReturnToTheAdminCabinet+�� 57   
   $��Добавить��6   $
��Left=�6$   $��298,303,0,0q�6?   $	��Top=�6T   $��99��6l   ��6w   �� *AddNewProductToWindow+�� 58   
   $��Новости��6   $
��Left=�6#   $��298,359,0,0q�6>   $	��Top=�6S   $��99��6k   ��6v   �� *MoveToTheAdminAdvertWindow+�� 59   
   $��
Выйти��6   $
��Left=�6!   $��
298,29,0,0q�6<   $	��Top=�6P   $��99��6h   ��6s   �� *Exit+5:      5;      