   M S B A M L   `   `   `  ����K  GWagenparkbeheren, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:WagenparkbeherenWagenparkbeheren  5   	   +    %Wagenparkbeheren.Reservatie_Toevoegen   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Wagenparkbeheren     5   	   X TXceed.Wpf.Toolkit, Version=3.3.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	     � Title$  Reservatie_Toevoegen��5	   	   $��577.5��6&   $��422.5��65   .��5
      � $��0,0,2,0q�6    � ColumnDefinitions 5   
   �� 5      $��1013* �6   �� 5      $	��28* �6   .+�5   
   �� -   5         ��Name$ buttontoevoegen��5      $��Reservatie toevoegen��6*   $
��Left=�6I   $��
33,484,0,0q�6d   $	��Top=�6x   $	��158��6�   $��30��6�   6�   �� 5   
   -   5        $ buttonannuleren��5      $��	Annuleren��6*   $
��Left=�6>   $��218,486,0,0q�6Y   $	��Top=�6n   $	��158��6�   $��28��6�   6�   �� 5   
   -   5         ��Name$ textBoxWagenID��5      $
��Left=�6*   $��24��6E   $��
33,174,0,0q�6Q    �� TextWrapping$
 Wrap=�6e   $	��Top=�6z   $	��158��6�   �� 5   
   -   5        $ textBoxPersoneelsID��5      $
��Left=�6/   $��24��6J   $��	33,84,0,0q�6V   $
 Wrap=�6i   $	��Top=�6~   $	��158��6�   �� 5   
   -   5         ��Name$ label��5      $��Reservatie Toevoegen��6   $��20(�6>   $
��Bold"�6L   $
��Left=�6^   $��	33,10,0,0q�6y   $	��Top=�6�   $	��297��6�   $��36��6�   �� 5   
   -   5        $ label1��5      $��Personeels_ID:��6    $
��Bold"�69   $
��Left=�6K   $��	33,52,0,0q�6f   $	��Top=�6y   $	��120��6�   �� 5   
   -   5        $ label1_Copy2��5      $��
Einddatum:��6&   $
��Bold"�6;   $
��Left=�6M   $��
33,346,0,0q�6h   $	��Top=�6|   $	��120��6�   �� 5   
   -   5        $ label1_Copy3��5      $��Startdatum:��6&   $
��Bold"�6<   $
��Left=�6N   $��
33,242,0,0q�6i   $	��Top=�6}   $	��120��6�   �� 5   
   -	   5        $ label1_Copy4��5      $��	Wagen_ID:��6&   $
��Bold"�6:   $
��Left=�6L   $��
33,144,0,0q�6g   $	��Top=�6{   $	��120��6�   �� 5   
   -
   5        $ labelStatus��5      $
��Left=�6&   $��
33,426,0,0q�6A   $	��Top=�6U   $	��343��6m   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ datePickerstartdatum��5      $
��Left=�63   $��
33,273,0,0q�6N   $	��Top=�6b     5   
   -   5        $ datePickerEinddatum��5      $
��Left=�63   $��
33,377,0,0q�6N   $	��Top=�6b   5      5      