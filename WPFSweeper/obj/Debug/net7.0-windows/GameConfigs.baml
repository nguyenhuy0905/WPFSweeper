   M S B A M L   `   `   `  ����E  AWPFSweeper, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WPFSweeper
WPFSweeper  5   	       WPFSweeper.GameConfigs   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:WPFSweeper     5   	     � 
ResizeMode$  NoResize=�5   	    � Title$ Configure Game��5	   	   $	��250��6    $	��400��6-    � 	Resources 5
       �� 
TargetType �� Property �� Value��%�   '��       �� 5   
   " ��6   .�5      ��  � ��$ 25,10,25,10q�6'   �� 5       � ��$ Center=�64   �� 5       � ��$ Center=�62   5      5      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      $	��125 �6   �� 5      $
��271* �6   �� 5      $��4* �6   .+�5   
   �� .��6   
Difficulty5       �� 5!   
   $��2��6   .��6   
Load Saved5#      �� 5%   
   -   5        $��cmbDifficulty��5%      $��1��6(   $��25,10,21,10q�68    �� SelectedIndex$ 0��6M   $��Center=�6_   .@�5&      �� $
��Easy��6   �� 5'      $��Medium��6   �� 5(      $
��Hard��6   5)      �� 5+   
   -   5        $��
btnNewGame��5+      $��1��6#   $��1��63   $��30,10,26,10q�6@   .��6j   
New game5-      �� 5.   
   -   5        $��btnLoadSave��5.      $��25,10,21,10q�6$   $��2��69   $��1��6F   .��6l   
Load saved50      �� 51   
   -   5        $��btnQuit��51      $��1��6    $��3��60   $��75��6=   $��25��6H   $��170,11,0,10q�6T   $
��Left=�6i   .��6�   Exit53      54      55      