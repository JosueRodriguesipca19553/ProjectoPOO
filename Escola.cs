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
*	    
*	    Classe Escola.
*	    	    
*	    Esta classe é uma classe de suporte á classe Docente e Curso
*	    
*	</description>
*	<email>
*	    Josué Rodrigues : a19553@alunos.ipca.pt
*	    Fernando Moura  :  a1154@alunos.ipca.pt
*	    Gil Oliveira    :  a5606@alunos.ipca.pt
*	</email>
**/
using System;
using System.Collections.Generic;
using System.Text;

namespace POO_TrabalhoPratico
{
    class Escola
    {
        #region Atributos

        private int codigo;
        private string descricao;

        #endregion

        #region Propriedades

        public int Codigo
        {
            get { return codigo; }
            set { this.codigo = value; }
        }
        public string Descricao
        {
            get { return descricao; }
            set { this.descricao = value; }
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Metodo static EditaEscola
        /// Este metodo recebe um numero de Escola e devolve o objecto Escola preenchido.
        /// </summary>
        /// <returns>(Escola)</returns>
        /// <example>
        /// 
        ///     Escola obj = new Escola();
        ///     obj = Escola.EditaEscola(1);
        ///     
        /// </example>
        static public Escola EditaEscola(int numero)
        {
            Escola obj = new Escola();

            return obj;
        }

        /// <summary>
        /// Metodo static GravaEscola
        /// Este metodo recebe um objecto Escola grava a informação num ficheiro. devolve verdadeiro ou false caso tenha ou não sucesso
        /// na gravação
        /// </summary>
        /// <returns>(bool)0 - Não gravou, 1 - Gravou correctamente</returns>
        /// <example>
        /// 
        ///     Escola obj = new Escola();
        ///     
        ///     obj.Codigo = ....
        ///     
        ///     bool sucesso;
        ///     sucesso = Docente.GravaEscola(obj);
        ///     
        /// </example>
        static public bool GravaEscola(Escola obj)
        {

            return true;
        }

        /// <summary>
        /// Metodo static RemoveEscola
        /// Este metodo recebe um objecto Escola remove a informação do ficheiro. devolve verdadeiro ou false caso tenha ou não sucesso
        /// na gravação
        /// </summary>
        /// <returns>(bool)0 - Não removeu , 1 - Removeu correctamente</returns>
        /// <example>
        /// 
        ///     Escola obj = new Escola();
        ///     bool sucesso;
        ///     
        ///     sucesso = Escola.RemoveEscola(1);
        ///     
        /// </example>
        static public bool RemoveEscola(int numero)
        {

            return true;
        }
        #endregion

        #region Construtor
        public Escola()
        {


        }
        #endregion

        #region Destructor 
        ~Escola()
        {


        }
        #endregion
    }
}
