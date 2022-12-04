/*
* 	<author>
* 	    Aluno : 19553 , Josué Rodrigues
* 	    Aluno : 1154  , Fernando Moura
* 	</author>
*   <date>
*       05/12/2022
*   </date>
*	<description>
*	    Trabalho prático Unidade Curricular de :
*	    Programação Orientada a Objectos
*	    
*	    Classe Veiculo.
*	    	    
*	    Esta classe é uma classe abtracta com os atributos comuns as suas subclasses
*	    Aqui deverão estar associdas todo o tipo de veiculos, seja bicicletas, bicicletas eletricas ,
*	    trotinetes ou automoveis
*	    
*	</description>
*	<email>
*	    Josué Rodrigues : a19553@alunos.ipca.pt
*	    Fernando Moura  :  a1154@alunos.ipca.pt
*	</email>
**/
using System;
using System.Collections.Generic;
using System.Text;

namespace POO_TrabalhoPratico
{
    abstract class Veiculo
    {

        #region Atributos

        private int codigo;
        private bool estado;

        #endregion

        #region Propriedades

        public int Codigo
        {
            get { return codigo; }
            set { this.codigo = value; }
        }
        public bool Estado
        {
            get { return estado; }
            set { this.estado = value; }
        }

        #endregion

        #region Construtor
        public Veiculo()
        {


        }
        #endregion

        #region Destructor 
        ~Veiculo()
        {


        }
        #endregion

    }
}
