   M S B A M L   `   `   `  ����@  <vcids, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:vcids.Pagesvcids.Pages  5          vcids.Pages.PageSignUp   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:vcids.Pages     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5         MaterialDesignBody#���   5      $��Regular"�5	      $��13(�5
      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper N� 
Background# �  5        MaterialDesignFont N� 
FontFamily# �  5       N� Title$ 
PageSignUp��5      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��100 �6   �� 5      $��* �6   �� 5      $��50 �6   �� 5      $��* �6   �� 5      $��50 �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5       $��* �6   �� 5!      $��* �6   �� 5"      $��* �6   .+�5'   
   �� $��2��6   $��UniformToFill=�6$   $��0��6=   $��8��6J   $!��../Resources/heafer2_bg.jpg��6[   �� 5)   
   $��1��6   $��3��6"   $��Center=�62   $��Регистрация��5*   	   $��Center=�5+   	    $  MaterialDesignHeadline5TextBlock#��[ 5,   	   G� 50   
   -   5        $��Password��51      $��3��50      $��3��6#    # MaterialDesignFilledPasswordBox#��[ 52      $��Center=�53      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Пароль��55      {�54      ��  �� Path$ 	IsChecked�	 �� ElementName$A	 ;MaterialDesignFilledPasswordFieldPasswordBoxEnabledComboBox��55      G� 57   
   -   5        $��	Password2��58      $��4��57      $��3��6#   #��[ 59      $��Center=�5:      $% Повторите пароль��5<      {�5;      �� $ 	IsChecked�$A	 ;MaterialDesignFilledPasswordFieldPasswordBoxEnabledComboBox��5<      �� 5>   
   $��5��6   $��3��6"   
 �� Orientation$
 
Horizontal=�62   $��Center=�6K   .+�5?      �� -   5        $��BtnSignIUAdmin��5?   >   
�������$��Регистрация��6(   6T   5@      �� 5A   
   -   5        $��Login��5B      $��2��5A      $��3��6     MaterialDesignFilledTextBox#��[ 5C      $��Center=�5D       �� AcceptsReturn .  �� TextWrapping$
 Wrap=�5F      $ 
Логин��5G      {�5H      �� $ 	IsChecked�$0	 *MaterialDesignFilledTextBoxEnabledComboBox��5K      5L      