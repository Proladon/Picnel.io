   M S B A M L   `   `   `  ����D  @Picnel.io, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Picnel.io.User_ControlsPicnel.io.User_Controls  5      ,    &Picnel.io.User_Controls.Folder_Control   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:Picnel.io.User_Controls     5      $	��0,1q�5   6     � 	Resources  5	         control_delete �� 
TargetType  	normalBtn �� BasedOn �� Property �� Value  control_edit  	color_tag �� Triggers P� Property P� Value �� ElementName��%�  &	        7  &	 U     7  &	 �     7  �� 5
   
   " ��6'   8   .�5      ��  � �� �	#FFF355806+   5      �� 5   
   " ��6%   8   .�5      ��  � ��
 �����6+   5      �� 5   
   " ��6"   8   .�5      �� bg�� � ��
 �����67    5      P� 5       �@J�IsMouseOver . . �5      ��  � �� 63   �� *Value+$ bg��5      5      5      .��5      � 
�������	 � ColumnDefinitions	 5   
   �� 5!      $��9* �6   �� 5"      $
��131* �6   �� 5#      $	��52* �6   �� 5$      $	��52* �6   �� 5%      $	��25* �6   �� 5&      $	��25* �6   .+�5)   
   �� -   5        
 ��Name$
 
folderPath��5)      $y�	Collapsed=�6(   �� 5*   
   -   5         ��Name$ colorTag��5*      #��[ 6#    � ToolTip$ Open Folder��6F   $��0��6\   
������� � Cursor$
 Hand��6�   �� 5+   
   -   5        $
 akaLabel��5+      $��1��6&   $��NoName��66   $��Center=�6D   $
��Left=�6`   
���   �$��5,0,0,0q�6�   �� 5,   
   -   5        $ 
moveTo_Btn��5,   4   #��[ 6   $��M��6H   $ Move To This Folder��6T   $��2��6r   6�   �� 5-   
   -   5        $ 
copyTo_Btn��5-   4   #��[ 6   $��C��6H   $ Copy To This Folder��6T   $��3��6r   6�   �� 5.   
   -   5        $ edit_btn��5.   7   #��[ 6   $
��🔧��6I   $ Edit Control��6V   $��4��6m   6}   �� 5/   
   -   5        $ 
delete_Btn��5/   9   #��[  6   $	��❌��6M   $��5��6Y   6i   51      52      