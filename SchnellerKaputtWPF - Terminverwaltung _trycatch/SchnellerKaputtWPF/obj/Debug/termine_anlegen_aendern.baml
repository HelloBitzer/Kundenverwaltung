   M S B A M L   `   `   `  ����M  ISchnellerKaputtWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:SchnellerKaputtWPFSchnellerKaputtWPF  5   	   0    *SchnellerKaputtWPF.termine_anlegen_aendern   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:SchnellerKaputtWPF     5   	     � Title$  Termin erstellen��5   	   $	��370��6"   $	��560��6/   .��5	      � .+�5   
   �� ���	#FFF4F4F5$
��Left=�6%   $	��100��6@   $��	10,10,0,0q�6M   
���   �$	��Top=�6o   $	��250��6�   �� 5   
   $��Beginn��6   $	��Top=�6!   $
��Left=�69   $��10q�6T   �� 5   
   $��Datum��6   $
��Left=�6    $	��Top=�6;   $��20,40q�6S   (  "System.Windows.Controls.DatePicker  5   
   -   5        $��	DP_beginn��5      $
��Left=�6&   $��	20,65,0,0q�6A   $	��Top=�6T   �� 5   
   $��Uhrzeit��6   $
��Left=�6"   $	��Top=�6=   $��180,40q�6U   �� 5   
   -   5        $��TB_Beginn_std��5      $
��Left=�6'   $��23��6B   $��
180,65,0,0q�6N    �� TextWrapping$
 Wrap=�6b   $��00��6v   $	��Top=�6�   $��25��6�   �� 5   
   $��:��6   $	��Top=�6   $
��Left=�64   $��205,60q�6O   6a   �� 5   
   -   5         ��Name$ TB_Beginn_min��5      $
��Left=�6)   $��23��6D   $��
220,65,0,0q�6P   $
 Wrap=�6d   $��00��6x   $	��Top=�6�   $��25��6�   �� 5   
   ���	#FFF4F4F5$
��Left=�6%   $	��100��6@   $��
290,10,0,0q�6M   
���   �$	��Top=�6p   $	��250��6�   �� 5   
   $
��Ende��6   $	��Top=�6   $
��Left=�67   $��
290,10,0,0q�6R   �� 5   
   $��Datum��6   $
��Left=�6    $	��Top=�6;   $��
300,40,0,0q�6S     5   
   -   5        $��DP_ende��5      $
��Left=�6$   $��
300,65,0,0q�6?   $	��Top=�6S   �� 5   
   $��Uhrzeit��6   $
��Left=�6"   $	��Top=�6=   $��
460,40,0,0q�6U   �� 5   
   -   5        $��TB_Ende_std��5      $
��Left=�6%   $��23��6@   $��
460,65,0,0q�6L   $
 Wrap=�6`   $��00��6t   $	��Top=�6~   $��25��6�   �� 5   
   $��:��6   $	��Top=�6   $
��Left=�64   $��
485,60,0,0q�6O   �� 5   
   -   5        $��TB_ende_min��5      $
��Left=�6%   $��23��6@   $��
500,65,0,0q�6L   $
 Wrap=�6`   $��00��6t   $	��Top=�6~   $��25��6�   �� 5   
   ���	#FFF4F4F5$
��Left=�6%   $	��200��6@   $��
10,130,0,0q�6M   
���   �$	��Top=�6p   $	��530��6�   �� 5   
   $��Termin Grund��6   $	��Top=�6'   $
��Left=�6?   $��20,135q�6Z   �� 5   
   -   5        $��CB_grund��5      $
��Left=�6#   $��
20,160,0,0q�6>   $	��Top=�6R   $	��120��6j   �� 5!   
   -   5        $ TB_bemerkung��5!      $	��Top=�6(   $��
20,220,0,0q�6@   $
 Wrap=�6T    �� AcceptsReturn . $
��Left=�6}   $	��100��6�   $	��250��6�   $��	sdfsdfsdf��6�   �� 5"   
   -	   5        $��CB_bestaetigt��5"      $��erledigt��6(   $
��Left=�6;   $��200,160,0,0q�6V   $	��Top=�6k   �� 5#   
   -
   5        $��BT_erstellen��5#      $��	Erstellen��6%   $
��Left=�69   $��450,300,0,0q�6T   $	��Top=�6i   $��75��6�   6�   5$      5%      