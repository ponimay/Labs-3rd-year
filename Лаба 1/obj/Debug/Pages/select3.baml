   M S B A M L   `   `   `  ����E  AЛаба 1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Лаба_1
Лаба_1  5          Лаба_1.select3   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:Лаба_1     5        N� Title$  select3��5	      .��5      � ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ 	#FF998BFD��6   � 5      $ 	#FF3D2AC3��6    � Offset$ 1Q�61   5       � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��50 �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ SpavochnikDG��5         
IsReadOnly .    AutoGenerateColumns .  $��0��6W   ���	#FF404FCA���	#FF20279A��5      �� 5      $ 0.5,1&�6&   $ 0.5,0&�67   .��5      � $ 	#FF433588��6#   � 5      $ 	#FF927FEF��6#   $ 1Q�65   5      	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6Y   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *uchet.id_litsscheta+6Y     5      $
 ФИО��6%   $ 2* 6V    62   �� *sprav.full_name+6V     5       $
 
Адрес��6%   $ * 6V    64   �� *sprav.aadress+6V     5!      $
 
Тариф��6%   $ * 6T    64   �� *uchet.tarif+6T     5"      $"
 Кол-во киловатт��6%   $ * 6j    6>   �� *uchet.quantity_of_kvatt+6j     5#      $$
 Кол-во абонентов��6%   $ * 6Y    6?   �� *Count+6Y     5$      $
 
Сумма��6%   $ * 6L    64   �� *Sum+6L   5*      �� 5+   
   -   5        $��
vvodButton��5+      $��1��6<   $��
694,5,0,10q�6I   $
��Left=�6]   $��96��6x   $��Bahnschrift Condensed)�6�   $��25(�6�   
�������
����������	#FF433588.��6�   
Назад6�   �� 5,   
   $
��Left=�6   $��1��6/   $
��Wrap=�6<   $.��(Группировка по тарифу��6P   $��Center=�6m   $$��Bahnschrift SemiBold Condensed)�6�   $��16(�6�   $	��135��6�   
�������6�   �� 5-   
   $
��Left=�6   $��	244,0,0,0q�6/   $��1��6B   $
��Wrap=�6O   $3��-Группировка по лиц.счету��6c   $��Center=�6�   $$��Bahnschrift SemiBold Condensed)�6�   $��16(�6�   
�������6�   �� 5.   
   -   5        $��CBgroup��5.      $
��Left=�6"   $��	135,0,0,0q�6=   $��1��6P   $��Center=�6]   $��95��6x   $��30��6�   
���������5/      �� 50      $	 0,1&�6&   .��51      � $ 	#FFF0F0F0��6#   � 52      $ White��6#   $ 1Q�61   53      .@�55      �� $��По умолчанию��6   �� 56      $��100-300��6   �� 57      $��300-600��6   �� 58      $��600-999��6   59      �� 5:   
   -   5        $��CombO��5:      $
��Left=�6    $��	400,0,0,0q�6;   $��1��6N   $��Center=�6[   $	��142��6v   $��30��6�   
���������5;      �� 5<      $	 0,1&�6&   .��5=      � $ 	#FFF0F0F0��6#   � 5>      $ White��6#   $ 1Q�61   5?      .@�5A      �� $��По умолчанию��6   �� 5B      $��1 лиц. счет��6   �� 5C      $��2 лиц. счет��6   �� 5D      $��3 лиц. счет��6   �� 5E      $��4 лиц. счет��6   �� 5F      $��5 лиц. счет��6   �� 5G      $��6 лиц. счет��6   �� 5H      $��7 лиц. счет��6   �� 5I      $��8 лиц. счет��6   �� 5J      $��9 лиц. счет��6   �� 5K      $��10 лиц. счет��6   5L      �� 5M   
   -   5         ��Name$ 	vperedBtn��5M      $��1��6<   $��
579,5,0,10q�6I   $
��Left=�6]   $��96��6x   $��Bahnschrift Condensed)�6�   $��25(�6�   $��Вперед��6�   
�������
����������	#FF4335886�   5N      5O      