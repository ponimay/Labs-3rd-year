   M S B A M L   `   `   `  ����E  AЛаба 1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Лаба_1.PagesЛаба_1.Pages  5      &     Лаба_1.Pages.otchetPosledniy   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:Лаба_1.Pages     5        N� Title$  otchetPosledniy��5	      .��5      � ���	#FF4C186F � RowDefinitions 5   
   �� 5      $
��361* �6   �� 5      $	��89* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ SpavochnikDG��5         
IsReadOnly .    AutoGenerateColumns .  $��0��6t   ���	#FF2C2988���	#FF131463��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FF7B88F7��6#   � 5      $ 	#FF2C317D��6#    � Offset$ 1Q�65   5      	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$#
 Номер лиц. счёта��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6c   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   �� *uchet.id_zapisi+6c     5      $
 ФИО��6%   $ 2* 6V    62   �� *sprav.full_name+6V     5      $"
 Кол-во киловатт��6%   $ 2* 6j    6>   �� *uchet.quantity_of_kvatt+6j     5      $
 
Тариф��6%   $ 2* 6T    64   �� *uchet.tarif+6T     5      $ 
 Сумма к оплате��6%   $ 2* 6U    6=   �� *Sum+6U   5      �� 5    
   $��Bahnschrift Condensed)�6   $��25(�67   $.��(Группировка по тарифу��6E   $��183,26,387,21q�6b   $��1��6y   
�������6�   �� 5!   
   -   5         ��Name$ CBgroup2��5!      $
��Left=�6%   $��1��6@   $��Center=�6M   $	��162��6h   $��40��6t   
���   �$��	390,0,0,0q�6�   
���   ���5"      �� 5#      $	 0,1&�6&   .��5$      � $ 	#FFF0F0F0��6#   � 5%      $ White��6#   $ 1Q�61   5&      .@�5(      �� $��По умолчанию��6   �� 5)      $��100-200��6   �� 5*      $��200-300��6   �� 5+      $��300-400��6   �� 5,      $��400-500��6   5-      �� 5/   
   -   5         ��Name$ sozdat_otchet��5/      $��1��6(   $��584,19,0,18q�65   $
��Left=�6g   $	��193��6�   $��Bahnschrift Condensed)�6�   $��30(�6�   
����������	#FF101E8E���	#FF101E8E$��Создать отчёт��6  �� 50   
   -   5        $ otchetyButton��50      $��1��6(   $��
10,19,0,18q�65   $
��Left=�6f   $	��150��6�   $��Bahnschrift Condensed)�6�   $��30(�6�   
����������	#FF101E8E���	#FF101E8E$��
Назад��6   51      52      