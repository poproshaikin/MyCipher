   M S B A M L   `   `   `  ����C  ?MyCipher, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:MyCipherMyCipher  5   	       MyCipher.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:MyCipher     5   	     � Title$  MyCipher��5   	    � 
ResizeMode$ NoResize=�5	   	   $	��500��5
   	   $	��550��5   	   .��5      � .+�5   
   �� $��Enter text: ��6   $��16(�6(   $��80��66   $��	30,10,0,0q�6A   $	��Top=�6T   $
��Left=�6l   �� 5   
   $��Settings��6    �� TextAlignment$ Center=�6$   $	��Top=�6;   $��Right=�6S   $��
0,133,50,0q�6o   $��25��6�   $	��100��6�   $��16(�6�   �� 5   
   -   5         ��Name$ 
TextBox_IO��5      " �� VerticalScrollBarVisibility$ Visible=�6&   $��30q�6L    �� TextWrapping$
 Wrap=�6X   $
��Left=�6l   $��Bottom=�6�   $	��320��6�   $	��386��6�   �� 5   
   -   5         ��Name$ Button_Clear��5   '   $��20��6=   $	��100��6I   $	��Top=�6U   $��Right=�6m   $��	0,33,50,0q�6�   $��Clear��6�   �� 5   
   -   5        $ Button_Encrypt��5   !   $��20��69   $	��100��6E   $	��Top=�6Q   $��Right=�6i   $��	0,68,50,0q�6�   $��Encrypt��6�   �� 5   
   -   5        $ Button_Decrypt��5   !   $��20��69   $	��100��6E   $	��Top=�6Q   $��Right=�6i   $��	0,93,50,0q�6�   $��Decrypt��6�   �� 5   
   -   5        $��ComboBox_Algorithm��5      $��
0,163,30,0q�6-   $��Right=�6A   $	��Top=�6]   $	��130��6u    �� Text$ Choose algorithm��6�    �� SelectedIndex$ 0��6�   .@�5      �� ${�False��6   .��6-   Choose algorithm6?   �� 5      .��6   D1236!   �� 5      .��6   NUM26!   �� 5      .��6   CHA6    5      �� 5   
   -   5        $��ComboBox_Layout��5      $y�Hidden=�6*   $��
0,200,30,0q�6>   $��Right=�6R   $	��Top=�6n   $	��130��6�   $ Choose layout��6�   $ 0��6�   .@�5      �� ${�False��6   $��Choose layout��6-   �� 5      $��Latin��6   �� 5      $��Cyrillic��6   5      5!      5"      