   M S B A M L   `   `   `  ����P  LappliWPFBDDpersonnels, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:appliWPFBDDpersonnelsappliWPFBDDpersonnels  5   	   .    (appliWPFBDDpersonnels.Ajouter_personnels   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:appliWPFBDDpersonnels     5   	     � Title$  Ajouter_personnels��5   	   $	��450��6$   $	��800��61   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��179* �6   �� 5      $	��85* �6   ��5   
   �� 5       �� ImageSource$ institut-lemonnier.png��6   .+�5   
   �� -   5         ��Name$
 TNom��5      $��106,10,29,0q�6     �� TextWrapping$
 Wrap=�65   $��1��6h   $��26��6x   $	��Top=�6�   �� 5   
   -   5         ��Name$ BAjouter��5      $��Ajouter��6#   $��122,310,29,0q�65   $	��Top=�6K   $��32��6c   $��1��6�   $y�Hidden=�6�   �� 5   
   -   5        $ TPrénom��5      $��106,64,29,0q�6#   $
 Wrap=�68   $��1��6n   $��23��6~   $	��Top=�6�   �� 5   
   -   5         ��Name$ LbNom��5      $��Nom :��6   $��23,10,190,0q�6/   $	��Top=�6D    J� RenderTransformOrigin$ -0.453,1.938&�6\   $��1��6�   $��26��6�   �� 5   
   -   5        $ 	LbPrénom��5      $��	Prénom :��6"   $��23,61,175,0q�65   $	��Top=�6J   $��1��6b   $��26��6r   �� 5   
   -   5        $ 	LbService��5      $��	Service :��6#   $��27,135,175,0q�67   $	��Top=�6M   $��1��6e   $��26��6u   �� 5   
   -   5        $ BQuitter��5      $��Quitter��6#   $��122,361,29,0q�65   $��1��6b   $��29��6r   $	��Top=�6~   �� 5   
   -   5         ��Name$ Comboservice��5      $��106,135,29,0q�6)   $��1��6p   $��22��6�   $	��Top=�6�   �� 5   
   -	   5        $ 
BtModifier��5      $��Modifier��6%   $��122,256,29,0q�68   $	��Top=�6N   $��32��6f   $��1��6�   $y�Hidden=�6�   �� 5   
   -
   5        $ BtSupprimer��5      $��	Supprimer��6&   $��122,204,29,0q�6:   $��1��6j   $��29��6z   $	��Top=�6�   �� 5   
   -   5        $ Labelpersonnels��5      $��Personnels :��6)   $
��Left=�6@   $��
252,10,0,0q�6[   $	��Top=�6o   $��26��6�   $��73��6�   &   System.Windows.Controls.DataGrid  5   
   -   5        	  Name$	 DTGpersonnels��5      $��34,10,24,29q�6*   6?   �� 5   
   -   5        
 ��Name$
 IMGpersonnels��5      $��1��6'   $	��138��67   $��	5,204,0,0q�6D   $	��Top=�6W   $
��Left=�6o   $	��112��6�   5      5       