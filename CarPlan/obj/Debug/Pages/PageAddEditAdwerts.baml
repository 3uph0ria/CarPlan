   M S B A M L   `   `   `  ����@  <vcids, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:vcids.Pagesvcids.Pages  5      $    vcids.Pages.PageAddEditAdwerts   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:vcids.Pages     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5         MaterialDesignBody#���   5      $��Regular"�5	      $��13(�5
      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper N� 
Background# �  5        MaterialDesignFont N� 
FontFamily# �  5       N� Title$ PageAddEditAdwerts��5      .��5      � $��15q�6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��Center=�6   $��0��60   $L��FДобавление/редактирование объявления��5   	    $  MaterialDesignHeadline5TextBlock#��[ 5       �� 5!   
   -   5        $
��Name��5#      $��1��5"      $	��600��5%        MaterialDesignFilledTextBox#��[ 5&      $��Center=�5'       �� AcceptsReturn .  �� TextWrapping$
 Wrap=�5)      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$+ %Наименование детали��5*      $��0 0 20 0q�5+      ��5$      �� *Name+{�5,      �� 	 �� Path$	 	IsChecked�
 �� ElementName$0
 *MaterialDesignFilledTextBoxEnabledComboBox���� 5.   
   -   5        $��Article��50      $��2��5/      $	��600��52      #��[ 53      $��Center=�54       . $
 Wrap=�56      $ Артикль��57      $��0 0 20 0q�58      ��51      �� *	Article+{�59      �� $	 	IsChecked�$0
 *MaterialDesignFilledTextBoxEnabledComboBox���� 5<   
   -   5        $
��Cost��5>      $��3��5=      $	��600��5@      #��[ 5A      $��Center=�5B       . $
 Wrap=�5D      $ Стоимость��5E      $��0 0 20 0q�5F      ��5?      �� *Cost+{�5G      �� $	 	IsChecked�$0
 *MaterialDesignFilledTextBoxEnabledComboBox���� 5I   
   -   5        $��Phone��5K      $��4��5J       �� 	MaxLength$ 11��5M      $	��600��5N      #��[ 5O      $��Center=�5P       . $
 Wrap=�5R      $ Телефон��5S      $��0 0 20 0q�5T      ��5L      �� *Phone+{�5U      �� $	 	IsChecked�$0
 *MaterialDesignFilledTextBoxEnabledComboBox���� 5W   
   $��5��5X      $	��600��5Y       ! MaterialDesignOutlinedTextBox#��[ 5Z      $	��Top=�5[      $��3��5\      $	��100��5]       . $
 Wrap=�5`      $��0 0 20 0q�5a      " �� VerticalScrollBarVisibility$
 Auto=�5b      $ Описание��5c      ��5^      �� *Description+{�5d      �� $	 	IsChecked�$2
 ,MaterialDesignOutlinedTextBoxEnabledComboBox���� 5g   
   $��Center=�6   $��9��60   $��Center=�6>    �� Orientation$ 
Horizontal=�6[   .+�5h      �� -   5        $��BtnAddservice��5h      $��Добавить��6F   6\   �� 5i      -   5        $��BtnBack��5i      $��10q�6%   $��
Назад��6G   6Z   5j      5k      5l      