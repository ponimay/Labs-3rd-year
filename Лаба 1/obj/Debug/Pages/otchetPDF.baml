   M S B A M L   `   `   `  ����E  AЛаба 1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Лаба_1.PagesЛаба_1.Pages  5           Лаба_1.Pages.otchetPDF   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:Лаба_1.Pages     5        N� Title$  	otchetPDF��5	      .��5      � ���	#FF4C186F � RowDefinitions 5   
   �� 5      $
��361* �6   �� 5      $	��89* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ SpavochnikDG��5         
IsReadOnly .    AutoGenerateColumns .  $��0��6t   ���	#FF2C2988���	#FF131463$��Arial)�6�   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FF7B88F7��6#   � 5      $ 	#FF2C317D��6#    � Offset$ 1Q�65   5      	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$,
 &Номер лицевого счёта��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6g   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6C   �� *uchet.id_zapisi+6g     5      $
 ФИО��6%   $ 2* 6V    62   �� *sprav.full_name+6V     5      $
 Кол-во кватт��6%   $ 2* 6g    6;   �� *uchet.quantity_of_kvatt+6g     5      $
 
Тариф��6%   $ 2* 6T    64   �� *uchet.tarif+6T     5      $ 
 Сумма к оплате��6%   $ 2* 6U    6=   �� *Sum+6U   5      �� 5    
   -   5         ��Name$ otchetyButton��5       $��1��6(   $��640,19,0,18q�65   $
��Left=�6g   $	��150��6�   $��Bahnschrift Condensed)�6�   $��30(�6�   
����������	#FF101E8E���	#FF101E8E.��6  
Назад6	  �� 5!   
   -   5        $ sozdat_otchet��5!      $��1��6(   $��
25,19,0,18q�65   $
��Left=�6f   $	��219��6�   $��Bahnschrift Condensed)�6�   $��30(�6�   
����������	#FF101E8E���	#FF101E8E$��Создать отчёт��6   �� 5"   
   -   5        $ vpered��5"      $��1��6!   $��466,19,0,18q�6.   $
��Left=�6Y   $	��150��6t   $��Bahnschrift Condensed)�6�   $��30(�6�   
����������	#FF101E8E���	#FF101E8E$��Вперед��6�   5#      5$      