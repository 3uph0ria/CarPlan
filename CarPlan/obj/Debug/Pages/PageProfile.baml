   M S B A M L   `   `   `  ����@  <vcids, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:vcids.Pagesvcids.Pages  5          vcids.Pages.PageProfile   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:vcids.Pages     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5         MaterialDesignBody#���   5      $��Regular"�5	      $��13(�5
      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper N� 
Background# �  5        MaterialDesignFont N� 
FontFamily# �  5       N� Title$ PageProfile��5      .��5      �  � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��* �6   �� 5      $	��125 �6   �� 5      $��50 �6   .+�5   
   �� -   5        $��Header��5   	   $��10 0 0 0q�5   	   $��Center=�5   	   $�� ��5   	    $  MaterialDesignHeadline5TextBlock#��[ 5   	   �� 5"   
   -   5         ��Name$ ListServices��5"   !   $��1��6   $��Disabled=�67   $
��Left=�6m   ��5#      �� 5$      .R�5%      �  � Orientation$ 
Horizontal=�6    $��Center=�69   6X   5&      ��5(      �� 5)      .R�5*      #  MaterialDesignThemes.Wpf.Card  $
��1000��5+      .��5,      �  5-      �� 5.   "   $��* �5/   %   .+�52      �� $��0��53   !   $��8 10 8 0q�54   !   .+�55   "   �  � ColumnDefinitions 56   &   �� 57   *   6=   �� 58   *   6=    5:   &   �� 5;   *   6:   �� 5<   *   6:   .+�5?   &   �� $��0��61   	 �� Orientation$	 
Horizontal=�6>   .+�5@   *   �� $��User2��5C   )   $��20q�5A   )    $  MaterialDesignHeadline6TextBlock#��[ 5D   )   ��5B   )   �� *Users1.Login+5E   +   �� 5G   *   $��20q�5H   )   #��[ 5J   )   ��5I   )   �� *Date+5K   +   5L   '   �� 5N   &   
 �� TextWrapping$

 Wrap=�5O   +   $��Stretch=�5P   +   $	��280��5Q   +   $��1��5R   )   {�.   �� AcceptsReturn . " �� VerticalScrollBarVisibility$
 Auto=�5V   +    �� 	IsEnabled . )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Multiline text��5X   +   $��80��5Y   +   ��5T   )   �� *Text+5Y   9   5]   #   5_      5`      5a      5b      5d      �� 5f   
   -   5        $��FeedBackText��5j      ���	#FF383838$��2��5h      $
��auto��5i       ! MaterialDesignOutlinedTextBox#��[ 5k      $	��Top=�5l      $	��150��5m       . $

 Wrap=�5o      $
 Auto=�5p      $ Ваш отзыв��5q      {�5r      ��  �� Path$ 	IsChecked� �� ElementName$2 ,MaterialDesignOutlinedTextBoxEnabledComboBox���� 5t   
   $��3��6   $	 
Horizontal=�6"   $��Center=�6;   ���	#FF383838.+�5u      �� -   5        $��BtnAddFeddBack��5u      $��5q�6+   $!��Оставить отзыв��6S   5v      �� 5w      -   5        $��BtnBack��5w      $��5q�6$   $��
Назад��6E   5x      5y      5z      5{      