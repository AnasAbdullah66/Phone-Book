   M S B A M L   `   `   `  ����D  @PhoneBook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:PhoneBook	PhoneBook  5   	       PhoneBook.ContactDetails   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:PhoneBook     5   	     � Title$  ContactDetails��5   	   $��494.776��6    $��661.493��61    � WindowStartupLocation$ CenterScreen=�6A   $��Bookman Old Style)�6f   $��14(�6�    � Icon$ contact-book-icon-29.jpg��6�   ��5	      �� 5
   
    �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6/   .��5      �  � Color$ 	#FFDDD198��6    � Offset$ 0Q�6-   � 5      $ 	#FFA98E0A��6   $ 1Q�6-   5      .��5      � .+�5   
   �� -   5         ��Name$ btnSave��5      $
��Save��6"   $
��Left=�61   $��219,402,0,0q�6L   $	��Top=�6a   $	��113��6y   $��31��6�   $��18(�6�   $
��Bold"�6�   ���	#FF6173F36�   �� 5   
   -   5         ��Name$ 	cmbGender��5      $
��Left=�6&   $��173,175,0,0q�6A   $	��Top=�6V   $	��234��6n   $��16(�6z   �� 5   
   $
��Left=�6   $��
19,147,0,0q�6/   $
��Wrap=�6C   $��Contact Number :��6W   $	��Top=�6o   $
��Bold"�6�   $��16(�6�   �� 5   
   -   5        	 ��Name$	 
txtContact��5      $
��Left=�6&   $��23��6A   $��173,144,0,0q�6M   
 �� TextWrapping$

 Wrap=�6b   $	��Top=�6v   $	��234��6�   $��16(�6�   �� 5   
   $
��Left=�6   $��
181,57,0,0q�6/   $
��Wrap=�6C   $��Contact Information��6W   $	��Top=�6r   $��28(�6�   $
��Bold"�6�    �� TextAlignment$ Center=�6�   ��6�   Z� �� 5   
   $
��Left=�6   $��
95,178,0,0q�6/   $
��Wrap=�6C   $��Gender :��6W   $	��Top=�6g   $
��Bold"�6   $��16(�6�   �� 5   
   $
��Left=�6   $��108,116,0,0q�6/   $
��Wrap=�6D   $��Name :��6X   $	��Top=�6f   $
��Bold"�6~   $��16(�6�   �� 5   
   -   5        $	 txtName��5      $
��Left=�6#   $��23��6>   $��173,113,0,0q�6J   $

 Wrap=�6_   $	��Top=�6s   $	��234��6�   $��16(�6�   �� 5   
   $
��Left=�6   $��107,213,0,0q�6/   $
��Wrap=�6D   $��Email :��6X   $	��Top=�6g   $
��Bold"�6   $��16(�6�   �� 5   
   -   5        $	 txtEmail��5      $
��Left=�6$   $��23��6?   $��173,210,0,0q�6K   $

 Wrap=�6`   $	��Top=�6t   $	��234��6�   $��16(�6�   �� 5   
   $
��Left=�6   $��
47,246,0,0q�6/   $
��Wrap=�6C   $��Date of Birth :��6W   $	��Top=�6n   $
��Bold"�6�   $��16(�6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ 
datePicker��5      $
��Left=�6)   $��173,242,0,0q�6D   $	��Top=�6Y   $	��234��6q      FirstDayOfWeek$ Friday=�6}   $��16(�6�   �� 5   
   $
��Left=�6   $��
90,309,0,0q�6/   $
��Wrap=�6C   $��	Address :��6W   $	��Top=�6h   $
��Bold"�6�   $��16(�6�   �� 5   
   -   5        $	 
txtAddress��5      $
��Left=�6&   $��67��6A   $��173,306,0,0q�6M   $

 Wrap=�6b   $	��Top=�6v   $	��234��6�   $��16(�6�   �� 5   
   -   5        $ cmbRelation��5      $
��Left=�6(   $��173,272,0,0q�6C   $	��Top=�6X   $	��234��6p   $��16(�6|   �� 5   
   $
��Left=�6   $��
49,275,0,0q�6/   $
��Wrap=�6C   $��Relationship :��6W   $	��Top=�6m   $
��Bold"�6�   $��16(�6�   �� 5    
   -	   5        $ btnUploadImage��5       $��Upload Image��6)   $
��Left=�6@   $��452,335,0,0q�6[   $	��Top=�6p   $	��150��6�   $��31��6�   $��18(�6�   $
��Bold"�6�   ���	#FF6173F36�   �� 5!   
   -
   5         ��Name$ FormPic��5!      $
��Left=�6!   $	��151��6<   $��457,142,0,0q�6I   $	��Top=�6^   $	��140��6v   $ ��blank-male-silhoue2tte.jpg��6�    J� OpacityMask 5"      �� 5#       �� ImageSource$  blank-male-silhoue2tte.jpg��6   5%      �� 5&   
   -   5        $�� ��5&      $
��Left=�6   $��	20,21,0,0q�67   $	��Top=�6J   $��47��6b   $��38��6m   ��5'      �� 5(      $) #87-876153_back-button-png-brown.png��6   5*      5,      5-      