   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WpfApp1.ViewsWpfApp1.Views  5   	   'clr-namespace:ViewModels
ViewModels  63   7 clr-namespace:WpfApp1.ViewModelsWpfApp1.ViewModels  6_   !clr-namespace:WpfApp1WpfApp1  6�   &     WpfApp1.Views.ChangeAdvertWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:WpfApp1.Views     5   	   /
ViewModelsclr-namespace:ViewModels     63   8ViewModels1 clr-namespace:WpfApp1.ViewModels     6_   )wpfapp1clr-namespace:WpfApp1     6�   $	��342��5   	   $��299.2��6     � 
ResizeMode$  NoResize=�6$    � WindowStartupLocation$ CenterOwner=�6:    � DataContext 5	      *   $WpfApp1.ViewModels.AdminMainWindowVM  5
   
   .��5      � $��0,0,3.6,0.4q�6    � ColumnDefinitions 5   
   �� 5      �� 5      $��0* �6   .+�5   
   �� $��Содержимое��6   $
��Left=�6%   $��	21,88,0,0q�6@   $	��Top=�6S   $��24��6k   $��80��6w   �� 5   
   $%��Название новости��6   $
��Left=�6+   $��26��6F   $��	21,11,0,0q�6R   $	��Top=�6e   $	��117��6}   �� 5   
   $��
Автор��6   $
��Left=�6    $��
161,13,0,0q�6;   $	��Top=�6O   $��24��6g   $��41��6s   �� 5   
   $
��Left=�6   $��31��6-   $��	21,42,0,0q�69    �� TextWrapping$
 Wrap=�6L   $	��Top=�5   C   $	��117��6[   ��6   �� *!ChangeNameOfadvertFromAddWindow+6[   �� 5   
   $
��Left=�6   $��85��6-   $��
21,117,0,0q�69   $
 Wrap=�6M   $	��Top=�5   F   $	��255��6^   ��6   �� *$"ChangeContentOfadvertFromAddWindow+6^   �� 5   
   $
��Left=�6   $��31��6-   $��
159,42,0,0q�69   $
 Wrap=�6M   $	��Top=�5   E   $	��117��6]   ��6   �� *#!ChangeAuthorOfadvertFromAddWindow+6]   �� 5   
   $��Изменить��6   $
��Left=�6$   $��
42,257,0,0q�6?   $	��Top=�6S   $��96��6k   ��5      �� *ChangeAdvertCommand1+�� 5   
   $��
Назад��6   $
��Left=�6!   $��159,257,0,0q�6<   $	��Top=�6Q   $��96��6i   ��5       �� *	BackCmd+5#      5$      