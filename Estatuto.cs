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
*	    Classe Estatuto.
*	    	    
*	    Esta classe é uma classe de suporte á classe Aluno
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
    class Estatuto
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
        /// Metodo static EditaEstatuto
        /// Este metodo recebe um numero de Estatuto e devolve o objecto Estatuto preenchido.
        /// </summary>
        /// <returns>(Estatuto)</returns>
        /// <example>
        /// 
        ///     Estatuto obj = new Estatuto();
        ///     obj = Estatuto.EditaEstatuto(1);
        ///     
        /// </example>
        static public Estatuto EditaEstatuto(int numero)
        {
            Estatuto obj = new Estatuto();

            return obj;
        }

        /// <summary>
        /// Metodo static GravaEstatuto
        /// Este metodo recebe um objecto Estatuto grava a informação num ficheiro. devolve verdadeiro ou false caso tenha ou não sucesso
        /// na gravação
        /// </summary>
        /// <returns>(bool)0 - Não gravou, 1 - Gravou correctamente</returns>
        /// <example>
        /// 
        ///     Estatuto obj = new Estatuto();
        ///     
        ///     obj.Codigo = ....
        ///     
        ///     bool sucesso;
        ///     sucesso = Estatuto.GravaEstatuto(obj);
        ///     
        /// </example>
        static public bool GravaEstatuto(Estatuto obj)
        {

            return true;
        }

        /// <summary>
        /// Metodo static RemoveEstatuto
        /// Este metodo recebe um objecto Estatuto remove a informação do ficheiro. devolve verdadeiro ou false caso tenha ou não sucesso
        /// na gravação
        /// </summary>
        /// <returns>(bool)0 - Não removeu , 1 - Removeu correctamente</returns>
        /// <example>
        /// 
        ///     Estatuto obj = new Estatuto();
        ///     bool sucesso;
        ///     
        ///     sucesso = Estatuto.RemoveEstatuto(1);
        ///     
        /// </example>
        static public bool RemoveEstatuto(int numero)
        {

            return true;
        }
        #endregion

        #region Construtor
        public Estatuto()
        {


        }
        #endregion

        #region Destructor 
        ~Estatuto()
        {


        }
        #endregion

    }
}
