   M S B A M L   `   `   `  ����D  @CarsRents, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:CarsRents	CarsRents  5   	       CarsRents.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:CarsRents     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      �� 5      $��31 �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��1��6.   $��Center=�6;   .+�5      �� -   5         ��Name$ 
Btn_Create��5      $��Создать��6)   $��	15,3,15,3q�6;   6N   5      �� 5   
   -   5         ��Name$ TabCtrl��5      .@�5      �� -   5         ��Name$ TabRents��5      $��Аренда��6(   .��5      &   System.Windows.Controls.DataGrid  -   5          Name$ 
DGridRents��5      $��0��6/      AutoGenerateColumns .     
IsReadOnly . ��5      �� 5      	 �� 
TargetType)  #System.Windows.Controls.DataGridRow"	  6    .�5      -   5        5      
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Дата начала��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6B   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5      `� 5   "    �� StringFormat$ {0}.{1}.{2}��6/   .1�5   &   ��  �� Path$ BeginDate.Day�6.   �� 5   &   $ BeginDate.Month�6.   �� 5    &   $ BeginDate.Year�6.   5!   #   5#        5$      $! Дата окончания��6-   $ * 6E    5%      `� 5&   "   $ {0}.{1}.{2}��6/   .1�5'   &   �� $ EndDate.Day�6.   �� 5(   &   $ EndDate.Month�6.   �� 5)   &   $ EndDate.Year�6.   5*   #   5,        5-      $ Клиент��6-   $ * 6\    6=   �� *
DriverName+6\     5.      $ Атомобиль��6-   $ * 6^    6@   �� *	Car.Model+6^     5/      $ 
Сумма��6-   $ * 6V    6<   �� *Price+6V   51      52      �� 54      -   5        $ TabCars��54      $��Авто��6'   .��55        -   5        $ 	DGridCars��55      $��0��6.    .   . ��56      �� 57      "	  6    .�58      -   5        59      
 5;        5<      $ Модель��6-   $ * 6W    6=   �� *Model+6W     5=      $ Гос. номер��6-   $ * 6b    6A   �� *LicensePlate+6b   5?      5@      �� 5B      -	   5        $ TabUsers��5B      $��Пользователи��6(   .��5C        -
   5        $ 
DGridUsers��5C      $��0��6/    .   . ��5D      �� 5E      "	  6    .�5F      -   5        5G      
 5I        5J      $ 
Логин��6-   $ * 6V    6<   �� *Login+6V   5L      5M      5O      5P      5Q      