   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WpfApp1.ViewsWpfApp1.Views  5   	   7 clr-namespace:WpfApp1.ViewModelsWpfApp1.ViewModels  63   '    !WpfApp1.Views.AddNewProductWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:WpfApp1.Views     5   	   7
viewmodels clr-namespace:WpfApp1.ViewModels     63   $��278.8��5   	   $��338.4��6     � 
ResizeMode$  NoResize=�6&    � WindowStartupLocation$ CenterOwner=�6<    � DataContext 5	      .   (WpfApp1.ViewModels.AdminProductsWindowVM  5
   
   .��5      � $��	0,0,3.2,1q�6    � ColumnDefinitions 5   
   �� 5      �� 5      $��0* �6   .+�5   
   �� $��Информаиця��6   $
��Left=�6%   $��
21,106,0,0q�6@   $	��Top=�6T   $��24��6l   $��96��6x   �� 5   
   $#��Название товара��6   $
��Left=�6*   $��26��6E   $��	21,11,0,0q�6Q   $	��Top=�6d   $	��117��6|   �� 5   
   $$��Цена за литр (б.р)��6   $
��Left=�6-   $��
157,13,0,0q�6H   $	��Top=�6\   $��24��6t   $	��117��6�   �� 5   
   $
��Left=�6   $��45��6-   $��	21,42,0,0q�69    �� TextWrapping$
 Wrap=�6L   $	��Top=�5   A   $	��117��6Y   ��6   �� *NewNameOfProductFromAddWindow+6Y   �� 5   
   $
��Left=�6   $��85��6-   $��
21,135,0,0q�69   $
 Wrap=�6M   $	��Top=�5   A   $	��117��6Y   ��6   �� *NewInfoOfProductFromAddWindow+6Y   �� 5   
   $
��Left=�6   $��45��6-   $��
159,42,0,0q�69   $
 Wrap=�6M   $	��Top=�5   A   $	��160��6Y   ��6   �� *NewCostOfProductFromAddWindow+6Y   �� 5   
   $��Добавить��6   $
��Left=�6$   $��184,135,0,0q�6?   $	��Top=�6T   $	��117��6l    J� RenderTransformOrigin$ 0.508,1.912&�5   7   ��6   �� *AddNewProduct+67   �� 5   
   $��
Назад��6   $
��Left=�6!   $��184,188,0,0q�6<   $	��Top=�6Q   $	��117��6i   ��5      �� *BackCmdFormAddWindow+5!      5"      