   M S B A M L   `   `   `  ����K  GWagenparkbeheren, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:WagenparkbeherenWagenparkbeheren  5   	   G CAdoWagenpark, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA0clr-namespace:AdoWagenpark;assembly=AdoWagenparkAdoWagenpark 5   	   '    !Wagenparkbeheren.Overzicht_Wagens   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Wagenparkbeheren     5   	   IAdoWagenpark0clr-namespace:AdoWagenpark;assembly=AdoWagenpark     5   	   -   5          � Title$  Overzicht_Wagens��5	   	   $	��768��6"   $
��1024��6/    � 	Resources 5
      ��%    5      .��5      ]� ��.  J� RenderTransformOrigin$ 0.506,0.428&�6%   .+�5   
   �� $��30��6   
�������
���   �$��1q�6C   $	��Top=�6W   ._�5      �� -   5        $��stackPanel1��5   G   $��Center=�6   $��0,0,0,0q�66   $	��410��6Z    �� Orientation$ 
Horizontal=�6f   .+�5      �� -   5         ��Name$ comboBoxSoorten��5   '   $	��171��6   
�������6S   5      5      � 5   
   $��0,0,2,0q�6    � ColumnDefinitions 5      �� 5      $
��551* �6#   �� 5      $
��463* �6#   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ wagenDataGrid��5         AutoGenerateColumns .     EnableRowVirtualization . $��
0,10,0,117q�6�   	   RowDetailsVisibilityMode$	 VisibleWhenSelected=�6�   
   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$

 auto 6�   $��2��6�   ��6i   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        kleurColumn��,  &System.Windows.Controls.DataGridColumn   Header$ Kleur��5   X   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6>   �� *Kleur+6X     5      -   5        
merkColumn��$
 Merk��5   V    6=   �� *Merk+6V     5       -   5        nummerplaatColumn��$ Nummerplaat��5    d    6D   �� *Nummerplaat+6d     5!      -   5        soortColumn��$ Soort��5!   X    6>   �� *Soort+6X     5"      -	   5        
typeColumn��$
 Type��5"   V    6=   �� *Type+6V     5#      -
   5        wagen_IDColumn��$ Wagen ID��5#   ^      
IsReadOnly .  6A   �� *
Wagen_ID+6p     5$      -   5        wagenpark_IDColumn��$ Wagenpark ID��5$   f    6E   �� *Wagenpark_ID+6f   5&      �� 5'      -   5         ��Name$ returnButton��5'      $��Back to Mainscreen��6+   $��1��6H   $
��Left=�6X   $��289,644,0,0q�6s   $	��Top=�6�   $	��136��6�   $��32��6�   6�   5(      5)      5+      