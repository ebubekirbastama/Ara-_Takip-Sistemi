   M S B A M L   `   `   `  ����&  "Araç Kayıt ve Takip Sistemi(İT)3    -Araç_Kayıt_ve_Takip_Sistemi_İT_.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
MainWindow��5   	   $��511.042��6   $��869.479��6-    � AllowsTransparency .  � WindowStyle$
 None=�6W   ��6j   Z�  � 	Resources 5         exit �� 
TargetType �� Property �� Value �� 
TargetType �� RadiusY	 �� RadiusX
 �� EndPoint �� 
StartPoint � Color � Offset J� SnapsToDevicePixels �� Triggers P� Property P� Value��%�  &	        �� 5   
   " ��6   .�5      ��  � �� 5      �� 5	      " ��6&   .R�5
      � .+�5      �� $ 12.362��6(   $	 12.362��69   
���   ���5   "   �� 5   &   $
 0.5,1&�6:   $ 0.5,0&�6K   .��5   *   � $ Black��67   $ 0Q�6E   � 5   *   $ 	#FF151111��67   $ 1Q�6I   5   '   5      �� 5      #��z��6/   ��. # z 6�   #��z��6�   $��X��6  5       5      P� 5       �@J�	IsFocused . 6;   P� 5       �@��IsDefaulted . 6=   P� 5       �@J�IsMouseOver . 6=   P� 5       � �� . 6;   P� 5       � {� .  6;   5      5      5      5       .��5!      � -   5         �Name$	 txt��5!      $��0,1,0,-1q�6   .+�5"   
   �� -   5        
���   �$��120,75,0,262.669q�5"   !   
���   �$
��Left=�6j   $	��553��6�   $ 9.351��6�   $	 9.351��6�   �� 5#   
   -   5        $��Kaydet��5#      $
��Left=�6"   $��548.098,203.084,0,0q�6=   $	��Top=�6Z   $	��103��6r   $��35��6~    J� RenderTransformOrigin$ 0.5,0.5&�6�   
���  ��
���   � J� OpacityMask
 �   � � Cursor$
 Hand��6�   $��18(�6   � ForceCursor . ��5$      �� 5%      $
 0.5,1&�6&   $ 0.5,0&�67   .��5&      � $ Black��6#   $ 0Q�61   � 5'      $ 	#FFFFEFEF��6#   $ 1Q�65   5(      z�5*      V� 5+      .~�5,      �� �� 5-      �� 5.       �� Angle$ -0.403Q�6&   T� 5/      50      52      �� 53   
   -   5         ��Name$ 
txt_pilaka��53      $
��Left=�6&   $��22��6A   $��
264,98,0,0q�6M    �� TextWrapping$
 Wrap=�6a   $	��Top=�6u   $	��120��6�   
���   �
���  ��.��6�   ��54      �� 55      $

 0,20&�6&    � MappingMode$ Absolute=�66   $	 0,0&�6M   .��56      � $ 	#FFABADB3��6#   $
 0.05Q�65   � 57      $ 	#FFE2E3EA��6#   $
 0.07Q�65   � 58      $	 Red��6#   $ 1Q�6/   59      .��5:   #   5;      �� 5<   
   $#��Barkot Numarası  & Plaka No:��6   $
��Left=�6;   $��
138,96,0,0q�6V   $	��Top=�6j   $	��126��6�   $��Arial Black)�6�   
���  ��6�   �� 5=   
   -   5        $ txt_src_adi��5=      $
��Left=�6'   $��22��6B   $��264,132,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $	��120��6�   
���   �
���  ��.��6�   ��5>      �� 5?      $

 0,20&�6&   $ Absolute=�66   $	 0,0&�6M   .��5@      � $ 	#FFABADB3��6#   $
 0.05Q�65   � 5A      $ 	#FFE2E3EA��6#   $
 0.07Q�65   � 5B      $	 Red��6#   $ 1Q�6/   5C      .��5D   #   5E      �� 5F   
   $��Sürücü Adı :��6   $
��Left=�6'   $��138,130,0,0q�6B   $	��Top=�6W   $	��126��6o   $��Arial Black)�6{   
���  ��6�   �� 5G   
   -   5        $ txt_arc_cns��5G      $
��Left=�6'   $��24��6B   $��264,162,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $	��120��6�   
���   �
���  ��.��6�   ��5H      �� 5I      $

 0,20&�6&   $ Absolute=�66   $	 0,0&�6M   .��5J      � $ 	#FFABADB3��6#   $
 0.05Q�65   � 5K      $ 	#FFE2E3EA��6#   $
 0.07Q�65   � 5L      $	 Red��6#   $ 1Q�6/   5M      .��5N   #   5O      �� 5P   
   $��Araç Cinsi :��6   $
��Left=�6'   $��138,164,0,0q�6B   $	��Top=�6W   $	��126��6o   $��Arial Black)�6{   
���  ��6�   �� 5Q   
   -   5        $ txt_clsth_frm��5Q      $
��Left=�6)   $��24��6D   $��536,132,0,0q�6P   $
 Wrap=�6e   $	��Top=�6y   $	��120��6�   
���   �
���  ��.��6�   ��5R      �� 5S      $

 0,20&�6&   $ Absolute=�66   $	 0,0&�6M   .��5T      � $ 	#FFABADB3��6#   $
 0.05Q�65   � 5U      $ 	#FFE2E3EA��6#   $
 0.07Q�65   � 5V      $	 Red��6#   $ 1Q�6/   5W      .��5X   #   5Y      �� 5Z   
   $��Çalıştığı Firma :��6   $
��Left=�6,   $��404,130,0,0q�6G   $	��Top=�6\   $	��127��6t   $��Arial Black)�6�   
���  ��6�   �� 5[   
   $��Geliş Nedeni :��6   $
��Left=�6)   $��404,166,0,0q�6D   $	��Top=�6Y   $	��127��6q   $��Arial Black)�6}   
���  ��6�   �� 5\   
   -   5        $ txt_plak_no��5\      $
��Left=�6'   $��24��6B   $��536,100,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $	��120��6�   $ 0.5,0.5&�6�   
���   �
���  ��.��6�   ��5]      �� 5^      $

 0,20&�6&   $ Absolute=�66   $	 0,0&�6M   .��5_      � $ 	#FFABADB3��6#   $
 0.05Q�65   � 5`      $ 	#FFE2E3EA��6#   $
 0.07Q�65   � 5a      $	 Red��6#   $ 1Q�6/   5b      .��5c   #   5d      �� 5e   
   $��
Plaka No :��6   $
��Left=�6%   $��
404,98,0,0q�6@   $	��Top=�6T   $	��127��6l   $��Arial Black)�6x   
���  ��6�   �� 5f   
   ���	#FF040405$
��Left=�6%   $��51.667��6@   $��91.023,27.842,0,0q�6P   
���   �$	��Top=�6z   $��608.994��6�   $ 19.765��6�   $	 19.765��6�   $ 0.5,0.5&�6�   z�5g      V� 5h      .~�5i      �� �� 5j       �� AngleX$ 0.146Q�6$   �� 5k      $ -0.089Q�6&   T� 5l      5m      5o      �� 5p   
   -	   5        ���	#FF0F0606$
��Left=�5p   %   $��34��6@   $��120,35.836,0,0q�6L   
���   �$	��Top=�6s   $	��519��6�   $ 5.998��6�   $	 5.998��6�   $ 0.5,0.5&�6�   z�5q      V� 5r      .~�5s      �� �� 5t      $ 0.146Q�6$   �� 5u      $ -0.089Q�6&   T� 5v      5w      5y      �� 5z   
   -
   5        $��Button��5z      $��38.137��6"   $��646.305,33.611,0,0q�62   #���   6N   $	��Top=�6m   $��25(�6�   $��Arial Black)�6�   $
 Hand��6�    � ToolTip$ 	Çıkış��6�   $
��Left=�6�   $��41.97��6�   ��5{      �� 5|       �� ImageSource$ resimler/Delete.png��6   5~      �� 5   
   -   5         ��Name$ cmb_gls_ndn��5      $
��Left=�6(   $��24��6C   $��536,166,0,0q�6O   $	��Top=�6d   $	��120��6|   ��5�      �� 5�      $
 0.5,1&�6&   $ 0.5,0&�67   .��5�      � $ Black��6#   $ 0Q�61   � 5�      $	 Red��6#   $ 1Q�6/   5�      5�      � 5�   
   $
��Left=�6   $	��Top=�6+   5�      5�      