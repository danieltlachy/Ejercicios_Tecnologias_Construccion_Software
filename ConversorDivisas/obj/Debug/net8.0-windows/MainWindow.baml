   M S B A M L   `   `   `  ����K  GConversorDivisas, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:DivisasDivisas  5   	       Divisas.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Divisas     5   	     � Title$"  Conversor de divisas en .NET��5   	   $	��300��6.   $	��400��6;   .��5	      � .+�5
   
   �� .@�5      �� $��	USD a MXN��6   .��5      � ���	#FFF7A270.+�5      � .+�5      �� -   5         ��Name$ lbl_headerDolarPeso��5       $'��!Ingrese una cantidad en Doláres:��6=   $
��Left=�6h   $��0,35,0,0q�6�   $	��Top=�6�   $	��167��6�   $
��Bold"�6�   $��23��6�   $��10(�6�   �� 5      -   5        $ lbl_DolarPeso��5       $�� ��67   $��Center=�6B   $��4,73,0,0q�6_   $	��Top=�6q   $	��393��6�   $��32(�6�   $
��Bold"�6�   $��56��6�   $��Center=�6�   $��Center=�6�   �� 5      -   5         ��Name$ txt_DolarPeso��5   "   $
��Left=�69   $��
167,38,0,0q�6T    �� TextWrapping$
 Wrap=�6h   $	��Top=�6|   $	��105��6�   $��18��6�    �� TextAlignment$ Center=�6�   �� 5      $	��USD��6    $
��Left=�6.   $��
281,35,0,0q�6I   $	��Top=�6]   $��24��6u   $��33��6�   $��10(�6�   ${�False��6�   �� 5      -   5        $��	Convertir��5   !   $
��Left=�65   $��167,165,0,68q�6l   5      5      5      �� 5      $��	MXN a USD��6   .��5      � ���	#FFFFF266.+�5      �� -   5        $ lbl_headerPesoDolar��5      $$��Ingrese una cantidad en Pesos:��69   $
��Left=�6b   $��3,29,0,0q�6}   $	��Top=�6�   $	��156��6�   $
��Bold"�6�   $��21��6�   $��10(�6�   �� 5      -   5        $ lbl_PesoDolar��5      $�� ��63   $��Center=�6>   $��	10,59,0,0q�6[   $	��Top=�6n   $	��383��6�   $��32(�6�   $
��Bold"�6�   $��53��6�   $��Center=�6�   $��Center=�6�   �� 5      -   5        $ txt_PesoDolar��5      $
��Left=�65   $��
159,32,0,0q�6P   $
 Wrap=�6d   $	��Top=�6x   $	��120��6�   $��18��6�   $ Center=�6�   �� 5      $	��MXN��6   $
��Left=�6*   $��
284,28,0,0q�6E   $	��Top=�6Y   $��26��6q   $��40��6}   ${�False��6�   �� 5      -   5        $��	Convertir��5      $
��Left=�61   $��172,147,0,84q�6g   5      5      5      5       5!      