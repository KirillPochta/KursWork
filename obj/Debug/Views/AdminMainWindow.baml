   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WpfApp1.ViewsWpfApp1.Views  5   	   'clr-namespace:ViewModels
ViewModels  63   !clr-namespace:WpfApp1WpfApp1  6_   7 clr-namespace:WpfApp1.ViewModelsWpfApp1.ViewModels  6�   #    WpfApp1.Views.AdminMainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:WpfApp1.Views     5   	   /
ViewModelsclr-namespace:ViewModels     63   )WpfApp1clr-namespace:WpfApp1     6_   7
viewmodels clr-namespace:WpfApp1.ViewModels     6�     � Title$  Главная��5   	   $	��450��6   $��542.4��6&    � 
ResizeMode$ NoResize=�64    � WindowStartupLocation$ CenterOwner=�6J    � DataContext 5	      *   $WpfApp1.ViewModels.AdminMainWindowVM  5
   
   .��5      � $��111,10,-0.4,0q�6   .+�5   
      WpfApp1.ContextHolder  $��-112,0,0.4,0q�6       Commands 5         WpfApp1.CommandBinding  .  (System.Windows.Input.ApplicationCommands   Delete   RoutedCommand# Z 6)      RelayCommand 5   '   �� *RemoveCommand+  5         Open# Z 6)    5   '   �� *ShowContentCommand+  5      
	   New# Z	 6)    5   '   �� *ChangeAdvertCommand+.��5      �� $
��Left=�6k   $	��394��6�   $��	34,10,0,0q�6�   $	��Top=�6�   $	��358��6�   
 �� SelectedItem
 6   �� *SelectetListBoxItem+��6D   �� *ItemForListBox+��5      �� 5      .R�5      �  � ColumnDefinitions 5      �� 5   "   �� 5   "   $
��Auto �63   �� 5   "   $
��Auto �63   �� 5   "   $
��Auto �63   .+�5       �� .+�5!   "   �� $��16(�6,   $��Center=�6]   ��6:   ��  �� Path$ NameOfAdvert�6]   �� 5"   "   $��16(�6,   $��Center=�6`   ��6:   �� $ DateOfPublished�6`   �� 5$   "   $��5q�6)   $��Читать��65   #��Z 5%   %   ��5&   %   �� �� 5'   "   $��5q�6)   $��Удалить��65   #��Z 5(   %   ��5)   %   �� �� 5*   "   $��5q�6)   $��Изменить��65   #��Z	 5+   !   ��5,   !   �� 5-      5.      5/      51      52      �� 53   
   $��13(�6   $��Новая новость��6   $
��Left=�67   $��298,281,0,0q�6R   $	��Top=�6g   $��99��6   $��30��6�   �� 54   
   $��В кабинет��6   $
��Left=�6%   $��298,244,0,0q�6@   $	��Top=�6U   $��99��6m   ��6x   �� *ReturnToTheAdminCabinet+�� 55   
   $��Добавить��6   $
��Left=�6$   $��298,316,0,0q�6?   $	��Top=�6T   $��99��6l   ��6w   �� *AddNewAdvert+�� 56   
   $��Товары��6   $
��Left=�6"   $��298,372,0,0q�6=   $	��Top=�6R   $��99��6j   ��6u   �� *MoveToTheAdminsProductWindow+�� 57   
   $��
Выйти��6   $
��Left=�6!   $��
298,29,0,0q�6<   $	��Top=�6P   $��99��6h   ��6s   �� *Exit+58      59      