   M S B A M L   `   `   `  ���� F  BSPZ-Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:SPZ_Project.MVVM.ViewSPZ_Project.MVVM.View  (    "SPZ_Project.MVVM.View.RecoveryView   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     5local#clr-namespace:SPZ_Project.MVVM.View     
�������  � 	Resources     FocusVisual �� Property �� Value �� StrokeDashArray J� SnapsToDevicePixels  Button.Static.Background �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 
 RoundedButtonStyle �� 
TargetType �� 
TargetType ��Name	 �� CornerRadius
 ��Name �� Triggers P� Property P� Value �� 
TargetName��%�  &	        &	 R     &	 g     &	 |     &	 �     &	 �     &	 �     &	 �     &	 �     &		 �     &	
     7   7  7  7  7  7  7  7  7  7 	 �� .���  � �� �� .R��� $��2q�$	 1 2R�#��� ��$
 true��$��1���� $ 	#FFDDDDDD���� $ 	#FF707070���� $ 	#FF66A397���� $ 	#FF3C7FB1���� $ 	#FFC4E5F6���� $ 	#FF2C628B���� $ 	#FFF4F4F4���� $ 	#FFADB2B5���� $ 	#FF838383���� " ��.���  �@�FocusVisualStyle8   ��  � ��8  ��  � ��8  ��  � ��# � ����  � ��$ 0q���  � ��$ Center=���  � ��$ Center=���  � ��$ 1q���  � �� �� " ��.R��� $ border��$	 2��#��z��#��z��#��z��$
 true��._��� $
 contentPresenter��$|�False��#��z��#��z��$
��True��# z #��z�� P�  �@��IsDefaulted$
 true��. ��� $ border��# � �� � ��P�  �@J�IsMouseOver$
 true��. ��� $ border��8   � ���� $ border��8   � ��P�  � ��$
 true��. ��� $ border��8   � ���� $ border��8   � ��P�  � {�$ false��. ��� $ border��8   � ���� $ border��8   � ���� $ contentPresenter��8 	  � ��.���� 
�������.+�� ���#EEEEEE$��Center=� � ColumnDefinitions �� $	��400 ��� $	��400 � � RowDefinitions �� $	��150 ��� .+��� 
���   �$��0��$��0��$��0q�._��� $��
80,20,0,20q�.+��� -   $��Sourcelabel��  RChooseSource#���  $	��200��$��30��$��	0,20,0,10q�$
��6, 3q�$��16(�
���   �$	��0.4q����#e7f1ef�� -    ��Name$ diskComboBox��$��16(�$	��200��$��30�� �� SelectedIndex$ 0������ .R��� ����  � ToolTip _� 
�������
���   �$��12(�.����   TTCS#���  �� $��0��$��1��
���   �$��0q�._��� $��
0,20,80,20q�.+��� -   $��Destinationlabel��  RDestination#���  $	��200��$��30��$��	0,20,0,10q�$
��6, 3q�$��16(�
���   �$	��0.4q����#e7f1ef�� -    ��Name$ ChooseDestinationButton��#��� 
   RDestinationChoose#���  $��30��$	��200�����#408c7d
�������$��SemiBold"�$��	Meiryo UI)� _� 
�������
���   �$��12(�.����   TTCD#���  �� 
���   �$��0q�._�� -   $��CheckBoxGrid��$	��250��$	��700��
�������$��Center=� �� $
��311* ��� $
��146* ��� $	��53* ��� $
��190* �.+���   RSelectFormats#���  $
��Left=�$��25(�$��	Meiryo UI)�$��	260,0,0,0q�$��3�� _� 
�������
���   �$��12(�.����   TTSF#���  ��  
 RImage#���  $��	20,40,0,0q�$��	Meiryo UI)�$��4���� -   $��CBjpg��$
��.jpg��$��
20, 80,0,0q�$��4���� -   $��CBjpeg��$��.jpeg��$��20, 100,0,0q�$��4���� -   $��CBjpe��$
��.jpe��$��20, 120,0,0q�$��4���� -	   $��CBpng��$
��.png��$��20, 140,0,0q�$��4����  
 RVideo#���  $��9,40,0,0q�$
��Left=�$��	Meiryo UI)�$��1���� -
   $��CBmp3��$
��.mp3��$��9,80,0,0q�$
��Left=�$��1���� -   $��CBmp4��$
��.mp4��$��	9,100,0,0q�$
��Left=�$��1���� -   $��CBmpeg��$��.mpeg��$��	9,120,0,0q�$
��Left=�$��1���� -   $��CBmpg��$
��.mpg��$��	9,140,0,0q�$
��Left=�$��1���� -   $��CBm4a��$
��.m4a��$��	9,160,0,0q�$
��Left=�$��1���� -   $��CBmov��$
��.mov��$��	9,180,0,0q�$
��Left=�$��1���� -   $��CBwma��$
��.wma��$��	9,200,0,0q�$
��Left=�$��1���� -   $��CBwmv��$
��.wmv��$��	9,220,0,0q�$
��Left=�$��1����   RDoc#���  $��
100,40,0,0q�$
��Left=�$��	Meiryo UI)�$��3���� -   $��CBpdf��$
��.pdf��$��
110,80,0,0q�$
��Left=�$��3���� -   $��CBodf��$
��.odf��$��110,100,0,0q�$
��Left=�$��3���� -   $��CBdoc��$
��.doc��$��110,120,0,0q�$
��Left=�$��3���� -   $��CBdocx��$��.docx��$��110,140,0,0q�$
��Left=�$��3���� -   $��CBzip��$
��.zip��$��110,160,0,0q�$
��Left=�$��3���� $
��Left=�$��1��$��
150,-6,0,0q�
���   �$	��Top=�$	��400��$��4���� 
���   �$��0q�._�� ���#EEEEEE$	��100��.+��� $��Center=�$��1��$��0,0,0,0q�
�������$	��Top=�$	��720���� -   $ RestoreDataButton��#��� 
   RRD#���  $��50��$	��200�����#408c7d$��14(�$��SemiBold"�$��0,18,0,0q�$	��Top=�
�������$��	Meiryo UI)� _� 
�������
���   �$��12(�.����   TTDM#���  