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
*	    Classe Curso.
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
    class Curso
    {
        #region Atributos

        private int codigo;
        private string descricao;
        private string escola;

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

        public string Escola
        {
            get { return escola; }
            set { this.escola = value; }
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Metodo static EditaCurso
        /// Este metodo recebe um numero de Curso e devolve o objecto Curso preenchido.
        /// </summary>
        /// <returns>(Curso)</returns>
        /// <example>
        /// 
        ///     Curso obj = new Curso();
        ///     obj = Curso.EditaCurso(1);
        ///     
        /// </example>
        static public Curso EditaCurso(int numero)
        {
            Curso obj = new Curso();

            return obj;
        }

        /// <summary>
        /// Metodo static GravaCurso
        /// Este metodo recebe um objecto Curso grava a informação num ficheiro. devolve verdadeiro ou false caso tenha ou não sucesso
        /// na gravação
        /// </summary>
        /// <returns>(bool)0 - Não gravou, 1 - Gravou correctamente</returns>
        /// <example>
        /// 
        ///     Curso obj = new Curso();
        ///     
        ///     obj.Codigo = ....
        ///     
        ///     bool sucesso;
        ///     sucesso = Curso.GravaCurso(obj);
        ///     
        /// </example>
        static public bool GravaCurso(Curso obj)
        {

            return true;
        }

        /// <summary>
        /// Metodo static RemoveCurso
        /// Este metodo recebe um objecto Curso remove a informação do ficheiro. devolve verdadeiro ou false caso tenha ou não sucesso
        /// na gravação
        /// </summary>
        /// <returns>(bool)0 - Não removeu , 1 - Removeu correctamente</returns>
        /// <example>
        /// 
        ///     Curso obj = new Curso();
        ///     bool sucesso;
        ///     
        ///     sucesso = Curso.RemoveCurso(1);
        ///     
        /// </example>
        static public bool RemoveCurso(int numero)
        {

            return true;
        }
        #endregion

        #region Construtor
        public Curso()
        {


        }
        #endregion

        #region Destructor 
        ~Curso()
        {


        }
        #endregion
    }
}
