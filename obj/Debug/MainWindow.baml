   M S B A M L   `   `   `  ����A  =Diplom, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:DiplomDiplom  5   	       Diplom.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Diplom     5   	     � Title$  
MainWindow��5       � WindowStartupLocation$ CenterScreen=�6   $
��3000��6e   $	��900��6v   $	��400��6�    � WindowStyle$
 None=�6�   .��5
   
   � -   5        
������ � RowDefinitions 5   
   �� 5      $��70 �6   6*   �� 5      $��* �6   6)   .+�5   
   �� $|��vИНСТРУМЕНТАЛЬНЫЕ СРЕДСТВА РАЗРАБОТКИ ПРОГРАММНОГО ОБЕСПЕЧЕНИЯ��6   $	��Top=�6Y    �� TextAlignment$ Center=�6q   $��Arial Rounded MT Bold)�6�   $��20(�6�   
��� ���$��140,20,100,0q�6�   $
��Auto��6�    � 5   
   -   5        $��	MainFrame��5      $��1��6!   5      �� 5   
   
������ $��Right=�6*   $��	0,5,65,35q�6F   $��30��6Y   .��5      �� -   5        $��30��5      $��30��6    $��Resources/roll up.png��6,   6k   5      �� 5   
   
������ $��Right=�6*   $��	0,5,35,35q�6F   $��30��6Y   $��30��6e   .��5      �� -   5        $��Center=�5      $��Center=�6/   $��25��6L   $��25��6W   $��Resources/full screen.png��6c   6�   5      �� 5   
   $��Right=�6   $��0,5,5,35q�6-   $��30��6?   $��30��6K   .��5      �� -   5        $��Center=�5      $��Center=�6/   $��25��6L   $��25��6W   $��Resources/Close.png��6c   6�   ��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � �� �� Value
 ���� 63   �� 5       � �� 5      �� 5       �� 
TargetType" ��6.   .R�5    "   �� #��z��6)   ._�5!   &   �� $��Center=�67   $��Center=�6T   5"   #   5#      5%      	 �� Triggers	 5&      P� 5'      
 P� Property
 �@J�IsMouseOver P� Value . . �5(      ��  � ��
 �  ��6;   5)      5+      5-      5.      5/      