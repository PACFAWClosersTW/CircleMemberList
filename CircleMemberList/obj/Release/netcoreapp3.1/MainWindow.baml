   M S B A M L   `   `   `  ���� K  GCircleMemberList, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:CircleMemberListCircleMemberList  !    CircleMemberList.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     0localclr-namespace:CircleMemberList     -     �Name$  CircleMemberInfo�� � Title$ 
MainWindow��$	��700��$
��1000��$��Disabled=�$
��1000��$	��700�� � Icon$/ )/DLG_UNIT_SELECT_IMG_GUST_USER_CASTER.PNG��.��� ���	#FFF3CACA$
��1000��$	��700�� � ColumnDefinitions �� $	��10* ��� $	��38* ��� $
��227* ��� $	��61* ��� $
��334* ��� $
��142* ��� $	��93* ��� $	��49* ��� $	��46* �.+��� $��4��$
��Left=�$	��361��$��306,314,0,0q�$	��Top=�$	��391��$C��=/HQ_SKILL_SCEN_BG_BIG_GUST_USER_CASTER_MIDSUMMER_MELODY_D.PNG��$��5���� -    ��Name$ CircleMemberList��$��4��$��
0,55,32,10q����	#FFF3CACA �� AlternationCount$ 0��$��1�� �� View �� -   GridMemberListView��.P��� $	��NO.�� �� Width$ 50�� �� DisplayMemberBinding �� *Number+�� $
��Name��$	 300�� �� *Name+�� $��	Hierarchy��$	 150�� �� *	Hierarchy+�� $
��Date��$	 128�� �� *Date+�� $'��!Circle Member List of Seulbi ver.��$
��Left=�$��0,10,0,0q�$	��Top=�$��40��$	��436��$��28(�$��Times New Roman)�$��4��$��1���� $��Name : ��$
��Left=�$��5,23,0,0q�$	��Top=�$��40��$��76��$��20(�$��Times New Roman)�$��5��	 J� RenderTransformOrigin$	 
0.47,1.687&��� $��Hierarchy : ��$
��Left=�$��
309,63,0,0q�$	��Top=�$��40��$��98��$��20(�$��Times New Roman)�$��4��$	 0.215,0.512&�$��2���� $��Date : ��$
��Left=�$��	5,103,0,0q�$	��Top=�$��40��$��68��$��20(�$��Times New Roman)�$��5���� -   
 ��Name$
 NameText��$��5��$
��Left=�$��	81,28,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��172��$��30��4  .System.Windows.Automation.AutomationProperties   Name$ NameText�� �� SelectionOpacity$ 1Q�$��Times New Roman)�$��20(�$��3���� -   $
 HierarchyText��$��5��$
��Left=�$��	81,68,0,0q�$
 Wrap=�$	��Top=�$	��172��$��30��$ HierarchyText��$ 1Q�$��Times New Roman)�$��20(�$��3���� -   $
 DateText��$��5��$
��Left=�$��
81,108,0,0q�$
 Wrap=�$	��Top=�$	��172��$��30��$ DateText��$ 1Q�$��Times New Roman)�$��20(�$��3���� -    ��Name$	 Add��$
��Add.��$��5��$
��Left=�$��
17,152,0,0q�$	��Top=�$	��114��$��39��$��Times New Roman)�$��20(��� -   $ Remove��$��Remove.��$��5��$
��Left=�$��139,152,0,0q�$	��Top=�$	��114��$��39��$��Times New Roman)�$��20(�$��3���� -	   $ MoveUp��$��Move Up.��$��5��$
��Left=�$��
17,211,0,0q�$	��Top=�$	��114��$��39��$��Times New Roman)�$��20(��� -
   $ MoveDown��$��
Move Down.��$��5��$
��Left=�$��139,211,0,0q�$	��Top=�$	��114��$��39��$��Times New Roman)�$��20(�$��3���� -   $ ReadTxt��$��Read.��$��5��$
��Left=�$��
17,268,0,0q�$	��Top=�$	��114��$��39��$��Times New Roman)�$��20(��� -   $ 	OutputTxt��$��Output.��$��5��$
��Left=�$��139,270,0,0q�$	��Top=�$	��114��$��39��$��Times New Roman)�$��20(�$��3��