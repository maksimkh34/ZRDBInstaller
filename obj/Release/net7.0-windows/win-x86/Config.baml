   M S B A M L   `   `   `  ���� I  EZRDB Installer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:DBaInstallerDBaInstaller      DBaInstaller.Config   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     ,localclr-namespace:DBaInstaller     -     � Title$  Установка ZRDB��$	��460��$	��600�� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=�.���  � RowDefinitions �� $
��412* ��� $
��auto �.+��� -   $��1��$��Right=�$��Bottom=�$	��100��$��20��$��7q�.��Продолжить�� -   $��1��$��Right=�$��Bottom=�$	��100��$��20��$��	0,0,113,7q�.��Закрыть� -    �Name$ 
simpleGrid��$��0�� � ColumnDefinitions �� $	��140 ��� .+�� -   $��	PanelGrid�����#B5B32B �� �� �� �� �� �� $	��220 �.+�� $��1�����#808C14�� -   $��tb_start��$��0��$
��Left=�$��Center=�$��15,0,0,0q�!Начало установки�� -   $��tb_conf��$��1��$
��Left=�$��Center=�
�������$��15,0,0,0q�Конфигурация�� -   $��tb_path��$��2��$
��Left=�$��Center=�$��15,0,0,0q�'%Настройка установки�� -	   $��
tb_install��$��3��$
��Left=�$��Center=�$��15,0,0,0q�Установка�� -
   $��	tb_finish��$��4��$
��Left=�$��Center=�$��15,0,0,0q�Завершение�� $��1��
���   �$��0,1,0,0q��� $��0��
���   �$��1,1,1,0q�� $��1�� �� $	��130 ��� $��95 ��� .+��� $��1��$
��Bold"�$��10q�$��16(�.,Конфигурация установки:�� $��0��$��	10,40,0,0q�1/Выберите метод установки:�� -    ��Name$ isUpdate_rb��$��0��$��	10,58,0,0q�.+�	� -   $	��iu1�� 	� 	GroupName$ 
IsUpdating��$��Установка��$��2q�	� -   $	��iu2��$ 
IsUpdating��$��Обновление��$��2q��� -   $��selectInstalledPath��$��1��$��Stretch=�$��2,5,10,0q�${�False��.��LJВыберите путь к установленной программе�� $��1��$��10,5,0,0q�31Выберите способ установки:�� -   $ 
isLocal_rb��$��1��$��	10,25,0,0q�.+�	� -   $	��um1��$ updatingMethod��$��С сервера��$��2q�	� -   $	��um2��$ updatingMethod��$��Из файла��$��2q��� -   $��selectInstallMethodButton��$��1��$��Stretch=�$��2,5,10,0q�${�False��.��><Выберите путь к файлу обновления�� $��0��
���   �$��0,1,1,1q��� $��1��
���   �$��0,0,1,1q��� $��1��
���   �$��1q�