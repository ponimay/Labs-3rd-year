   M S B A M L   `   `   `  ����E  AЛаба 1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Лаба_1.PagesЛаба_1.Pages  5          Лаба_1.Pages.select6   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:Лаба_1.Pages     5        N� Title$  select6��5	      .��5      � ���	#FF0D1871 � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��50 �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ SpavochnikDG��5         
IsReadOnly .    AutoGenerateColumns .  $��0��6W   ���	#FF0D1871���	#FF6876AF��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FF2A3590��6#   � 5      $ 	#FF6370E2��6#    � Offset$ 1Q�65   5      	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Лиц счет��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 80 6_   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� *uchet.id_litsscheta+6_     5      $
 ФИО��6%   $ 2* 6V    62   �� *sprav.full_name+6V     5      $
 
Адрес��6%   $ 2* 6V    64   �� *sprav.aadress+6V     5      $
 
Тариф��6%   $ * 6T    64   �� *uchet.tarif+6T     5      $
 Месяц оплаты��6%   $ * 6�    6;   �� *uchet.month_of_payment+ �� StringFormat$ {0:dd.MM.yyyy}��6�     5      $"
 Кол-во киловатт��6%   $ * 6j    6>   �� *uchet.quantity_of_kvatt+6j   5#      �� 5$   
   -   5        $��
vvodButton��5$      $��1��6<   $��673,10,0,10q�6I   $
��Left=�6^   $	��117��6y   $��Bahnschrift Condensed)�6�   $��25(�6�   
�������
����������	#FF0D1871.��6�   
Назад6�   �� 5%   
   -   5        $��TBpoisk��5%      $
��Left=�6C   $��30��6^   $��	224,0,0,0q�6j   $��1��6}    �� TextWrapping$
 Wrap=�6�   $��Center=�6�   $	��296��6�   �� 5&   
   $
��Left=�6   $��	104,0,0,0q�6/   $��1��6B   $
��Wrap=�6O   $(��"Поиск по лиц. счёту��6c   $��Center=�6~   $$��Bahnschrift SemiBold Condensed)�6�   $��16(�6�   $	��125��6�   
�������6�   �� 5'   
   -   5         ��Name$ vpered��5'      $��1��66   $��541,10,0,10q�6C   $
��Left=�6X   $	��117��6s   $��Bahnschrift Condensed)�6   $��25(�6�   
�������
����������	#FF0D1871$��Вперёд��6�   5)      5*      