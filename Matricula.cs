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
*	    Classe Matricula.
*	    	    
*	    Esta classe serve para gerir os anos de matricula dos alunos ( relação com a classe Aluno ).
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
    class Matricula
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
        /// Metodo static EditaMatricula
        /// Este metodo recebe um numero de Matricula e devolve o objecto Matricula preenchido.
        /// </summary>
        /// <returns>(Matricula)</returns>
        /// <example>
        /// 
        ///     Matricula obj = new Matricula();
        ///     obj = Matricula.EditaMatricula(1);
        ///     
        /// </example>
        static public Matricula EditaMatricula(int numero)
        {
            Matricula obj = new Matricula();

            return obj;
        }

        /// <summary>
        /// Metodo static GravaMatricula
        /// Este metodo recebe um objecto Matricula grava a informação num ficheiro. devolve verdadeiro ou false caso tenha ou não sucesso
        /// na gravação
        /// </summary>
        /// <returns>(bool)0 - Não gravou, 1 - Gravou correctamente</returns>
        /// <example>
        /// 
        ///     Matricula obj = new Matricula();
        ///     
        ///     obj.Codigo = ....
        ///     
        ///     bool sucesso;
        ///     sucesso = Matricula.GravaMatricula(obj);
        ///     
        /// </example>
        static public bool GravaMatricula(Matricula obj)
        {

            return true;
        }

        /// <summary>
        /// Metodo static RemoveMatricula
        /// Este metodo recebe um objecto Matricula remove a informação do ficheiro. devolve verdadeiro ou false caso tenha ou não sucesso
        /// na gravação
        /// </summary>
        /// <returns>(bool)0 - Não removeu , 1 - Removeu correctamente</returns>
        /// <example>
        /// 
        ///     Matricula obj = new Matricula();
        ///     bool sucesso;
        ///     
        ///     sucesso = Matricula.RemoveMatricula(1);
        ///     
        /// </example>
        static public bool RemoveMatricula(int numero)
        {

            return true;
        }
        #endregion

        #region Construtor
        public Matricula()
        {


        }
        #endregion

        #region Destructor 
        ~Matricula()
        {


        }
        #endregion

    }
}
