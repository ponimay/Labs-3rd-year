   M S B A M L   `   `   `  ����E  AЛаба 1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Лаба_1
Лаба_1  5          Лаба_1.select   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:Лаба_1     5        N� Title$  select��5	      .��5      � ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ 	#FFA7A4FF��6   � 5      $ 	#FF26245F��6    � Offset$ 1Q�61   5       � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��50 �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ SpavochnikDG��5         
IsReadOnly .    AutoGenerateColumns .  $��0��6W   ���	#FF2C2988���	#FF131463��5      �� 5      $ 0.5,1&�6&   $ 0.5,0&�67   .��5      � $ 	#FF7B88F7��6#   � 5      $ 	#FF2C317D��6#   $ 1Q�65   5      	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6U   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *uchet.id_zapisi+6U     5      $
 
Тариф��6%   $ 2* 6T    64   �� *uchet.tarif+6T     5       $
 Месяц оплаты��6%   $ 2* 6�    6;   �� *uchet.month_of_payment+ �� StringFormat$ {0:dd.MM.yyyy}��6�     5!      $"
 Кол-во киловатт��6%   $ 2* 6j    6>   �� *uchet.quantity_of_kvatt+6j     5"      $
 
Всего��6%   $ 2* 6L    64   �� *Sum+6L   5'      �� 5(   
   -   5        $��
vvodButton��5(      $��1��6<   $��10q�6I   $��Right=�6U   $	��150��6q   $��Bahnschrift Condensed)�6}   $��25(�6�   
����������	#FF191440���	#FF20216D.��6�   
Назад6�   5*      5+      