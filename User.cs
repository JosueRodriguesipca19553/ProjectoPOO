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
*	    Classe User.
*	    	    
*	    Esta classe é uma classe abtracta com os atributos comuns as suas subclasses
*	    Aqui deverão estar associdas todo o tipo de utilizador, seja aluno, professor ou
*	    colaborador do IPCA.
*	    
*	    O metodo abstrato serve para obrigar que as classes tenham essa definição, a 
*	    descrição do metodo está descrita abaixo.
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
    abstract class User
    {
        #region Atributos

        private int codigo;
        private string nome;
        private string morada;
        private string local;
        private string nif;
        private string email;

        #endregion

        #region Propriedades

        public int Codigo
        {
            get { return codigo; }
            set { this.codigo = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { this.nome = value; }
        }
        public string Morada
        {
            get { return morada; }
            set { this.morada = value; }
        }
        public string Local
        {
            get { return local; }
            set { this.local = value; }
        }
        public string Nif
        {
            get { return nif; }
            set { this.nif = value; }
        }

        public string Email
        {
            get { return email; }
            set { this.email = value; }
        }

        #endregion

        #region Metodos Abstratos
        /// <summary>
        /// Metodo DaTipo
        /// Este metodo devolve o tipo de utilizador .
        /// </summary>
        /// <returns>(Int), 1- Aluno, 2- Docente, 3- Funcionario</returns>
        /// <example>
        /// 
        ///     Aluno obj = new Aluno()
        ///     int tipo = obj.DaTipo();
        ///     
        ///     // tipo == 1
        ///     
        /// </example>
        public abstract int DaTipo();

        #endregion

        #region Construtor
        public User()
        {


        }
        #endregion

        #region Destructor 
        ~User()
        {


        }
        #endregion

    }
}
