   M S B A M L   `   `   `  ����M  ISchnellerKaputtWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:SchnellerKaputtWPFSchnellerKaputtWPF  5   	   #    SchnellerKaputtWPF.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:SchnellerKaputtWPF     5   	   -   5          � Title$  Schneller & Kaputt AG��5   	   $	��700��6+   $
��1000��68   .��5	      � .+�5   
   �� $��1q�6   
���   �$	��490��69   $	��330��6E   $	��Top=�6R   $
��Left=�6j   
�������._�5   
   � -   5         �Name$ GRID_Kundenverwaltung��5      $	��490��6.   $	��330��6:   $	��Top=�6G   $
��Left=�6_   .+�5      �� $��Kundendaten��6   $	��Top=�6.   $
��Left=�6F   $��10q�6a   &   System.Windows.Controls.DataGrid  5      -   5        $��	DG_Kunden��5   -      
IsReadOnly . $	��350��6>   $	��280��6J   $��Bottom=�6W   $
��Left=�6r   $��15q�6�   6�   �� 5      -   5         ��Name$ BT_KD_Anlegen��5      $	��100��6,   $��30��68   $��Bottom=�6D   $��Right=�6_   $��5q�6{   $��Anlegen��6�   6�   �� 5      -   5        $ BT_KD_Aendern��5      $	��100��6,   $��30��68   $��Bottom=�6D   $��Right=�6_   $��0,0,5,40q�6{   $��Ändern��6�   6�   �� 5      -   5        $ BT_KD_Loeschen��5      $	��100��6-   $��30��69   $��Bottom=�6E   $��Right=�6`   $��0,0,5,75q�6|   $��Löschen��6�   6�   5      5      �� 5   
   $	��490��6   $	��330��6   $	��Top=�6*   $��Right=�6B   $��1q�6^   
���   �
�������._�5      � -   5        $ GRID_Terminverwaltung��5      $	��490��62   $	��330��6>   $	��Top=�6K   $��Right=�6c   .+�5        -   5        $��
DG_Termine��5   -    . $	��350��6?   $	��280��6K   $��Bottom=�6X   $
��Left=�6s   $��15q�6�   6�   �� 5      -	   5        $��BT_Terminanzeigen��5   -   $y�Hidden=�6   $��Anzeigen��6F   $��Bottom=�6Y   $��Right=�6t   $��15q�6�   $	��100��6�   6�   �� 5      -
   5        $��BT_Neuer_Termin��5   -   $y�Hidden=�6   $��Neuer Termin��6D   $��Bottom=�6[   $��Right=�6v   $��	0,0,15,50q�6�   $	��100��6�   6�   �� 5      -   5        $��BT_Termin_bearbeiten��5   -   $y�Hidden=�6   $��Ändern��6I   $��Bottom=�6Z   $��Right=�6u   $��	0,0,15,85q�6�   $	��100��6�   6�   �� 5      -   5        $��BT_Heutige_Termine��5      $��Heute Anzeigen��63   $	��Top=�6L   $��Right=�6d   $��
0,70,15,85q�6�   $	��100��6�   6�   �� 5      -   5        $��BT_Alle_Termine��5      $��Alle Anzeigen��60   $	��Top=�6H   $��Right=�6`   $��
0,35,15,85q�6|   $	��100��6�   6�   5$      5%      � 5&   
   -   5        $  GRID_Mitarbeiterverwaltung��5&      $	��490��63   $	��330��6?   $��Bottom=�6L   $
��Left=�6g   .+�5'      �� $��1q�6   
���   �._�5)      �� $��MITARBEITERVERWALTUNG TBA��6   $��Center=�6<   $��Center=�6W   5*      5+      � 5,   
   -   5        $ GRID_Lagerverwaltung��5,      $	��490��6-   $	��330��69   $��Bottom=�6F   $��Right=�6a   .+�5-      �� $��1q�6   
���   �._�5/      �� $��LAGERVERWALTUNG TBA��6   $��Center=�66   $��Center=�6Q   50      51      52      53      