   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	   +clr-namespace:WpfApp1.ElseWpfApp1.Else  5   R       WpfApp1.AuthWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   %elseclr-namespace:WpfApp1.Else  6R     � Title$
  Auto��5	   	   $	��450��6   $	��700��6#    � 
ResizeMode$ NoResize=�6/    � WindowStartupLocation$ CenterOwner=�6E    � DataContext 5
         WpfApp1.AuthVM  5   
   .��5      � ���	#ffdadada.+�5   
   �� $	��400��6   $	��550��6    $��15q�6/   
�������$��Center=�5       �� Padding$ 30q�5       �� CornerRadius$ 20��6     J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 60Q�6#      Color$ 	LightGray��63   	   ShadowDepth$	 0Q�6E   ._�5      �� .+�5      �� $��Welcome!��6   $��30(�6,   $
��bold"�6:   $��0 0 0 20q�6L   � 5      $��	0 0 0 20 q�6   .+�5      �� $
��left=�6   $��Регистрация��68   ��6N   �� *Button_Join_Click+�� 5      $��right=�6   $��
Войти��69   5      �� 5      )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 Введите логин��64   ��6   �� *Login+64   &    WpfApp1.Else.BindablePasswordBox  5         Password 6+   �� *
Password+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=��� 5      $"��Войти в кабинет��6   $
��0 20q�63   $	��170��6B   ��6O   �� *Button_Auth_Click+5      5      5       5!      