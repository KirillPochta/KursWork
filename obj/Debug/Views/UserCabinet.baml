   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WpfApp1.ViewsWpfApp1.Views  5   	   7 clr-namespace:WpfApp1.ViewModelsWpfApp1.ViewModels  63       WpfApp1.Views.UserCabinet   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:WpfApp1.Views     5   	   7
viewmodels clr-namespace:WpfApp1.ViewModels     63     � Title$  Кабинет��5   	   $��286.733��6   $��353.2��6*    � 
ResizeMode$ NoResize=�68    � WindowStartupLocation$ CenterOwner=�6N    � DataContext 5	      &    WpfApp1.ViewModels.UserCabinetVm  5
   
   .��5      � $	��268��6   $	��Top=�6   $��0,0,0.2,-26.4q�61    � ColumnDefinitions 5   
   �� 5      �� 5      $��0* �6   �� 5      $��0* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $��Покупки��65   $
��Left=�6G   $��
165,27,0,0q�6b   $	��Top=�6v   $	��164��6�   ��6   �� *PurchaseHistory+6�   �� 5   
   $��На главную��6:   $
��Left=�6O   $��
165,80,0,0q�6j   $	��Top=�6~   $	��164��6�   ��6   �� *MoveToUserMainWindow+6�   �� 5   
   $��Обновить��6,   $
��Left=�6?   $��165,135,0,0q�6Z   $	��Top=�6o   $	��164��6�   ��6   �� *Update+6�   �� 5   
   $��Имя��6   $
��Left=�6   $��	10,69,0,0q�69   $	��Top=�6L   $��24��6d   $��31��6p   �� 5   
   $��Фамилия��6   $
��Left=�6"   $��	9,109,0,0q�6=   $	��Top=�6P   $��24��6h   $��58��6t   �� 5   
   $��Описание��6   $
��Left=�6#   $��
10,163,0,0q�6>   $	��Top=�6R   $��62��6j   $��24��6u   �� 5   
   $��
Логин��6   $
��Left=�6    $��	10,19,0,0q�6;   $	��Top=�6N    J� RenderTransformOrigin$ -2.628,-0.172&�6f   $��24��6�   $��42��6�   �� 5   
   $
��Left=�6   $��34��6-   $��	57,70,0,0q�69    �� TextWrapping$
 Wrap=�6L   $	��Top=�6v   $��98��6�   ��6`   �� *Name+6�   �� 5   
   $
��Left=�6   $��69��6-   $��
72,163,0,0q�69   $
 Wrap=�6M   $	��Top=�6~   $��88��6�   ��6a   �� *Discription+6�   �� 5   
   $
��Left=�6   $��41��6-   $��
72,106,0,0q�69   $
 Wrap=�6M   $	��Top=�6x   $��85��6�   ��6a   �� *LName+6�   �� 5    
   $
��Left=�6   $��39��6/   $��	57,19,0,0q�6;   $
��Wrap=�6N   $	��Top=�6y   $��98��6�   ��6b   �� *Login+6�   �� 5!   
   $��
Выход��6*   $
��Left=�6:   $��165,191,0,0q�6U   $	��Top=�6j   $	��164��6�   ��6   �� *Exit+6�   5"      5#      