# TI_Grafos

# Objetivo geral
  Fazer a especificação de um Sistema de Gestão de horários de disciplinase implementar algumas funcionalidades. 
  
# Alocação de horários
  Considere que você seja o responsável para montar o horário do curso de Sistemas de Informação –São  Gabriel(noite) da  PUC  Minas. O  problema  consiste  em  alocar  os professores às suas disciplinas de forma a maximizar o número de disciplinas em paralelo. Considere  que  alguns  professores  possam  ministrar  diversas  disciplinas,  e  que  por  dia, possamos ter 2 horários de alocação. Além disso, lembre-se que disciplinas do mesmo período não podem ser alocadaspara o mesmo horário e que uma disciplina só pode ser ministrada por um professor.
  
#  Objetivo do projeto 
  Proponha  e  implemente  uma heurística  sobre  grafos  que  seja capaz  de  auxiliar  na montagem dos horários. Sua heurística deve tentar maximizar o número de disciplinas em paralelo.  Para  isto,  você  deve  modelar  o  problema  por  meio  de  grafos  (deixe  claro  os conjuntos  de  vértices  e  arestas)  e  sua  solução  deve  contemplar  inteiramente  técnicas (algoritmos) baseadas em grafos.
  
  Será fornecido um conjunto de arquivos de entrada como exemplo no seguinte padrão:
  nome_da_disciplina nome_do_professor período
  
  Você deverá utilizar as disciplinas do seu curso como entrada para resolução do problema. Você  pode  alterar  a  distribuição  dos  professores  que  lecionam  as  disciplinas,  mas  os períodos  devem  se  manter  inalterados.  Lembre-se  que  uma  disciplina  só  pode  ser lecionada por um professor. 
  
# O que deve ser feito
  Neste trabalho sua tarefa é:&nbsp;
  
  - [ ] Modelar o problema como um grafo. -- Esta sendo definido, a ideia inicial e bipartido
  - [ ] Implementar uma estrutura de dados para a representação de um grafo adequado ao problema, bem como operações para a edição do grafo. --- Não foi escolhido a estrutura
  - [ ] Escrever um programa que permita: Ler o arquivo com os dados iniciais na sintaxe fornecida no item 3.1, carregando em memória a sua  representação equivalente  por meio da estrutura de dados para representação de grafos que você desenvolveu. -- A definir responsavel
  - [ ] Implementar uma heurística sobre o grafo modelado para resolver o problema. -- A definir responsavel
  - [ ] Imprimir uma relação que mostre as disciplinas alocada (com o nome do professor) em cada horário para cada período. -- A definir responsavel
  - [ ] Um documento contendo introdução (descrição do problema), indicando os objetivos do trabalho e as linhas gerais de seu desenvolvimento; uma explicação detalhada da solução adotada para modelar e resolver o problema usando a teoria de grafos (apresentar como o  grafo  foi  modelado);  uma  descrição  do  algoritmo  utilizado  para  resolver  o  problema proposto (pode incluir o pseudocódigodo algoritmo), o código fonte; os testes realizados e seus resultados.Uma conclusão ressaltando o que de mais importante foi observado. Se utilizar alguma referência, não se esqueça de fazer a citação.  -- Douglas?
  - [ ] Entregue  também  um  arquivo .txt orientando  como  deve  ser  executado  o  código. -- A definir responsavel
