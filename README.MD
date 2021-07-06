## 💻 Projeto 💻 
Projeto em Csharp usando classes abstratas

## ⚫Abstração em POO com C#

<p>A abstração é um dos recursos que tornam o paradigma de programação orientada a objetos tão útil e
interessante de se trabalhar em projetos consideravelmente complexos. Classes e métodos abstratos, em POO,
servem para moldar uma estrutura comum para entidades (classes) de um programa que compartilham algumas
características, mas que diferem em outras.</p>

<p>Suponha que seja necessário criar várias classes que possuem algumas características e comportamentos em
comum, mas que ao mesmo tempo possuem suas particularidades, o que impede de se trabalhar com uma única
classe. Nessas situações, podemos criar uma classe superior que sirva como molde para as demais, definindo sua
estrutura base e que tenha, ou não, métodos já implementados por padrão.</p>

<p>Para os métodos cuja execução seja comum a todas as classes filhas, pode-se implementá-los ainda na classe
abstrata, e todas as classes filhas herdarão o mesmo comportamento. Já aqueles métodos que serão
implementados de formas distintas nas classes que os herdarão, podem ser declarados apenas como uma
assinatura, sem corpo, para que cada classe filha os implemente como for mais adequado.</p>

<p>Os métodos que devem ser implementados ainda na classe mãe não devem ser marcados como abstratos, pois
essa definição é apenas para os métodos que serão implementados pelas classes filhas. Também é importante
destacar que classes abstratas não podem ser instanciadas, elas servem apenas como molde para herança por
classes filhas. E todas as classes abstratas devem ser, obrigatoriamente, escritas na classe filha.</p>


## Diagrama utilizado
<p align="center">
<img width="100%" src="Diagrama/diagramaAbstracaoAnimal.png">
</p>

------
Feito por Amadeu Filipe Lopes 👋🏽 [Entre em contato!](https://www.linkedin.com/in/amadeu-filipe-lopes12/)
⌨<br />



