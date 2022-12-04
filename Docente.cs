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
*	    Classe Docente.
*	    	    
*	    Esta classe é uma subclasse da classe User
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
    class Docente : User
    {
        #region Atributos

        private int numero;
        private string escola;

        #endregion

        #region Propriedades

        public int Numero
        {
            get { return numero; }
            set { this.numero = value; }
        }
        public string Escola
        {
            get { return escola; }
            set { this.escola = value; }
        }

        #endregion

        #region Metodos
        /// <summary>
        /// Metodo DaTipo (override)
        /// Este metodo devolve o tipo de utilizador. Este metodo é obrigatório para responder
        /// ao metodo Abstrato da SuperClasse User
        /// </summary>
        /// <returns>(Int), 2- Docente</returns>
        /// <example>
        /// 
        ///     Docente obj = new Docente()
        ///     int tipo = obj.DaTipo();
        ///     
        ///     // tipo == 2
        ///     
        /// </example>
        public override int DaTipo()
        { return 2; }

        /// <summary>
        /// Metodo static EditaDocente
        /// Este metodo recebe um numero de Docente e devolve o objecto Docente preenchido.
        /// </summary>
        /// <returns>(Docente)</returns>
        /// <example>
        /// 
        ///     Docente obj = new Docente();
        ///     obj = Docente.EditaDocente(1);
        ///     
        /// </example>
        static public Docente EditaDocente(int numero)
        {
            Docente obj = new Docente();

            return obj;
        }

        /// <summary>
        /// Metodo static GravaDocente
        /// Este metodo recebe um objecto Docente grava a informação num ficheiro. devolve verdadeiro ou false caso tenha ou não sucesso
        /// na gravação
        /// </summary>
        /// <returns>(bool)0 - Não gravou, 1 - Gravou correctamente</returns>
        /// <example>
        /// 
        ///     Docente obj = new Docente();
        ///     
        ///     obj.Codigo = ....
        ///     
        ///     bool sucesso;
        ///     sucesso = Docente.GravaDocente(obj);
        ///     
        /// </example>
        static public bool GravaDocente(Docente obj)
        {

            return true;
        }

        /// <summary>
        /// Metodo static RemoveDocente
        /// Este metodo recebe um objecto Docente remove a informação do ficheiro. devolve verdadeiro ou false caso tenha ou não sucesso
        /// na gravação
        /// </summary>
        /// <returns>(bool)0 - Não removeu , 1 - Removeu correctamente</returns>
        /// <example>
        /// 
        ///     Docente obj = new Docente();
        ///     bool sucesso;
        ///     
        ///     sucesso = Docente.RemoveDocente(1);
        ///     
        /// </example>
        static public bool RemoveDocente(int numero)
        {

            return true;
        }
        #endregion

        #region Construtor
        public Docente()
        {


        }
        #endregion

        #region Destructor 
        ~Docente()
        {


        }
        #endregion
    }
}
