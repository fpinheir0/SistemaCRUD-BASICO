   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.EditaProduto   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��630��6)    � WindowStyle$ 
ToolWindow=�65   $��5,5,5,4q�6N    � 
ResizeMode$ NoResize=�6h    � WindowStartupLocation$ CenterScreen=�6~   .��5	      � .+�5
   
   �� $��Estoque de Produto��6   $
��Left=�6-   $��	10,10,0,0q�6H   $	��Top=�6[   $	��422��6s   $
��20px(�6   �� 5   
   $��10,275,10,27q�6�   ��6>   �� *ListaProdutos+ �� SelectedItem 6e   �� *UsuarioSelecionado+ �� View 5      �� 5      .P�5      ��  �� DisplayMemberBinding 6%   �� *Codigo+�� 5       6%   �� *	Descricao+�� 5       6%   �� *QTDE+�� 5       6%   �� *Marca+�� 5       6%   �� *Modelo+5      5      �� 5   
   $��DESCRIÇÃO��6   $
��Left=�6$   $��	99,70,0,0q�6?   $	��Top=�6R   �� 5   
   $��CODIGO��6   $
��Left=�6!   $��	10,70,0,0q�6<   $	��Top=�6O   �� 5   
   $
��QTDE��6   $
��Left=�6   $��
405,70,0,0q�6:   $	��Top=�6N   �� 5   
   $��MARCA��6   $
��Left=�6    $��
10,137,0,0q�6;   $	��Top=�6O   �� 5   
   $��MODELO��6   $
��Left=�6!   $��221,137,0,0q�6<   $	��Top=�6Q   �� 5   
   -   5        $��tbox_codigo��5      $
��Left=�6%   $��
10,101,0,0q�6@    �� TextWrapping$
 Wrap=�6T   $	��Top=�6�   $��55��6�   $��24��6�   ��6h   �� *Codigo+6�   �� 5   
   -   5        $��tbox_descricao��5      $
��Left=�6(   $��
99,101,0,0q�6C   $
 Wrap=�6W   $	��Top=�6�   $	��295��6�   $��24��6�   ��6k   �� *	Descricao+6�   �� 5   
   -   5        $��	tbox_qtde��5      $
��Left=�6#   $��405,101,0,0q�6>   $
 Wrap=�6S   $	��Top=�6}   $��55��6�   $��24��6�   ��6g   �� *QTDE+6�   �� 5   
   -   5        $��
tbox_marca��5      $
��Left=�6$   $��
10,163,0,0q�6?   $
 Wrap=�6S   $	��Top=�6~   $	��194��6�   $��24��6�   ��6g   �� *Marca+6�   �� 5   
   -   5        $��tbox_modelo��5      $
��Left=�6%   $��221,163,0,0q�6@   $
 Wrap=�6U   $	��Top=�6�   $	��194��6�   $��24��6�   ��6i   �� *Modelo+6�   �� 5    
   -   5        $��AdicionarButton��5       $��Adicionar Registro��6)   $
��Left=�6l   $��
10,217,0,0q�6�   $	��Top=�6�   $	��107��6�   $��27��6�   ��6F   �� *AdicionarRegistro+6�   �� 5!   
   -   5        $��cancelButton��5!       �� IsCancel . $��Cancelar Registro��65   $
��Left=�6Q   $��122,217,0,0q�6l   $	��Top=�6�   $	��107��6�   $��27��6�   5#      5$      