   M S B A M L   `   `   `  ����E  AЛаба 1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Лаба_1
Лаба_1  5          Лаба_1.select4   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:Лаба_1     5        N� Title$  select4��5	      .��5      � ���	#FF463DB5 � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��50 �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ SpavochnikDG��5         
IsReadOnly .    AutoGenerateColumns .  $��0��6W   ���	#FF201D92���	#FF182DA2��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FF5A50C8��6#   � 5      $ 	#FF7B70FF��6#    � Offset$ 1Q�65   5      	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6Y   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *uchet.id_litsscheta+6Y     5      $
 ФИО��6%   $ 2* 6V    62   �� *sprav.full_name+6V     5      $
 
Адрес��6%   $ * 6V    64   �� *sprav.aadress+6V     5      $
 
Тариф��6%   $ * 6T    64   �� *uchet.tarif+6T     5      $"
 Кол-во киловатт��6%   $ * 6j    6>   �� *uchet.quantity_of_kvatt+6j     5      $$
 Кол-во абонентов��6%   $ * 6Y    6?   �� *Count+6Y     5      $
 
Сумма��6%   $ * 6L    64   �� *Sum+6L   5$      �� 5%   
   -   5        $��
vvodButton��5%      $��1��6<   $��694,10,0,10q�6I   $
��Left=�6^   $��96��6y   $��Bahnschrift Condensed)�6�   $��25(�6�   
�������
����������	#FF352CA4.��6�   
Назад6�   �� 5&   
   $
��Left=�6   $��1��6/   $
��Wrap=�6<   $��Center=�6P   $$��Bahnschrift SemiBold Condensed)�6k   $��16(�6�   $��59,0,0,0q�6�   $	��153��6�   
��������� 6�   $"�Группировка по ��6�   �� 6�    � Language$ ru-ru�6�   $�кваттам��6	  6  �� 5'   
   -   5        $��CBgroup��5'      $��Center=�6"   $��1��6?   $��Center=�6L   $	��339��6g   $��30��6s   
���������5(      �� 5)      $	 0,1&�6&   .��5*      � $ 	#FFF0F0F0��6#   � 5+      $ White��6#   $ 1Q�61   5,      .@�5.      �� $��По умолчанию��6   �� 5/      $	��0-5��6   �� 50      $
��6-10��6   �� 51      $��11-20��6   52      �� 53   
   -   5         ��Name$ vpered��53      $��1��66   $��585,10,0,10q�6C   $
��Left=�6X   $��96��6s   $��Bahnschrift Condensed)�6~   $��25(�6�   
�������
����������	#FF352CA4$��Вперед��6�   55      56      