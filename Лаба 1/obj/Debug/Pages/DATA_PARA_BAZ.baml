   M S B A M L   `   `   `  ����E  AЛаба 1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Лаба_1
Лаба_1  5          Лаба_1.DATA_PARA_BAZ   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:Лаба_1     5        N� Title$  DATA_PARA_BAZ��5	      .��5      � ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ 	#FF6ADE7B��6   � 5      $ 	#FF004E0C��6    � Offset$ 1Q�61   5       � RowDefinitions 5   
   �� 5      $��4* �6   �� 5      $��* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DG��5         
IsReadOnly .    AutoGenerateColumns .  $��0��6`   ���	#FF123C03���	#FF2A790F	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6N   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *
id_schet+6N     5      $
 ФИО��6%   $ 2* 6P    62   �� *	full_name+6P     5      $
 
Адрес��6%   $ * 6P    64   �� *	aadress+6P   5      �� 5   
   -   5         ��Name$
 edit��5      $��1��62   $��190,21,0,19q�6?   $
��Left=�6T   $	��150��6o   $��Bahnschrift Condensed)�6{   $��30(�6�   
����������	#FF116D3D���	#FF00F9FF.��6�   Изменить6�   �� 5    
   -   5        $ 
dobavlenie��5       $��1��6&   $��
10,21,0,19q�63   $
��Left=�6G   $	��150��6b   $��Bahnschrift Condensed)�6n   $��30(�6�   
����������	#FF116D3D���	#FF00F9FF.��6�   Добавить6  �� 5!   
   -   5        $��
vvodButton��5!      $��1��6<   $��640,21,0,19q�6I   $
��Left=�6^   $	��150��6y   $��Bahnschrift Condensed)�6�   $��30(�6�   
����������	#FF116D3D���	#FF131B61.��6�   
Назад6�   �� 5"   
   -   5        $	��del��5"      $��1��6.   $��470,21,0,19q�6;   $
��Left=�6P   $	��150��6k   $��Bahnschrift Condensed)�6w   $��30(�6�   
����������	#FF116D3D���	#FF00F9FF.��6�   Удалить6�   5#      5$      