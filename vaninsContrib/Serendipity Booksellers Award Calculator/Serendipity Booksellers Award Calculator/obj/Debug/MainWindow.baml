   M S B A M L   `   `   `  ����c  _Serendipity Booksellers Award Calculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullc6clr-namespace:Serendipity_Booksellers_Award_Calculator(Serendipity_Booksellers_Award_Calculator  5   	   9    3Serendipity_Booksellers_Award_Calculator.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Hlocal6clr-namespace:Serendipity_Booksellers_Award_Calculator     5   	     � Title$.  (Serendipity Booksellers Award Calculator��5	   	   $	��450��6:   $	��800��6G   $	��800��6S   $	��450��6b    � 	Resources 5
       
  Output �� 
TargetType �� Property �� Value  InputHeader  DropDown��%D  &	        &	 �     &	 \    �� 5   
   " ��5      .�5      ��  � ��$ Center=�64   �� 5       � ��$ Center=�62   �� 5       � ��$
 Wrap=�6-   �� 5       � ��$ 10q�6'   5      �� 5   
   " ��5      .�5      ��  � ��$ Bottom=�62   �� 5       � ��$
 Bold"�6+   �� 5       � ��$ 10q�6'   5      �� 5   
   " ��5      .�5      ��  � ��$ Center=�64   �� 5       �@��SelectedIndex$ 0��6.   �� 5       � ��$ 10q�6'   �� 5       � ��$	 200��6&   5      5      .��5       �  � ColumnDefinitions 5!   
   �� 5"      �� 5#       � RowDefinitions 5%   
   �� 5&      $��45��6   �� 5'      $��45��6   �� 5(      $��7* �6   �� 5)      $��2* �6   $��75��6(   .+�5+   
   �� $��Number of Books Purchased��5,      #��[ 5-      $��0��5.      $��0��5/      �� 50   
   $ ��Month Books Were Purchased��51      #��[ 52      $��1��53      $��0��54      �� 55   
   -   5         ��Name$ Total��56      $-��'You've earned 0 points so far this year��57      #��[  58      $��20(�59      $��1��5:      $��4��5;      �� 5<   
   -   5        $��CurrentMonthlyPoints��5=      $-��'You currently have 0 points this month.��5>      #��[  5?      $��40(�5@      $��2��5A      $��2��5B      �� 5C   
   -   5        $��	BookInput��5D      #��[ 5E      $��0��5F      $��1��5G      �� 5H   
   -   5        $��
MonthInput��5I      #��[ 5J      $��1��5K      $��1��5L      5M      �� 5N   
   -   5        $��Submit��5O      $��Record Points��5P      $��30(�5Q      $��0��5R      $��4��5S      $��10q�5T      5U      5V      5W      