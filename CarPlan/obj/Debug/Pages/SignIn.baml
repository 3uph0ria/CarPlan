   M S B A M L   `   `   `  ����@  <vcids, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:vcids.Pagesvcids.Pages  5          vcids.Pages.SignIn   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:vcids.Pages     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5         MaterialDesignBody#���   5	      $��Regular"�5
      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper N� 
Background# �  5        MaterialDesignFont N� 
FontFamily# �  5       N� Title$ SignIn��5      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��100 �6   �� 5      $��* �6   �� 5      $��50 �6   �� 5      $��* �6   �� 5      $��50 �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5       $��* �6   �� 5!      $��* �6   .+�5&   
   �� $��2��6   $��UniformToFill=�6$   $��0��6=   $��8��6J   $ ��../Resources/header_bg.png��6[   �� 5(   
   $��1��6   $��3��6"   $��Center=�62   $��Авторизация��5)   	   $��Center=�5*   	    $  MaterialDesignHeadline5TextBlock#��[ 5+   	   G� 5/   
   -   5        $��Password��50      $��3��5/      $��3��6#    # MaterialDesignFilledPasswordBox#��[ 51      $��Center=�52      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Пароль��54      {�53      ��  �� Path$ 	IsChecked�	 �� ElementName$A	 ;MaterialDesignFilledPasswordFieldPasswordBoxEnabledComboBox��54      �� 56   
   $��4��6   $��3��6"   
 �� Orientation$
 
Horizontal=�62   .+�57      �� -   5        $��BtnSignInAdmin��57   D   
�������$��10q�6(   $��
Войти��64   6Z   �� 58      -   5        $��BtnSignIUAdmin��58   >   
�������$��Регистрация��6(   6T   59      �� 5:   
   -   5        $��Login��5;      $��2��5:      $��3��6     MaterialDesignFilledTextBox#��[ 5<      $��Center=�5=       �� AcceptsReturn .  �� TextWrapping$
 Wrap=�5?      $ 
Логин��5@      {�5A      �� $ 	IsChecked�$0	 *MaterialDesignFilledTextBoxEnabledComboBox��5D      5E      