   M S B A M L   `   `   `  ����D  @PhoneBook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:PhoneBook	PhoneBook  5   	       PhoneBook.DataView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:PhoneBook     5   	     � Title$  DataView��5   	   $	��450��6   $��848.015��6'    � WindowStartupLocation$ CenterScreen=�67    � Icon$ contact-book-icon-29.jpg��6\   .��5	      � ���	#FFE5C95D.+�5
   
   �� -   5        $�� ��5
      $
��Left=�6   $��	20,21,0,0q�67   $	��Top=�6J   $��47��6b   $��38��6m   ��5      �� 5       �� ImageSource$) #87-876153_back-button-png-brown.png��6   5      �� 5   
   -   5         ��Name$ 	btnUpdate��5      $y�Hidden=�6$   $��Update��68   $
��Left=�6I   $��
657,58,0,0q�6d   $	��Top=�6x   $��87��6�   $��14(�6�   $��Bookman Old Style)�6�   $
��Bold"�6�   $��31��6�   6�   �� 5   
   -   5         ��Name$ listContact��5      $
��Left=�6(   $	��309��6C   $��	6,101,0,0q�6P   $	��Top=�6c   $	��826��6{   ���	#FFD4E5DA �� View 5      �� 5      .P�5      �� $��Image��6%    �� Width$ 75��64    �� CellTemplate 5      �� 5      .R�5   "   �� $��Center=�6(   $
��Auto��6E   $��Center=�6S   $
��Auto��6n   ��6{   �� *
ImageSrc+5      5      �� 5      $
��Name��6%   $	 120��63   	 �� DisplayMemberBinding	 6?   �� *Name+�� 5      $��Contact Number��6%   $	 125��6=   	 6I   �� *ContactNumber+�� 5      $��Email��6%   $	 120��64   	 6@   �� *Email+�� 5      $��Gender��6%   $ 75��65   	 6@   �� *Gender+�� 5      $��Relationship��6%   $ 75��6;   	 6F   �� *Relationship+�� 5      $��Address��6%   $ 90��66   	 6A   �� *	Address+�� 5!      $
��Edit��6%   $ 65��63    5"      �� 5#      .R�5$   "   �� $
 Edit��69   -   5        $
��Edit��5$   )   ��6Z   �� 5%      5'      �� 5(      $��Delete��6%   $ 65��65    5)      �� 5*      .R�5+   "   �� $��Delete��6:   -   5        $��Delete��5+   )   ��6]   �� 6|   5,      5.      5/      51      53      54      