   M S B A M L   `   `   `  ����E  AЛаба 1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Лаба_1.PagesЛаба_1.Pages  5      *    $Лаба_1.Pages.dobavlenieUchetnaya   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:Лаба_1.Pages     5        N� Title$  dobavlenieUchetnaya��5	      .��5      � ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ 	#FF8770D8��6   � 5      $ 	#FF5740AB��6    � Offset$ 1Q�61   5       � ColumnDefinitions 5   
   �� 5      $	��59* �6   �� 5      $	��21* �6    � RowDefinitions 5   
   �� 5      $
��250* �6   �� 5      $
��250* �6   .+�5   
   �� -   5         ��Name$ litsschetttt��5       � 
InputScope$ Number��6(   $��0��6�   $��
0,56,0,115q�6�   $	��500��6�   $��Center=�6�   $��Bahnschrift Condensed)�6�   $��30(�6�   ��6d   �� *id_litsscheta+6  �� 5   
   -   5        $ monthhhh��5      $��
0,155,0,10q�6G   $	��500��6[   $��Center=�6g   $��Bahnschrift Condensed)�6�   $��30(�6�   ��6$   �� *month_of_payment+6�   �� 5   
   -   5        	 ��Name$	 dobavit��5      $��1��6;   $��28,192,87,185q�6K   $��Bahnschrift Condensed)�6b   $��20(�6�   $��2��6�   
����������	#FF624BB5.��6�   Добавить6�   �� 5   
   -   5        $	 nazad��5      $��1��67   $��1��6G   $��
85,177,0,0q�6T   $��Bahnschrift Condensed)�6h   $��20(�6�   ���	#FF6049B3
�������.��6�   
Назад6�   �� 5   
   $
��Left=�6   $��	45,26,0,0q�6/   $
��Wrap=�6B   $	��Top=�6V   $��Bahnschrift Condensed)�6n   $��20(�6�   $	��121��6�   $��27��6�   �� 6�   
 � Language$
 ru-ru�6�   $�id лиц. счёта��6�   �� 6�   �� 6�   $
 ru-ru�6�   6  �� 5   
   $
��Left=�6   $��
45,131,0,0q�6/   $
��Wrap=�6C   $	��Top=�6W   $��Bahnschrift Condensed)�6o   $��20(�6�   $	��137��6�   $��24��6�   �� 6�   $
 ru-ru�6�   $�Месяц оплаты��6�   �� 6�   �� 6�   $
 ru-ru�6�   6  �� 5    
   $
��Left=�6   $��	45,10,0,0q�6/   $
��Wrap=�6B   $	��Top=�6V   $��Bahnschrift Condensed)�6n   $��20(�6�   $	��137��6�   $��24��6�   $��1��6�   �� 6�   $
 ru-ru�6�   $�
Тариф��6�   �� 6�   �� 6�   $
 ru-ru�6�   6  �� 5!   
   -   5        $ Tariiiiffff��5!      $��
0,34,0,131q�6?   $	��500��6S   $��Center=�6_   $��Bahnschrift Condensed)�6|   $��30(�6�   $��1��6�   ��6'   �� *tarif+6�   �� 5"   
   $
��Left=�6   $��
45,113,0,0q�6/   $
��Wrap=�6C   $	��Top=�6W   $��Bahnschrift Condensed)�6o   $��20(�6�   $	��137��6�   $��24��6�   $��1��6�   �� 6�   $
 ru-ru�6�   $"�Кол-во киловатт��6�   �� 6�   �� 6   $
 ru-ru�6  6  �� 5#   
   -   5        $ kvatti��5#      $��
0,141,0,24q�6F   $	��500��6Z   $��Center=�6f   $��Bahnschrift Condensed)�6�   $��30(�6�   $��1��6�   ��6"   �� *quantity_of_kvatt+6�   5$      5%      