/*
* 	<author>
* 	    Aluno : 19553 , Josué Rodrigues
* 	    Aluno : 1154  , Fernando Moura
* 	    Aluno : 5606  , Gil Oliveira
* 	</author>
*   <date>
*       05/12/2022
*   </date>
*	<description>
*	    Trabalho prático Unidade Curricular de :
*	    Programação Orientada a Objectos
*	</description>
*	<email>
*	    Josué Rodrigues : a19553@alunos.ipca.pt
*	    Fernando Moura  :  a1154@alunos.ipca.pt
*	    Gil Oliveira    :  a5606@alunos.ipca.pt
*	</email>
*	
**/
using System;

[assembly: CLSCompliant(false)]

#region Numeradores_TipoOperação
// Estados de repareção
public enum Estado
{
    Operacional = 0,
    Avariada = 1,
    Manutencao = 2,
    Ocupada = 3
}

#endregion

namespace POO_TrabalhoPratico
{
    class Program
    {
        static void Main(string[] args)
        {

            Engine MainEngine = new Engine();
            MainEngine.Start();

        }
    }
}
