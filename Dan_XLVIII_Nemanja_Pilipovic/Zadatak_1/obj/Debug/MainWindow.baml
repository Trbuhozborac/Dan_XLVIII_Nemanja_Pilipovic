   M S B A M L   `   `   `  ����D  @Zadatak_1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Zadatak_1	Zadatak_1  5   	       Zadatak_1.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Zadatak_1     5   	     � Title$  
MainWindow��5   	   $	��150��6   $	��200��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��20 �6   .+�5   
   �� -   5        $��btnUser��5   .   $��1��6   $��1��6!   $
��User��6=   $��20��6L   $	��100��6X   $
��Left=�6d   $��0,10,0,0q�5   W   ��6   �� *ShowUserView+ �� UpdateSourceTrigger$ PropertyChanged=�6W   �� 5   
   -   5        $��btnEmployee��5   .   $��1��6   $��2��6!   $��Employee��6A   $��20��6T   $	��100��6`   $
��Left=�6l   $��0,10,0,0q�5   [   ��6   �� *ShowEmployeeView+$ PropertyChanged=�6[   5      5      