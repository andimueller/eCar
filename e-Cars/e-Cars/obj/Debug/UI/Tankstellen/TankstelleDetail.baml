   M S B A M L   `   `   `  ����
  e-Cars,    &e_Cars.UI.Tankstellen.TankstelleDetail   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5         UserControlStyle#��[  5      .��5	      �   � RowDefinitions  5
   
   �� 5      $
��Auto �6   �� 5      .+�5   
   �� $��0q�6    �� Orientation$ 
Horizontal=�6!   .+�5      �� -   5         ��Name$ ButtonZurueck��5      $��_Zurück��6,   $��60��6Z   5      � 5   
   $��1��6   .+�5      �� $��	10,11,0,0q�6   $��Wartungstermin: ��6'   $	��Top=�6C   $
��Left=�6[   $	��105��6v   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ DatepickerWartungstermin��5      $
��Left=�6�   $��
120,11,0,0q�6�   $	��Top=�6�   $	��140��6�      SelectedDate 6;   �� *WartungsTermin+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5      $��	Standort:��6   $
��Left=�6(   $��	10,41,0,0q�6C   $	��Top=�6V   �� 5      $��Status:��6   $
��Left=�6&   $��	10,72,0,0q�6A   $	��Top=�6T   �� 5      $	��ID:��6   $
��Left=�6"   $��
10,103,0,0q�6=   $	��Top=�6Q   �� 5      -   5         ��Name$ 
TBStandort��5      $��23��6*   $��
87,43,10,0q�66    �� TextWrapping$
 Wrap=�6J   $	��Top=�6�   ��6^   ��  �� Path$ Standort�$ PropertyChanged=�6�   �� 5      -   5        $ TBState��5      $��23��6'   $��
87,76,10,0q�63   $
 Wrap=�6G   $	��Top=�6�   ��6[   �� $ State�$ PropertyChanged=�6�   �� 5      -   5        $
 TBID��5      {�.  $��23��66   $��87,109,10,0q�6B   $
 Wrap=�6W   $	��Top=�6�   ��6k   �� $ ID�$ PropertyChanged=�6�   �� 5!      $��
15,138,0,0q�6   $	��Top=�6+   $��Gesperrt��6C   6X   �� 5#      -   5        $ 
ButtonSave��5#      $��Änderungen speichern��6B   $��	0,0,10,10q�6a   $��Bottom=�6t   $��Right=�6�   $	��135��6�   5$      5%      5&      