   M S B A M L   `   `   `  ����@  <vcids, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:vcids.Pagesvcids.Pages  5      #    vcids.Pages.PageAddEditEvents   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:vcids.Pages     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5         MaterialDesignBody#���   5      $��Regular"�5	      $��13(�5
      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper N� 
Background# �  5        MaterialDesignFont N� 
FontFamily# �  5       N� Title$ PageAddEditEvents��5      .��5      � $��15q�6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��Center=�6   $��0��60   $F��@Добавление/редактирование события��5    	    $  MaterialDesignHeadline5TextBlock#��[ 5!      �� 5%   
   -   5         ��Name$ 
CBoxEvents��5-      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Тип события��5&      $	��600��5'      $��0 0 20 0q�5(      $��Center=�5)      $��2��5*       �� DisplayMemberPath$
 Name��5.      	 �� SelectedItem	 5,      �� *TypeEvents.Id+5.      � 51   
   -   5        $��Comment��51   *   $	��600��6   $��3��6   
 � ColumnDefinitions
 52      �� 53      6%   �� 54      6%   .+�57      �� $��Center=�6   Комментарий6@   �� 59      -   5        $��	CBComment��5>      $��1��5:      $	��300��5;      $��4��5<      $��0 0 20 0q�5=      $ Комментарий��5@       �� Text 5?      �� *	Cpmment+.@�5B      �� $0��*Замена моторного масла��5C      �� 5D      $6��0Замена тормозной жидкости��5E      �� 5F      $8��2Замена толпливрооо фильтра��5G      �� 5H      $4��.Зачега тормозных колодок��5I      �� 5J      $2��,Замена свечей зажигания��5K      �� 5L      $0��*Замена моторных ремней��5M      5N      5P      �� 5R   
   -   5        $��Distance��5T      $��4��5S      $	��600��5V        MaterialDesignFilledTextBox#��[ 5W      $��Center=�5X       �� AcceptsReturn .  �� TextWrapping$
 Wrap=�5Z      $ Пробег��5[      $��0 0 20 0q�5\      ��5U      �� *
Distance+{�5]      ��  �� Path$ 	IsChecked� �� ElementName$0 *MaterialDesignFilledTextBoxEnabledComboBox���� 5_   
   -   5        $
��Date��5a      $��5��5`      $	��600��5c      #��[ 5d      $��Center=�5e       . $
 Wrap=�5g      $ Дата��5h      $��0 0 20 0q�5i      ��5b      �� *Date+{�5j      �� $ 	IsChecked�$0 *MaterialDesignFilledTextBoxEnabledComboBox���� 5l   
   -   5        $
��Cost��5n      $��6��5m      $	��600��5p      #��[ 5q      $��Center=�5r       . $
 Wrap=�5t      $ Стоимость��5u      $��0 0 20 0q�5v      ��5o      �� *Cost+{�5w      �� $ 	IsChecked�$0 *MaterialDesignFilledTextBoxEnabledComboBox���� 5z   
   $��Center=�6   $��10��60   $��Center=�6?    �� Orientation$ 
Horizontal=�6\   .+�5{      �� -   5        $��BtnAddservice��5{      $��Добавить��6F   6\   �� 5|      -   5        $��BtnBack��5|      $��
Назад��6:   $��10 0 0 0q�6J   6^   5}      5~      5      