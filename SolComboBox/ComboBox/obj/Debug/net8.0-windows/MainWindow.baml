   M S B A M L   `   `   `  ����C  ?ComboBox, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ComboBoxComboBox  5   	       ComboBox.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:ComboBox     5   	     � Title$  Ejercicio ComboBox��5   	   $	��450��6$   $	��600��61    � WindowStartupLocation$ CenterScreen=�6=   .��5	      � .+�5
   
   �� $'��!Personaliza tu equipo de cómputo��6   $
��Left=�6;   $��
131,22,0,0q�6V   $	��Top=�6j   $��Courier New)�6�   $��18(�6�   $
��Bold"�6�   �� 5   
   $&�� Sistema Operativo (predefinido):��6   $
��Left=�6;   $��	34,75,0,0q�6V   $	��Top=�6i   $��Dubai)�6�   $��16(�6�   �� 5   
   -   5         ��Name$ 
cmbSistema��5      $
��Left=�6'   $��
301,83,0,0q�6B   $	��Top=�6V   $	��254��6n   .@�5      �� $��Windows��6   �� 5      $��Linux��6   �� 5      $��Windows��6   5      �� 5   
   $"��Procesador (lista - codigo):��6   $
��Left=�67   $��
34,121,0,0q�6R   $	��Top=�6f   $��Dubai)�6~   $��16(�6�   �� 5   
   -   5        $ cmbProcesador��5      $
��Left=�6*   $��301,129,0,0q�6E   $	��Top=�6Z   $	��254��6r   �� 5   
   $$��Marca (diseño personalizado):��6   $
��Left=�68   $��
34,174,0,0q�6S   $	��Top=�6g   $��Dubai)�6   $��16(�6�   �� 5   
   -   5        $ cmbMarca��5      $
��Left=�6&   $��301,182,0,0q�6A   $	��Top=�6V   $	��254��6n   .@�5      �� .��5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��/Resources/acer.png��6   �� 5      $��12, 0, 0, 0q�6    
��� d �$
��Bold"�6L   $��Center=�6^   acer6   5      5      �� 5      .��5      �� $ 
Horizontal=�6   .+�5      �� $��/Resources/apple.png��6   �� 5      $��12, 0, 0, 0q�6    
��� d �$
��Bold"�6L   $��Center=�6^   Apple6�   5      5       �� 5!      .��5"      �� $ 
Horizontal=�6   .+�5#      �� $��/Resources/hp.png��6   �� 5$      $��12, 0, 0, 0q�6    
��� d �$
��Bold"�6L   $��Center=�6^   HP6}   5%      5&      �� 5'      .��5(      �� $ 
Horizontal=�6   .+�5)      �� $��/Resources/huawei.png��6   �� 5*      $��12, 0, 0, 0q�6    
��� d �$
��Bold"�6L   $��Center=�6^   Huawei6�   5+      5,      �� 5-      .��5.      �� $ 
Horizontal=�6   .+�5/      �� $��/Resources/lenovo.png��6   �� 50      $��12, 0, 0, 0q�6    
��� d �$
��Bold"�6L   $��Center=�6^   Lenovo6�   51      52      �� 53      .��54      �� $ 
Horizontal=�6   .+�55      �� $��/Resources/samsung.png��6   �� 56      $��12, 0, 0, 0q�6    
��� d �$
��Bold"�6L   $��Center=�6^   	Samsung6�   57      58      59      �� 5:   
   $��RAM (dinámico):��6   $
��Left=�6*   $��
34,235,0,0q�6E   $	��Top=�6Y   $��Dubai)�6q   $��16(�6�   �� 5;   
   -   5        $ cmbRAM��5;      $
��Left=�6#   $��301,243,0,0q�6>   $	��Top=�6S   $	��254��6k   �� 5<   
   $&�� Agrega la RAM de tu preferencia:��6   $
��Left=�6;   $��
34,301,0,0q�6V   $	��Top=�6j   $��Dubai)�6�   $��13(�6�   �� 5=   
   -   5         ��Name$ tbRAM��5=      $
��Left=�6"   $��
39,346,0,0q�6=    �� TextWrapping$
 Wrap=�6Q   $	��Top=�6e   $��81��6}   �� 5>   
   -   5         ��Name$ btnClicAgregarRAM��5>      $
��Left=�6-   $��131,340,0,0q�6H   $	��Top=�6]   $��30��6u   $��29��6�   ��6�   Z� ��5?      �� 5@       �� ImageSource$ /Resources/plus.png��6   5B      �� 5C   
   -   5        $ btnConfiguracion��5C      $��Ver Configuración��6+   $
��Left=�6G   $��431,358,0,0q�6b   $	��Top=�6w   $	��124��6�   
��� d �
�������$��Dubai)�6�   $��30��6�   ��6�   Z� 6�   �� 5D   
   -   5         ��Name$ lblErrorRAM��5D      $�� ��6%   $
��Left=�60   $��
34,378,0,0q�6K   $	��Top=�6_   
���  ��${�False��6�   5E      5F      