   M S B A M L   `   `   `  ����D  @DbTestApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:DbTestApp.PagesDbTestApp.Pages  5      "    DbTestApp.Pages.StudentsPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:DbTestApp.Pages     5        N� Title$  StudentsPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��6* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��2* �6   �� 5      $��6* �6   .+�5   
   � $��0��6      
LeftColumn#��[  6   $��2��6C   .+�5      ��   	LeftPanel#��[ 6   .+�5      �� $1��+Сортировка по предмету:��6     TextLeftPanel#��[ 6;   �� 5      -   5         ��Name$ cboxPredmet��5       �� 
IsEditable . $��10q�5      5      �� 5      $%��Поиск по фамилии:��6   #��[ 65   �� 5      -   5         ��Name$ 
tboxSearch��5      $��5q�6.   69   �� 5       $-��'Сортировка по баллам:��6   #��[ 69   	� 5!      -   5        $��rbtnAsc��5!   7   $!��По возрастанию��6   $��5q�6F   6Q   	� 5"      -   5        $��rbtnDesc��5"   4   $��По убыванию��6   $��5q�6D   6O   �� 5$      -   5         ��Name$ btnRes��5$   1   $��Анализ данных��6   $��5q�5%      �� 5&      -   5         ��Name$ lboxRes��5&      $	��150��6+   $	��110��67   $��5q�5'      5(      5)      � 5+   
   $��1��6   $��1��6   .+�5,      ��  �� Orientation$ 
Horizontal=�6   $
��Left=�62   $��Center=�5-      .+�5.      �� -   5        $ btnAdd��5.      $��Добавить��6)   6<   �� 5/      -   5        $ 	btnDelete��5/      $��Удалить��6,   6>   �� 50      -	   5        $ btnRef��50      $��Обновить��6)   6<   51      52      &   System.Windows.Controls.DataGrid  54   
   -
   5        	  Name$	 dgStud��54      
   AutoGenerateColumns
 .  $��0��55      $��1��6       Columns 56      0  *System.Windows.Controls.DataGridTextColumn  57      ,  &System.Windows.Controls.DataGridColumn   Header$% Фамилия студента��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 59   %   1  +System.Windows.Controls.DataGridBoundColumn   Binding 58   %   �� *Фамилия+59   %     5:      $ Предмет��6%   $ * 5<   %    5;   %   �� *Предмет+5<   %     5=      $ 
Школа��6%   $ * 5?   %    5>   %   �� *
Школа+5?   %     5@      $ 
Баллы��6%   $ * 5B   %    5A   %   �� *
Баллы+5B   %   5D      5E      5F      