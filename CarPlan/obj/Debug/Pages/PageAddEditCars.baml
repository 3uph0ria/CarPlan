   M S B A M L   `   `   `  ����@  <vcids, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:vcids.Pagesvcids.Pages  5      !    vcids.Pages.PageAddEditCars   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:vcids.Pages     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$  PageAddEditCars��5         MaterialDesignBody#���   5	      $��Regular"�5
      $��13(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper N� 
Background# �  5        MaterialDesignFont N� 
FontFamily# �  5      .��5      � $��15q�6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��Center=�6   $��0��60   $L��FДобавление/редактирование автомобиля��5    	    $  MaterialDesignHeadline5TextBlock#��[ 5!      �� 5"   
   -   5        $��YearRelease��5$      $��1��5#      $	��600��5&        MaterialDesignFilledTextBox#��[ 5'      $��Center=�5(       �� AcceptsReturn .  �� TextWrapping$
 Wrap=�5*      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Год выпуска��5+      $��0 0 20 0q�5,      ��5%      �� *YearRelease+{�5-      �� 	 �� Path$	 	IsChecked�
 �� ElementName$0
 *MaterialDesignFilledTextBoxEnabledComboBox���� 50   
   -   5        $��Model��52      $��3��51      $	��600��54      #��[ 55      $��Center=�56       . $
 Wrap=�58      $ Модель��59      $��0 0 20 0q�5:      ��53      �� *Model+{�5;      �� $	 	IsChecked�$0
 *MaterialDesignFilledTextBoxEnabledComboBox���� 5=   
   -   5        $
��Mark��5?      $��5��5>      $	��600��5A      #��[ 5B      $��Center=�5C       . $
 Wrap=�5E      $ 
Марка��5F      $��0 0 20 0q�5G      ��5@      �� *Mark+{�5H      �� $	 	IsChecked�$0
 *MaterialDesignFilledTextBoxEnabledComboBox���� 5K   
   $��Center=�6   $��9��60   $��Center=�6>    �� Orientation$ 
Horizontal=�6[   .+�5L      �� -   5        $��BtnAddservice��5L      $��Добавить��6F   6\   �� 5M      -   5        $��BtnBack��5M      $��10q�6%   $��
Назад��6G   6Z   5N      5O      5P      