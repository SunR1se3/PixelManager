   M S B A M L   `   `   `  ????G  CPixelManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:PixelManagerPixelManager  5   	       PixelManager.AdminLogged   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:PixelManager     5   	     ? Title$  Админ панель??5   	   $	??450??6   $	??800??6+   ???#19191a ? 	Resources 5	       ?? 
TargetType ?? Property ?? Value ?? 
TargetType-  'System.Windows.Input.KeyboardNavigation   TabNavigation ? RowDefinitions K? ZIndex	 K? IsItemsHost
   TabIndex ?? CornerRadius   DirectionalNavigation ?? Triggers P? Property P? Value ?? 
TargetName??%?  '??       ?? 5
   
   " ??6   .?5      ??  ?@?OverridesDefaultStyle . 66   ?? 5       ?@J?SnapsToDevicePixels . 64   ?? 5       ? ?? 5      ?? 5      " ??6&   .R?5      ? $ Local=?6    5      ?? 5   "   $
??Auto ?60   ?? 5   "   $??* ?60   .+?5      ?? $??HeaderPanel??5      $??0??5      $ 1??5      $??0,0,4,-1q?5      	 . $
 1??5      
?????? 5      ?? 5      $??Border??5      $??1??5      
???????
?????? $??1q?5"      $ 2??5#      $ Local=?5$      $ 	Contained=?5%      $
 2??5&      ._?5'   "   ?? $??PART_SelectedContentHost??5(      $??0q?5)      $??SelectedContent??5*      5+      5,       5-      P? 5.       ? {? .  . ?5/   "   ??  ? ??
 ?????6?   ?? 50   "   $ Border??6)    ? ??
 ???? 6T   51      53      55      56      57      .??58      ? .+?59   
   ?? $??0q?6   .@?5:      ?? $??TabItem??6   .??5;      ? ???#19191a.+?5<      ?? $1??+Редактировать страницу??6   $
??Left=?6>   $??
239,56,0,0q?6Y   $	??Top=?6m   $??31??6?   $	??161??6?   ?? 5=      -   5         ??Name$ CB_ChangePage??5=      $
??Left=?66   $??
405,56,0,0q?6Q   $	??Top=?6e   $	??120??6}   $??31??6?    ?? SelectedIndex$ 0??6?   .@?5>      ?? test6*   5?      ?? 5@      -   5        $ CB_DisableService??5@      $
??Left=?6:   $??405,101,0,0q?6U   $	??Top=?6j   $	??120??6?   $??31??6?   $ 0??6?   .@?5A      ?? Визитки6-   ?? 5B      Таблички6.   ?? 5C      )'Сувенирная продукция6:   ?? 5D      #!Печать документов67   ?? 5E      Печати и штампы65   ?? 5F      Полиграфия60   ?? 5G      #!Печать фотографий67   5H      ?? 5I      -   5         ??Name$ BT_DisableService??5I      $%??Отключить услугу??68   $
??Left=?6S   $??239,101,0,0q?6n   $	??Top=?6?   $??31??6?   $	??161??6?   6?   5J      5K      ?? 5L      $??TabItem??6   $??20??6'   $	??Top=?63   .??5M      ? ???#19191a.+?5N      (  "System.Windows.Controls.WebBrowser  -   5          Name$ Browser??5N   !   5O      5P      5Q      5S      5T      