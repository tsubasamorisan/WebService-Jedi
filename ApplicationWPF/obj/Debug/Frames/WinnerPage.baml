   M S B A M L   `   `   `  ????I  EApplicationWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:ApplicationWPF.UserControlsApplicationWPF.UserControls  5      =#clr-namespace:ApplicationWPF.FramesApplicationWPF.Frames  5      &     ApplicationWPF.Frames.WinnerPage   5      :UserControls)clr-namespace:ApplicationWPF.UserControls  5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:ApplicationWPF.Frames     5      -   5          N? Title$  
WinnerPage??5      .??5      ? -   5         ?Name$ 	WinnerFic??5      ??5   
   ?? 5         StarWarsImageBackGround6 ?? ImageSource# [  6    ? RowDefinitions 5   
   ?? 5      $	??100 ?6   ?? 5      ?? 5      $	??100 ?6   .+?5   
   ?? $??0??6   
???   ? J? Opacity$	 0.9Q?61   ._?5      ??  ?? Orientation$ 
Horizontal=?6   $??Center=?62   $??Center=?6M   .+?5      ??   StarWarsFontStyle#??[ 61   $??50(?6]   ??6   ?? *Nom+ J? Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 50Q?6+      Color$
 Gold??6;   	   	Direction$	 0Q?5   #   
   ShadowDepth$
 10Q?61   5      ?? 5      $?? vainqueur !??6   #??[ 60   $??50(?6\    5        5       $ 50Q?6+   $
 Gold??6;   $	 0Q?5!   #   $
 10Q?61   5#      5$      5&      ?? 5(   
   $??1??6   $??Center=?6:   $??Center=?6U   ??6   ?? *
ImageUri+ 5)        5*      $ 50Q?6#   $
 Gold??63   $	 0Q?5+   #   $
 10Q?61   5-      ,   &ApplicationWPF.UserControls.ButtonSoft  5.   
   ,   &ApplicationWPF.UserControls.ButtonSoft   Event$ ButtonSoft_Event??6?   $??2??6"      Label$ Quitter??6/   $??Center=?6Y   $
??Left=?6t   $??50,0,0,0q?6?   5/      50      