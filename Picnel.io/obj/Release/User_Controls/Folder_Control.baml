   M S B A M L   `   `   `  ���� D  @Picnel.io, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Picnel.io.User_ControlsPicnel.io.User_Controls  ,    &Picnel.io.User_Controls.Folder_Control   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     7local%clr-namespace:Picnel.io.User_Controls     $	��0,1q�  � 	Resources     control_delete �� 
TargetType  	normalBtn �� BasedOn �� Property �� Value  control_edit  	color_tag �� Triggers P� Property P� Value �� ElementName��%  &	        7  &	 0     7  &	 Z     7  �� " ��8   .���  � �� �	#FFF35580�� " ��8   .���  � ��
 ������� " ��8   .��� bg�� � ��
 ����� P�  �@J�IsMouseOver . . ���  � �� �� *Value+$ bg��.��� 
�������	 � ColumnDefinitions	 �� $��9* ��� $
��131* ��� $	��52* ��� $	��52* ��� $	��25* ��� $	��25* �.+��� -   
 ��Name$
 
folderPath��$y�	Collapsed=��� -    ��Name$ colorTag��#��[  � ToolTip$ Open Folder��$��0��
������� � Cursor$
 Hand���� -   $
 akaLabel��$��1��$��NoName��$��Center=�$
��Left=�
���   �$��5,0,0,0q��� -   $ 
moveTo_Btn��#��[ $��M��$ Move To This Folder��$��2���� -   $ 
copyTo_Btn��#��[ $��C��$ Copy To This Folder��$��3���� -   $ edit_btn��#��[ $
��🔧��$ Edit Control��$��4���� -   $ 
delete_Btn��#��[  $	��❌��$��5��