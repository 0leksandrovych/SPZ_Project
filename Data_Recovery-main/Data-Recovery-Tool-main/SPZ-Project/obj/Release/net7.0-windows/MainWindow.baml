   M S B A M L   `   `   `  ���� F  BSPZ-Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SPZ_ProjectSPZ_Project  G(clr-namespace:SPZ_Project.MVVM.ViewModelSPZ_Project.MVVM.ViewModel      SPZ_Project.MainWindow   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     +localclr-namespace:SPZ_Project     >	viewModel(clr-namespace:SPZ_Project.MVVM.ViewModel     -   $	��540��$	��800��  � WindowStyle$
  None=� � 
ResizeMode$ NoResize=�
������  � AllowsTransparency$
 True�� � WindowStartupLocation$ CenterScreen=� � Title$ Data Recovery Tool�� � 	Resources    FocusVisual �� Property �� Value �� StrokeDashArray	 J� SnapsToDevicePixels  Button.Static.Background
 �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 
 CntxMenuButton �� 
TargetType �� 
TargetType ��Name �� CornerRadius ��Name �� Triggers P� Property P� Value �� 
TargetName��%�  &	        &	 R     &	 g     &	 |     &	 �     &	 �     &	 �     &	 �     &	 �     &		 �     &	
     7   7  7  7  7  7  7  7  7  7 	 �� .���  � �� �� .R��� $��2q�$	 1 2R�#��� ��$
	 true��$��1���� $
 	#FFDDDDDD���� $
 	#FF707070���� $
 	#FFBEE6FD���� $
 	#FF3C7FB1���� $
 	#FFC4E5F6���� $
 	#FF2C628B���� $
 	#FFF4F4F4���� $
 	#FFADB2B5���� $
 	#FF838383���� " ��.���  �@�FocusVisualStyle8   ��  � ��8  ��  � ��8  ��  � ��# � ����  � ��$ 1q���  � ��$ Center=���  � ��$ Center=���  � ��$ 1q���  � �� �� " ��.R��� $ border��$ 20��#��z��#��z��#��z��$
	 true��._��� $ contentPresenter��$|�False��#��z��#��z��$
��True��#	 z	 #��z�� P�  �@��IsDefaulted$
 true��. ��� $ border��# � �� � ��P�  �@J�IsMouseOver$
 true��. ��� $ border��8   � ���� $ border��8   � ��P�  � ��$
 true��. ��� $ border��8   � ���� $ border��8   � ��P�  � {�$ false��. ��� $ border��8   � ���� $ border��8   � ���� $ contentPresenter��8 	  � �� � DataContext .  (SPZ_Project.MVVM.ViewModel.MainViewModel  .���� ���#fff._��  � ColumnDefinitions ��  � RowDefinitions �� $��50 ��� .+���  �� Orientation$ 
Horizontal=�$��50��$	��Top=����#082949.+��  �� $	��795 �.+��� $ 
Horizontal=�$	��Top=�$
��Left=�.+��� $��Resource\datarec.png��$��35��$��5q�$
��Left=�$��Center=��� 
�������$��Data Recovery Master��$��12(�$
��Left=�$��Center=�$��Cooper Black)��� $ 
Horizontal=�$��Center=�$��Right=�.+��� $ 
Horizontal=�$��Center=�$��Center=�.+��� -    ��Name$ AboutShowButton��$��30��$��30��$��
0, 2, 9, 0q�
������ $��0q����� $��Resource\info.png��$��25��$��Center=�$��Center=��� -   $ SettingsShowButton��$��30��$��30��$��
0, 2, 0, 0q�
������ $��0q����� $��Resource\gear.png��$��25��$��Center=�$��Center=��� -   $ MinimizeAppButton��#��� 
 $��-��$��30��$��30��$��Right=�
�������
������ $��20(�$��5,0,0,0q�$��0q��� -   $��CloseAppButton��#��� 
 $��x��$��30��$��30��$��Right=�$	��Top=�
�������
������ $��20(�$��5,0,0,0q�$��0q��� ���#d3d3d3$��1��$��	199,0,0,0q�$��1���� $��1��$��1��$��0q����� *CurrentView+