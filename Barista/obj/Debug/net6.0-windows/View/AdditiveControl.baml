   M S B A M L   `   `   `  ����B  >Barista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Barista.ViewBarista.View  5      -clr-namespace:Barista.ModelBarista.Model  5      5clr-namespace:Barista.ViewModelBarista.ViewModel  5      "    Barista.View.AdditiveControl   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:Barista.View     5      -Modelclr-namespace:Barista.Model     5      5	viewmodelclr-namespace:Barista.ViewModel     5        � 	Resources  5       �� 
TargetType �� Property �� Value �� ScaleX �� ScaleY �� RelativeSource �� Mode �� AncestorType	 �� Path
 �� BaselineAlignment J� Effect3  -System.Windows.Media.Effects.DropShadowEffect   Color   
BlurRadius   ShadowDepth��%/  '��       �� 5   
   " ��6   .�5      ��  � ��$
 Left=�64   �� 5       � ��$	 Top=�62   �� 5       � �� �	#FFE6E6E66+   �� 5       � �� �	#FFE6E6E66+   �� 5       � ��$ 20(�6)   �� 5       � ��$ 	Agency FB)�6+   �� 5       � ��$
 Bold"�6+   �� 5       � ��$	 146��6&   �� 5       �@�LayoutTransform 5      �� 5      $	 1.5Q�6%   $	 1.5Q�62   5      �� 5       � �� 5      �� 5      .R�5      �� $
��Wrap=�5    !   $��20(�5!   �   $��89��6�   $��0,-5,0,0q�6�   ��6!   ��  �� $ FindAncestor=� CheckBox$		 Tag��� 5"      $
 
TextBottom=�6&    5#        5$   "   $ 	#FF3E342A��63   $ 1Q�5%   #   $ 1Q�5&   #   5)      5*      5,      5-      5.      .��5/      � .+�50   
   �� $��4,10,4,0q�6   ���	#FFE6E6E6���	#FF846E5A$��1,1,1,1q�53       �� CornerRadius$ 8,8,8,8��54       55        56      $ 	#FF3E342A��6#   $ 4Q�57   #   $ 5Q�58   #      RenderingBias$ Quality=�59   #      Opacity$
 0.75Q�5:   #      	Direction$	 325Q�5;   #   5=      �� 5?   
   $��	9,127,0,0q�6   
 � Tag$ Молоко��5@       d� 	IsChecked 5A      �� *	AddMilk+�� 5B   
   $��9,0,0,0q�6   $ Сливки��5C      $��Center=�6     5D      �� *
AddCream+�� 5E   
   $��
10,250,0,0q�6   $ 
Сахар��5F       5G      �� *
AddSugar+�� 5I   
   $
��Left=�6   $��	10,10,0,0q�5J      $
��Wrap=�5K      $��Добавки��5L      $	��Top=�5M      $	��263��5N      $��72(�5O      ���	#FFE6E6E6$��Normal"�5Q         MyTextStyle#��[  5R       5S        5T      $ 	#FF3E342A��6#   $ 1Q�5U   #   $ 3Q�5V   #   5X      �� 5Y   
   $
��Left=�6   $��	10,86,0,0q�5Z      $
��Wrap=�5[      $��Молочные��5\      $	��Top=�5]      $	��263��5^      $��36(�5_      ���	#FFE6E6E6$��Normal"�5a      #��[  5b       5c        5d      $ 	#FF3E342A��6#   $ 1Q�5e      $ 2Q�5f      5h      �� 5i   
   $
��Left=�6   $��
10,209,0,0q�5j      $
��Wrap=�5k      $��Вкусовые��5l      $	��Top=�5m      $	��263��5n      $��36(�5o      ���	#FFE6E6E6$��Normal"�5q      #��[  5r       5s        5t      $ 	#FF3E342A��6#   $ 1Q�5u      $ 2Q�5v      5x      5{      5|      