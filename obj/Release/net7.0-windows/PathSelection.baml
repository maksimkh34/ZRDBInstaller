   M S B A M L   `   `   `  ���� I  EZRDB Installer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:DBaInstallerDBaInstaller       DBaInstaller.PathSelection   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     ,localclr-namespace:DBaInstaller     -     � Title$  Установка ZRDB��$	��460��$	��600�� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=�.���  � RowDefinitions �� $
��412* ��� $
��auto �.+��� -   $��1��$��Right=�$��Bottom=�$	��100��$��20��$��7q�.��Продолжить�� -   $��1��$��Right=�$��Bottom=�$	��100��$��20��$��	0,0,113,7q�.��Закрыть� -    �Name$ 
simpleGrid��$��0�� � ColumnDefinitions �� $	��140 ��� .+�� -   $��	PanelGrid�����#B5B32B �� �� �� �� �� �� $	��220 �.+�� $��2�����#808C14�� -   $��tb_start��$��0��$
��Left=�$��Center=�$��15,0,0,0q�!Начало установки�� -   $��tb_conf��$��1��$
��Left=�$��Center=�$��15,0,0,0q�Конфигурация�� -   $��tb_path��$��2��$
��Left=�$��Center=�
�������$��15,0,0,0q�'%Настройка установки�� -	   $��
tb_install��$��3��$
��Left=�$��Center=�$��15,0,0,0q�Установка�� -
   $��	tb_finish��$��4��$
��Left=�$��Center=�$��15,0,0,0q�Завершение�� $��1��
���   �$��0,1,0,0q��� $��0��
���   �$��1,1,1,0q�� $��1�� �� $��68 ��� $��80 ��� $��80 ��� .+��� $��1��$
��Bold"�$��10q�$��16(�<:Выбор директории для установки:�� -   $��0��$��20��$��
10,36,10,0q�$	��Top=�$��Stretch=�.��Выбрать путь�� $��1��.+��� $��10,5,5,5q�-+Пароль для доступа к БД:�� -   $��textBox_Pass��$��	10,0,10,0q��� -   $��	10,5,10,0q�.��Сгенерировать�� $��2��.+��� $��	10,5,0,10q�!Данные для входа:��  �� Orientation$ 
Horizontal=�.+��� $��10,0,5,0q�Логин:�� -   $��login_tb��$	��400���� $ 
Horizontal=�$��0,5,0,0q�.+��� $��10,0,5,0q�Пароль:G� -   $��pass_tb��$��Stretch=�$	��393���� -   $��createLink_cb��$��3��$��5q�.��:8Создать ярлык на рабочем столе�� $��0��
���   �$��0,1,1,0q��� $��1��
���   �$��0,1,1,0q��� $��2��
���   �$��0,1,1,1q��� $��1��
���   �$��1q�