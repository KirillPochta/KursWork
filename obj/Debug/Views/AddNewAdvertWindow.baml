   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WpfApp1.ViewsWpfApp1.Views  5   	   'clr-namespace:ViewModels
ViewModels  63   7 clr-namespace:WpfApp1.ViewModelsWpfApp1.ViewModels  6_   &     WpfApp1.Views.AddNewAdvertWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:WpfApp1.Views     5   	   /
ViewModelsclr-namespace:ViewModels     63   8ViewModels1 clr-namespace:WpfApp1.ViewModels     6_     � Title$  AddNewAdvertWindow��5   	   $	��340��6$   $	��300��61    � 
ResizeMode$ NoResize=�6=    � WindowStartupLocation$ CenterOwner=�6S    � DataContext 5	      *   $WpfApp1.ViewModels.AdminMainWindowVM  5
   
   .��5      � $��0,0,3.6,0.4q�6    � ColumnDefinitions 5   
   �� 5      �� 5      $��0* �6   .+�5   
   �� $��Содержимое��6   $
��Left=�6%   $��	21,88,0,0q�6@   $	��Top=�6S   $��24��6k   $��80��6w   �� 5   
   $%��Название новости��6   $
��Left=�6+   $��26��6F   $��	21,11,0,0q�6R   $	��Top=�6e   $	��117��6}   �� 5   
   $��
Автор��6   $
��Left=�6    $��
165,13,0,0q�6;   $	��Top=�6O   $��24��6g   $��41��6s   �� 5   
   $
��Left=�6   $��31��6.   $��	21,42,0,0q�6:    �� TextWrapping$
 Wrap=�6M   $	��Top=�6�   $	��117��6�   ��6a   �� *NameOfadvertFromAddWindow+6�   �� 5   
   $
��Left=�6   $��85��6-   $��
21,117,0,0q�69   $
 Wrap=�6M   $	��Top=�6�   $	��259��6�   ��6a   �� *ContentOfadvertFromAddWindow+6�   �� 5   
   $
��Left=�6   $��31��6-   $��
163,42,0,0q�69   $
 Wrap=�6M   $	��Top=�6�   $	��117��6�   ��6a   �� *AuthorOfadvertFromAddWindow+6�   �� 5   
   $��Добавить��6   $
��Left=�6$   $��
22,241,0,0q�6?   $	��Top=�6S   $��96��6k   ��6v   �� *AddNewAdvertFromWindow+�� 5   
   $��
Назад��6   $
��Left=�6!   $��165,241,0,0q�6<   $	��Top=�6Q   $��96��6i   ��6t   �� *BackFromAddWindow+5      5      