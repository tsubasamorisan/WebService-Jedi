   M S B A M L   `   `   `  ????I  EApplicationWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:ApplicationWPF.UserControlsApplicationWPF.UserControls  5      I)clr-namespace:ApplicationWPF.UserControlsApplicationWPF.UserControls  5      $    ApplicationWPF.Frames.PlayPage   5      5Gestion)clr-namespace:ApplicationWPF.UserControls  W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      BUserControls)clr-namespace:ApplicationWPF.UserControls     5      -   5          N? Title$  PlayPage??5
       N? 
Background 5      ?? 5   
      StarWarsImageBackGround4 ?? ImageSource# [  6    ? 	Resources 5      ??%    5      .??5      ?  ? RowDefinitions 5   
   ?? 5      ?? 5      ?? 5      ?? 5      ?? 5      $	??100 ?6    ? ColumnDefinitions 5   
   ?? 5      $??2* ?6   ?? 5      $??3* ?6   .+?5   
   ,   &ApplicationWPF.UserControls.PlayChoice  -   5          Name$ usrSolo??5   "   ,   &ApplicationWPF.UserControls.PlayChoice   Event$! OnPlayChoiceOnePlayer_Click??5    "   $??0??5   "   $??0??6/     StarWarsImageBackGround1   PlayChoiceImSource# [ 6?   	   PlayChoiceTitle$	 Armée d'un seul homme??5   "   
   PlayChoiceDescription$

 Solo??5   "   5    "     5!   
   -   5        $ usrMulti??5!   "   $# OnPlayChoiceMultiplayer_Click??5%   "   $??1??5"   "   $??0??6/     StarWarsImageBackGround8# [ 6?   $	 Bataille au sommet??5#   "   $
 Multiplayer??5$   "   5%   "     5&   
   -   5        $ usrPariSolo??5&   "   $  OnPlayChoiceSoloPari_Click??5*   "   $??2??5'   "   $??0??6/     StarWarsImageBackGround3# [ 6?   $	 Marchand de mort??5(   "   $
 	Pari Solo??5)   "   5*   "     5+   
   -   5        $ usrPariMulti??5+   "   $' !OnPlayChoiceMultiplayerPari_Click??5/   "   $??3??5,   "   $??0??6/     StarWarsImageBackGround2# [ 6?   $	 Les Vendeurs d'âmes??5-   "   $
 Pari Multiplayer??5.   "   5/   "   ,   &ApplicationWPF.UserControls.ButtonSoft  50   
   ,   &ApplicationWPF.UserControls.ButtonSoft   Event$ ButtonBack_Event??6{   $??4??6"   $??0??6/   $
??Left=?6?   $??50,0,0,0q?6Z      Label$ Retour??6l   6{     51   
   $ ButtonStart_Event??6|   $??4??6"   $??3??6/   $??Right=?6?   $??0,0,50,0q?6[   $ Start??6n   6|   ? 53   
   $??1??6   $??2??6   $??4??63   $??20,10,10,10q?6D   
???   ? J? Opacity$	 0.9Q?6l    54      ?? 55      $	??100 ?6    ?? 56      $??3* ?6    ?? 57      $??1* ?6    .+?59      ? $??0??6   $	??Top=?6     5:      ?? 5;      $	??125 ?6$   .+?5=      ? $??0??6    5>      ?? 5?      $??1* ?6+   ?? 5@      $??4* ?6+   .+?5B      ?? $??0??6      StarWarsFontStyle#??[ 60   $??Tournoi??6[   1   +ApplicationWPF.UserControls.ComboBoxTournoi  5C      -   5          Name$ usrCtrlTournoiCombo??5C   3   $??1??6P   5D      5E      ?? 5F      -   5         ??Name$ tournamentDetails??5F      $??1??61   
?????? $??Stretch=?6W   $??5q?6?   $??0q?6?   ??6s   ?? *Matchs+??5G      ?? 5H      .R?5I      ??  ?? Orientation$ 
Horizontal=?6%   $??5q?6>   .+?5J      ?? $??70??6J   $??50??6V   ??6$   ?? *obj_Jedi1.ImageUri+6V   ?? 5K      #??[ 6?   $??5q?6j   $??20(?6u   ??6(   ?? *Jedi1+6u   ?? 5L      $?? Vs. ??6(   #??[ 65   
???  ??6`   ?? 5M      #??[ 6?   $??5q?6j   $??20(?6v   ??6(   ?? *Jedi2+6v   ?? 5N      $??70??6K   $??50??6W   ??6$   ?? *obj_Jedi2.ImageUri+6W   5O      5P      5R       ? 5S      -   5          ?Name$ 
ModeChoice??5S      $??2??6(   $??5q?65     ? NavigationUIVisibility$ Hidden=?6A   5U      5V      5W      5X      