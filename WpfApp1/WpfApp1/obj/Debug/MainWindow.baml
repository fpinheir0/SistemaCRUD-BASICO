   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  Tela Estoque de Produtos��5   	   $	��450��6*   $	��626��67   $��5,5,5,4q�6C    � 
ResizeMode$ NoResize=�6]    � WindowStartupLocation$ CenterScreen=�6s    � WindowStyle$ 
ToolWindow=�6�   ���	#FF343434.��5	      � .+�5
   
   �� $��Estoque de Produto��6   $
��Left=�6-   $��	10,10,0,0q�6H   $	��Top=�6[   $
��20px(�6s   ���	#FFC3BCBC6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGrid��5   5   $��2��6   $��10,68,10,55q�6       
IsReadOnly .    AutoGenerateColumns .     AlternatingRowBackground �	#FFE5E5E5 �� AlternationCount$ 2��5   T   $��2��6i   ��5   Y   �� *ListaProdutos+	 �� SelectedItem	 6   �� *UsuarioSelecionado+
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ CODIGO��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 65   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6A   �� *Codigo+  5      $ 	DESCRICAO��6%   $	 100 68    6D   �� *	Descricao+  5      $
 QTDE��6%   $ 50 63    6>   �� *QTDE+  5      $ MARCA��6%   $	 100 64    6@   �� *Marca+  5      $ MODELO��6%   $	 100 65    6A   �� *Modelo+5      �� 5      -   5        $��
btn_salvar��5      $��Adicionar Registro��6E   $
��Left=�6b   $��130,375,0,0q�6}   $	��Top=�6�   $	��107��6�   $��27��6�   ���	#FFFDFDFD��6'   �� *	Adicionar+6�   �� 5   
   -   5        $��btn_deletar��5      $��Remover Registro��6@   $
��Left=�6[   $��242,375,0,0q�6v   $	��Top=�6�   $	��107��6�   $��27��6�   ���	#FFFFFEFE��6$   �� *	Remover+6�   �� 5   
   -   5        $��
btn_editar��5      $��Editar Registro��6>   $
��Left=�6X   $��354,375,0,0q�6s   $	��Top=�6�   $	��107��6�   $��27��6�   
���������6#   �� *Editar+6�   5      5      