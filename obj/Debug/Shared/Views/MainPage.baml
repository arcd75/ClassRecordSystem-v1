   M S B A M L   `   `   `  ����  ClassRecordSystem'    !ClassRecordSystem.Shared.MainPage   5      e aDevExpress.Xpf.Controls.v13.1, Version=13.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aCdxwui7http://schemas.devexpress.com/winfx/2008/xaml/windowsui  \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      a ]DevExpress.Xpf.Core.v13.1, Version=13.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a?dxe5http://schemas.devexpress.com/winfx/2008/xaml/editors  5      ;dx2http://schemas.devexpress.com/winfx/2008/xaml/core  5      e aDevExpress.Xpf.Carousel.v13.1, Version=13.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aAdxca6http://schemas.devexpress.com/winfx/2008/xaml/carousel  5      -   5        $��Segoe UI Light)�5      $��16(�5      
�������.��5      �   � RowDefinitions  5   
   �� 5      $	��100 �6   �� 5      $��40 �6   �� 5      �� 5      $��40 �6   .+�5   
   ]� ��.  .+�5      �� $
��Left=�6   $��Bottom=�6/    �� Orientation$ 
Horizontal=�6J   $��10q�6c   .+�5      �� -   5         ��Name$ txtSchoolName��5      $��32(�63   $��5q�6A   $��Segoe UI)�6L   �� 5      $��Classroom System��6   $��Bottom=�64   $��25(�6O   $��5q�6]   5      �� 5      $��Right=�6   $��10q�60   $��Bottom=�6<   .+�5      �� -   5        $ txtUserName��5      $��25(�61   �� 5      -   5        $ 	txtAccess��5      5      5       �� 5!   
   $��1��6   $	��0 1q�6   ���	#FF5478AC
�������._�5"      ]� ��.  .+�5#      �� -   5         ��Name$ 
stackAdmin��5#   6   $ 
Horizontal=�6   $y�	Collapsed=�6J   .+�5$      �� -   5         ��Name$ btnStudents��5$      $��0q�63   
������ $
��10 0q�6`   .��5%      �� $	��0 1q�6!   ._�5&      �� $��Students��6(   5'      5(      �� 5)      -   5        $ btnTeachers��5)      $��0q�63   
������ $
��10 0q�6`   .��5*      �� $	��0 1q�6!   ._�5+      �� $��Teachers��6(   5,      5-      �� 5.      -   5        $ 
btnCourses��5.      $��0q�62   
������ $
��10 0q�6_   .��5/      �� $	��0 1q�6!   ._�50      �� $��Courses��6(   51      52      53      �� 54      -	   5        $ stackTeachers��54   6   $ 
Horizontal=�6   $y�	Collapsed=�6M   .+�55      �� -
   5        $ btnStudentsTeacher��55      $
��Left=�69   $��0q�6O   
������ $
��10 0q�6|   .��56      �� $	��0 1q�6!   ._�57      �� $��Students��6(   58      59      �� 5:      -   5        $ btnSections��5:      $
��Left=�62   $��0q�6H   
������ $
��10 0q�6u   .��5;      �� $	��0 1q�6!   ._�5<      �� $��Sections��6(   5=      5>      �� 5?      -   5        $ btnCLassroomManagement��5?      $
��Left=�6=   $��0q�6S   
������ $
��10 0q�6�   .��5@      �� $	��0 1q�6!   ._�5A      �� $��Courses��6(   5B      5C      5D      �� 5E      -   5        $ stackStudents��5E   6   $ 
Horizontal=�6   $y�	Collapsed=�6M   .+�5F      �� -   5        $ 	btnGrades��5F      $
��Left=�60   $��0q�6F   
������ $
��10 0q�6s   .��5G      �� $	��0 1q�6!   ._�5H      �� $��Grades��6(   5I      5J      �� 5K      -   5        $ btnActivities��5K      $
��Left=�64   $��0q�6J   
������ $
��10 0q�6w   .��5L      �� $	��0 1q�6!   ._�5M      �� $��
Activities��6(   5N      5O      5P      �� 5R      -   5        $ 	btnLogout��5R   0   $��Right=�6   $��0q�6[   
������ $
��10 0q�6�   .��5S      �� $	��0 1q�6   ._�5T      �� $��Logout��6$   5U      5V      �� 5W      -   5        $ btnSettings��5W   0   $��Right=�6   $��0q�6_   
������ $y�	Collapsed=�6�   $
��10 0q�6�   .��5X      �� $	��0 1q�6   ._�5Y      �� $��Settings��6$   5Z      5[      5\      5]      .  (DevExpress.Xpf.WindowsUI.NavigationFrame  5^   
   -   5          Name$ 	mainFrame��5^       $��2��63   � 5_   
   $��3��6   5a      5b      