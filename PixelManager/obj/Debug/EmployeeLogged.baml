   M S B A M L   `   `   `  ????G  CPixelManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:PixelManagerPixelManager  5   	   !    PixelManager.EmployeeLogged   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:PixelManager     5   	     ? Title$#  Рабочая область??5   	   ???#19191a$	??550??66   $
??1310??6C   .??5	      ? .+?5
   
   ?? -   5         ??Name$ BT_AllOrders??5
      $*??$Список всех заказов??6'   $
??Left=?6E   $??
990,74,0,0q?6`   $	??Top=?6t   $??46??6?   $	??144??6?   6?   ?? 5   
   -   5        $ BT_GetOrderById??5      $/??)Найти по номеру заказа??6*   $
??Left=?6K   $??1139,74,0,0q?6f   $	??Top=?6{   $??46??6?   $	??145??6?   6?   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 	DG_Orders??5         AutoGenerateColumns .  $??25,74,347,153q?6?      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ФИО??6b   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   ?? *Fio+ ?? UpdateSourceTrigger$ PropertyChanged=?6b     5      $! Номер телефона??6j    6%   ?? *PhoneNumber+$ PropertyChanged=?6j     5      $ Email??6d    6%   ?? *Email+$ PropertyChanged=?6d     5      $ Тип товара??6g    6%   ?? *
WareName+$ PropertyChanged=?6g     5      $ Детали??6f    6%   ?? *	Details+$ PropertyChanged=?6f     5      $ Имя файла??6c    6%   ?? *File+$ PropertyChanged=?6c     5      $ Номер заказа??6a    6%   ?? *Id+$ PropertyChanged=?6a   5      ?? 5   
   -   5         ??Name$ 
TB_OrderId??5      $
??Left=?6&   $??1140,125,0,0q?6A   	 ?? TextWrapping$
	 Wrap=?6W   $??Номер заказа??6k   $	??Top=?6   $	??144??6?   ???	#7F000000
???????6  ?? 5   
   -   5        $ BT_AcceptOrder??5      $??Принять заказ??6)   $
??Left=?6A   $??986,205,0,0q?6\   $	??Top=?6q   $??45??6?   $	??144??6?   6?   ?? 5   
   -   5        $ BT_Production??5      $'??!Заказ выполняется??6(   $
??Left=?6D   $??1140,205,0,0q?6_   $	??Top=?6u   $??45??6?   $	??144??6?   6?   ?? 5   
   -   5        $ BT_Done??5      $??Заказ готов??6"   $
??Left=?68   $??984,267,0,0q?6S   $	??Top=?6h   $??45??6?   $	??146??6?   6?   ?? 5   
   $??
Поиск??6   $
??Left=?6    $??1111,27,0,0q?6;   $	??Top=?6P   $??16(?6h   ???	#FFC7C7C7$
??Bold"?6?   ?? 5   
   $)??#Управление заказом??6   $
??Left=?6-   $??1060,158,0,0q?6H   $	??Top=?6^   $??16(?6v   ???	#FFC7C7C7$
??Bold"?6?   ?? 5   
   -   5        $ 	BT_Remove??5      $??Удалить??6$   $
??Left=?66   $??1140,267,0,0q?6Q   $	??Top=?6g   $??45??6   $	??146??6?   6?   ?? 5   
   $#??Таблица заказов??6   $
??Left=?6*   $??
448,27,0,0q?6E   $	??Top=?6Y   $??16(?6q   ???	#FFC7C7C7$
??Bold"?6?   ?? 5   
   -	   5        
 ??Name$
 L_SelectedOrder??5      $F??@Заказ № (Выберите заказ из таблицы)??6)   $
??Left=?6W   $??389,386,0,0q?6r   $	??Top=?6?   $??16(?6?   ???	#FFC7C7C7$
??Bold"?6?   ?? 5    
   -
   5        $
 L_DateCreationOrder??5       $%??Дата оформления: ??6-   $
??Left=?6I   $??
39,425,0,0q?6d   $	??Top=?6x   $??16(?6?   ???	#FFC7C7C7$
??Bold"?6?   ?? 5!   
   -   5        $
 L_DateAcceptionOrder??5!      $.??(Дата принятия заказа: ??6.   $
??Left=?6O   $??
39,475,0,0q?6j   $	??Top=?6~   $??16(?6?   ???	#FFC7C7C7$
??Bold"?6?   ?? 5"   
   -   5        $
 L_Production??5"      $)??#Заказ выполняется: ??6&   $
??Left=?6D   $??353,425,0,0q?6_   $	??Top=?6t   $??16(?6?   ???	#FFC7C7C7$
??Bold"?6?   ?? 5#   
   -   5        $
 L_Done??5#      $??Заказ готов: ??6    $
??Left=?68   $??353,475,0,0q?6S   $	??Top=?6h   $??16(?6?   ???	#FFC7C7C7$
??Bold"?6?   5$      5%      