   M S B A M L   `   `   `  ����?  ;HRMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:HRMSHRMS  5   	       HRMS.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:HRMS     5   	   U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        � Title$  
MainWindow��5   	   $	��500��6   $	��350��6)    � WindowStyle$
 None=�5	   	   $��Segoe UI Emoji)�6    � 
ResizeMode$ NoResize=�68   .��5      � .+�5   
   �� $	��280��6   $	��Top=�6!   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FF2281D1��6#   � 5      $ 	#FF34268A��6#    � Offset$ 1Q�65   � 5      $ 	#FF33288B��6#   $ 0.546Q�65   5      5      �� 5   
   $	��280��6   $	��240��6    $	��Top=�6-   $��35,143,35,0q�6E    �� RadiusY$ 10��6Z    �� RadiusX$ 10��6g   
�������	 J� Effect	 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      
   
BlurRadius$
 15Q�6#      	Direction$ 0Q�63      RenderingBias$ Quality=�6A      ShadowDepth$ 1Q�6Y      Color$ 	#FFBBBBBB��6i   5      � 5   
   $��Bottom=�6   $��35,80q�6*   $	��240��69   .+�5      �� $��LOGIN��6   $��Center=�6$   $	��Top=�6A   $��5q�6Y   
�������$��18(�6v   �� 5      $��Center=�6   $��15q�64   .+�5!      �� -   5        $��username��5!      $
��0,10q�6*   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Username��68    %  !MaterialDesignFloatingHintTextBox#��[  6b   $��Champagne & Limousines)�6�   $��16(�6�   G� 5"      -   5        $��password��5"      $
��0,10q�6.   $ Password��6<    ) %MaterialDesignFloatingHintPasswordBox#��[ 6f   $��Champagne & Limousines)�6�   $��16(�6�   5#      5$      �� 5&   
   -   5        $	��150��5&      $��Center=�6   $��35��6:   $��Bottom=�6F   $
��0,55q�6a   $��LOGIN��6o   6   5(      5)      