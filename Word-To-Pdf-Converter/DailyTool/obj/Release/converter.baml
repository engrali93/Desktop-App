   M S B A M L   `   `   `  ���� D  @DailyTool, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:DailyTool	DailyTool      DailyTool.converter   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     )localclr-namespace:DailyTool     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006       N� Title$  	converter�� N� 
Background �#181735.���  � RowDefinitions �� $��45 ��� �� $��25 �.+�� -   $��2�����#0F0F2D � ColumnDefinitions �� �� �� �� �� �� �� �� �� �� �� �� .+��� $��1��$��Center=�$��Center=�$��Fonts/#Dosis)�$��Medium"�
�������$��MA Corp.���� -   $��11��$��2��$��0,0,10,0q�$
��Exit�� � Cursor$
 Hand��$��10(�$��Heavy"�
�����������  �� 
TargetType" ��.���  �� Property � �� �� Value$ Fonts/#Dosis)���  � �� �#FE6584��  �@�Cursor$
 Hand�� �� Triggers P� 	 P� Property	 �@J�IsMouseOver
 P� Value
 . . ���  � �� �#FF4C70����  �� 
TargetType" ��.R��� $��60��$��25��#��z�� �� CornerRadius$ 12��._��� $��Center=�$��Center=��� $��1��$��20q�$��Center=�.+��� .+��� $��0,0,0,60q� �� Orientation$ 
Horizontal=�.+��� $��70��$��70�� �� BitmapScalingMode$
 Fant=�$��Assets/Component.png���� $��Center=�$��Fonts/#Dosis)�$��35(�$��Medium"�
�������$��   MA Corp.���� $��0,0,0,40q�$��Fonts/#Dosis)�$��25(�$��Medium"�
�������$!��Convert Your Files Into PDF���� $ 
Horizontal=�.+��� $��0,0,10,0q�$��Fonts/#Dosis)�$��17(�$��Medium"�
�������$��Location���� -    ��Name$ 	txtEditor��$	��320��$��23�� �� TextWrapping$
 Wrap=��� -   $��	10,0,10,0q�$��	Open File��$
 Hand��$��14(�$��Medium"�
����������� " ��.���  � ��$ Fonts/#Dosis)���  � �� �#FE6584��  �@�Cursor$
 Hand�� P� 	 �@J�IsMouseOver
 . . ���  � �� �#FF4C70���� " ��.R��� $	��100��$��22��#��z��$ 12��._��� $��Center=�$��Center=��� $��0,15,0,0q�$ 
Horizontal=�.+��� -   $��	67,0,10,0q�$��Convert��$
 Hand��$��14(�$��Medium"�
����������� " ��.���  � ��$ Fonts/#Dosis)���  � �� �#FE6584��  �@�Cursor$
 Hand�� P� 	 �@J�IsMouseOver
 . . ���  � �� �#FF4C70���� " ��.R��� $	��100��$��25��#��z��$ 12��._��� $��Center=�$��Center=�� $��2��.+�� -   $
��load��$��10��$��	0,0,0,-15q� � Maximum$	 100Q� � Minimum$ 0Q���Z� ��Z� ����  �� 
StartPoint$ 0.5,0&� �� EndPoint$ 0.5,1&�.���  � Offset$ 0Q� � Color$ 	#FFFE6584��� $ 1Q�$ 	#FFFF3A62��� $��2��$��1��$��600,-365,-610,85q� K� ZIndex$ -1��z���  �� Angle$ 50Q�.+��� $��-350,250,-255,-250q�$ 
Horizontal=�.+��� .+��� $	��700��$��35��$��	150,0,0,0q����#3DDDC2$ 20���� $	��700��$��35��$��0,15,0,0q����#FC6586$ 20���� $	��700��$��35��$��	75,15,0,0q����#383660$ 20���� .+��� $	��700��$��35��$��	150,0,0,0q����#3DDDC2$ 20���� $	��700��$��35��$��0,15,0,0q����#FC6586$ 20���� $	��700��$��35��$��	75,15,0,0q����#383660$ 20��