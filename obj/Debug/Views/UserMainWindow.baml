   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WpfApp1.ViewsWpfApp1.Views  5   	   'clr-namespace:ViewModels
ViewModels  5   	   !clr-namespace:WpfApp1WpfApp1  5   	   !clr-namespace:WpfApp1WpfApp1  6/   "    WpfApp1.Views.UserMainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:WpfApp1.Views     5   	   /
ViewModelsclr-namespace:ViewModels     5   	   )WpfApp1clr-namespace:WpfApp1     5   	   (local1clr-namespace:WpfApp1     6/     � Title$  Главная��5
   	   $	��450��6   $��542.4��6&    � WindowStartupLocation$ CenterOwner=�64    � DataContext 5      !   ViewModels.UserMainWindowVM  5   
   .��5      � $��111,10,-0.4,0q�6   .+�5   
      WpfApp1.ContextHolder  $��
-112,0,0,0q�6       Commands 5         WpfApp1.CommandBinding  .  (System.Windows.Input.ApplicationCommands   Open   RoutedCommand# Z 6)      RelayCommand 5   '   �� *ShowContentCommand+.��5      �� $
��Left=�6=   $	��394��6X   $��	30,10,0,0q�6e   $	��Top=�6x   $	��357��6�   ��6   �� *ItemForListBox+��5      �� 5      .R�5      �  � ColumnDefinitions 5      �� 5   "   �� 5   "   $
��Auto �63   �� 5   "   $
��Auto �63   �� 5   "   $
��Auto �63   .+�5      �� .+�5   "   �� $��16(�6,   $��Center=�6]   ��6:   ��  �� Path$ NameOfAdvert�6]   �� 5    "   $��16(�6,   $��Center=�6`   ��6:   �� $ DateOfPublished�6`   �� 5!   "   $��5q�6)   $��Смотреть��65   #��Z 5"   %   ��5#   %   �� 5$      5%      5&      5(      5)      �� 5*   
   $��В кабинет��6   $
��Left=�6%   $��298,314,0,0q�6@   $	��Top=�6U   $��99��6m   ��6x   �� *ReturnToTheUserCabinet+�� 5+   
   $��Товары��6   $
��Left=�6"   $��298,364,0,0q�6=   $	��Top=�6R   $��99��6j   ��6u   �� *MoveToTheUserProductsWindow+�� 5,   
   $��
Выйти��6   $
��Left=�6!   $��
298,29,0,0q�6<   $	��Top=�6P   $��99��6h   ��6s   �� *Exit+5-      5.      