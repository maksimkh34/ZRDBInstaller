   M S B A M L   `   `   `  ���� I  EZRDB Installer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:DBaInstallerDBaInstaller      DBaInstaller.Installation   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     ,localclr-namespace:DBaInstaller     -     � Title$  Установка ZRDB��$	��460��$	��600�� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=�.���  � RowDefinitions �� $
��412* ��� $
��auto �.+��� -   $��continueButton��$��1��$��Right=�$��Bottom=�$	��100��$��20��$��7q�${�False��.��Продолжить�� $��1��$��Right=�$��Bottom=�$	��100��$��20��$��	0,0,113,7q�${�False��.��Закрыть� -    �Name$ 
simpleGrid��$��0�� � ColumnDefinitions �� $	��140 ��� .+�� -   $��	PanelGrid�����#B5B32B �� �� �� �� �� �� $	��220 �.+�� $��3�����#808C14�� -   $��tb_start��$��0��$
��Left=�$��Center=�$��15,0,0,0q�!Начало установки�� -   $��tb_conf��$��1��$
��Left=�$��Center=�$��15,0,0,0q�Конфигурация�� -   $��tb_path��$��2��$
��Left=�$��Center=�$��15,0,0,0q�'%Настройка установки�� -   $��
tb_install��$��3��$
��Left=�$��Center=�$��15,0,0,0q�
�������Установка�� -	   $��	tb_finish��$��4��$
��Left=�$��Center=�$��15,0,0,0q�Завершение�� $��1��
���   �$��0,1,0,0q��� $��0��
���   �$��1,1,1,0q��� $��1��$
��Bold"�$��10q�$��16(�Уставнока:�� -
   $��status_t��$��1��$��10(�$��	10,40,0,0q�Начало загрузки� -   $��main_pb��$	��Top=�$��
10,55,10,0q�$��1��$��16��$��Stretch=��� -   $��1��$��10,76,10,100q�$��20��$	��Top=�.��Загрузить�� $��1��
���   �$��1q�