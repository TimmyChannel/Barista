   M S B A M L   `   `   `  ����B  >Barista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:BaristaBarista  5   	   +clr-namespace:Barista.ViewBarista.View  5   	       Barista.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Barista     5   	   +Viewclr-namespace:Barista.View     5   	   U QWpfAnimatedGif, Version=2.0.0.0, Culture=neutral, PublicKeyToken=9e7cd3b544a090dc,gif"http://wpfanimatedgif.codeplex.com  5   	   -   5          � Title$  
MainWindow��5
      $	��720��6   $
��1280��6!    � 
ResizeMode$ NoResize=�6.    � WindowStyle$
 None=�6Z    � WindowStartupLocation$ CenterScreen=�6m    � AllowsTransparency$
 True��6�   ��6D   Z� ��6�   Z�  � 	Resources 5         FocusVisual �� Property �� Value J� SnapsToDevicePixels	 �� StrokeDashArray  Button.Static.Background
 �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 
 DefaultButtonStyle �� 
TargetType �� 
TargetType ��Name ��Name �� Triggers P� Property P� Value �� 
TargetName �� ImageSource j� Stretch j� TileMode �� Opacity��%�  &	        &	 �     &	 �     &	     &	 8    &	 _    &	 �    &	 �    &	 �    &		 �    &	
 "    7   7  7  7  7  7 	 �� 5   
   .�5      ��  � �� 5      �� 5      .R�5      �� $��2q�6$   $
 true��5      #��� ��5      $		 1 2R�5      $��1��5      5      5      5      �� 5   
   $
 	#FFDDDDDD��5      �� 5   
   $
 	#FF707070��5      �� 5   
   $
 	#FFBEE6FD��5       �� 5!   
   $
 	#FF3C7FB1��5"      �� 5#   
   $
 	#FFC4E5F6��5$      �� 5%   
   $
 	#FF2C628B��5&      �� 5'   
   $
 	#FFF4F4F4��5(      �� 5)   
   $
 	#FFADB2B5��5*      �� 5+   
   $
 	#FF838383��5,      �� 5.   
   " ��5/      .�50      ��  �@�FocusVisualStyle8   61   �� 51       � ��8  6+   �� 52       � ��8  6,   �� 53       � ��# � ��6+   �� 54       � ��$ 1q�60   �� 55       � ��$ Center=�6;   �� 56       � ��$ Center=�69   �� 57       � ��$ 1q�6(   �� 58       � �� 59      �� 5:      " ��6&   .R�5;      �� $ border��6!   #��z��5<      #��z��5=      #��z��5>      $
 true��5?      ._�5@      �� $ contentPresenter��6/   #��z��5A   !   #��z��5B   !   #��z��5C   !   $|�False��5D   !   $
��True��5E   !   # z 5F   !   5G       5H      P� 5I       �@��IsDefaulted$
 true��6=   . �5J   "   �� $ border��6)   # � ��6T    � ��5K      P� 5L       �@J�IsMouseOver$
 true��6=   . �5M   "   �� $ border��6)    � �� 5N   &   �� 5O   *   $# /Resources/TeaBagSelected.png��65   $ Uniform=�6a   $
 None=�6s   5Q   #   5R      P� 5S       � ��$
 true��6;   . �5T   "   �� $ border��6)    � �� 5U   &   �� 5V   *   $ 0Q�65   5X   #   5Y      P� 5Z       � {�$ false��6;   . �5[   "   �� $ border��6)   8   � ��6S   �� 5\   "   $ border��6)   8   � ��6T   �� 5]   "   $ contentPresenter��6)   8   � ��6i   5^      5`      5b      5c      5d      .��5e      ��  �� CornerRadius$ 10��6   ���	#FF584736���	#FFE6E6E6$��1q�6N   ._�5f   
   � .+�5h      #   Barista.View.BaseDrinkControl  $
��Left=�6$   $��	10,39,0,0q�6?   $	��Top=�6R   $	��260��6j   $	��321��6w   $��0,0,0,6q�6�   "   Barista.View.AdditiveControl  5i      $
��Left=�6#   $��Bottom=�6>   $��	10,0,0,39q�6Y   $	��321��6l   $	��360��6x      Barista.View.CupDisplayer  5j      $
��Left=�6    $��Center=�6;   $	��383��6V   $	��620��6b   $��	639,0,0,0q�6o   �� 5k      -   5         ��Name$ Coffee��5k      "  WpfAnimatedGif.ImageBehavior   AnimatedSource$8 2pack://application:,,,/Resources/CoffeePressed.gif��5l      $
��Fill=�5q   F    � ToolTip$ Ты уверен��5r      ��5m      �� *ActualWidth+ �� ElementName$ CloseButton�� �� Mode$ OneWay=���5n      �� *ActualHeight+$ CloseButton��$ OneWay=���5o      �� *HorizontalAlignment+$ CloseButton��$ OneWay=���5p      �� *VerticalAlignment+$ CloseButton��$ OneWay=���5q      �� *Margin+$ CloseButton����5s      �� 5t      " ��6    �� Triggers 5u      �� 5v       �� Binding 6*   �� $ CloseButton�� �� Path$ 	IsPressed�  �� Value  true6f   .a�5w   "   ��  � y�$ Visible=�6@   5x      �� 5y       6*   �� $ CloseButton��$ 	IsPressed�	  false6f   .a�5z   "   ��  � y�$ Hidden=�6@   5{      5}      5      �� 5�      $��Right=�6   $	��Top=�5�      $��	0,50,10,0q�5�      $��Doloman Pavljenko Light)�5�      $I��CПогоди! Кофе ещё может показать себя!��5�      
�������$��16(�5�      ��5�      �� 5�      " ��6    5�      �� 5�       6*   �� $ CloseButton��$ 	IsPressed�  true6f   .a�5�   "   ��  � y�$ Visible=�6@   5�      �� 5�       6*   �� $ CloseButton��$ 	IsPressed�	  false6f   .a�5�   "   ��  � y�$ Hidden=�6@   5�      5�      5�      �� 5�      -   5        ! ��Name$! CloseButton��5�      $��Right=�5�      $	��Top=�5�      $��	0,10,10,0q�5�      $��40��5�      $��34��5�      #��� 
 5�      $ Я чаехлёб��5�      
" � Tag$" NoHide��5�      ��5�      Z� ��5�      �� 5�      $ /Resources/TeaBag.png��6!   $ Uniform=�6E   $
 None=�6W   5�      5�      5�      5�      