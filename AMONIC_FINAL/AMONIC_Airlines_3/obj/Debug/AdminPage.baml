   M S B A M L   `   `   `  ����L  HAMONIC_Airlines_3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:AMONIC_Airlines_3AMONIC_Airlines_3  5      !    AMONIC_Airlines_3.AdminPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:AMONIC_Airlines_3     5      -   5          N� Title$  	AdminPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��1.3* �6   �� 5      $��3* �6   �� 5      $	��20* �6   �� 5      $��4* �6   .+�5   
   o� .@�5      m� -   5         m�Name$ AddUserMenuBt��5      $/��)Добавить пользователя��6.   6M   m� 5      -   5        $ 
ExitMenuBt��5      $��
Выход��6+   6:   5      �� 5   
   $��1��6    �� Orientation$ 
Horizontal=�6"   .+�5      �� $��	Офис:��6   $��30��6$   $��0,0,10,0q�60   �� 5      -   5         ��Name$ 
cb_offices��5      $	��150��6+   $��30��67   $��Center=�6C   $��15(�6e    �� SelectedIndex$ 0��6�   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dg_Users��5      $��2��6%   $��10,10,10,10q�62      AutoGenerateColumns .     CanUserAddRows .  	   CanUserDeleteRows	 .  
   CanUserReorderColumns
 .   � 	Resources 5      &   AMONIC_Airlines_3.ColorConverter   ColorConverter��%   &	          5      6'   5         RowStyle 5      �� 5        �� 
TargetType)  #System.Windows.Controls.DataGridRow"  6   .�5!      ��  �� Property � �� �� Value 63   �� *
User_Color+ �� 	Converter# [  5"         Columns 5$      0  *System.Windows.Controls.DataGridTextColumn  5%      ,  &System.Windows.Controls.DataGridColumn   Header$ Имя��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 110 62   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6>   ��  �� Path$ User_FirstName�  5&      $ Фамилия��6%   $	 110 66    6B   �� $ User_LastName�  5'      $ Возраст��6%   $ 60 66    6A   �� $ User_Age�  5(      $ Роль��6%   $	 175 63    6?   �� $ 	User_Role�  5)      $ Email ��6%   $	 200 65    6A   �� $ 
User_Email�  5*      $ Офис��6%   $ * 63    6=   �� $ 
User_Title�  5+      $ Active��6%      
Visibility$ Hidden=�65    6I   �� $ 
User_Color�5-      �� 5.   
   $��3��6   $ 
Horizontal=�6"   $	��Top=�6;   .+�5/      �� -   5         ��Name$ bt_changeRole��5/      $��30��6,   $	��110��68   $��Изменить роль��6D   $��15(�6\   $��10,0,0,0q�6j   6|   �� 50      -   5        $ bt_EnDiLogin��50      $��30��6+   $	��193��67   $4��.Разрешить/запретить вход��6C   $��15(�6f   $��80,0,0,0q�6t   6�   51      52      53      