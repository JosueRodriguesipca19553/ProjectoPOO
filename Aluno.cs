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
*	    Classe Aluno.
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
    class Aluno : User
    {

        #region Atributos

        private int numero;
        private string curso;
        private bool estado;
        private int ano;          // Ano de criação do aluno, o ano de matricula actual á gerido pela classe de matriculas
        private string estatuto;

        #endregion

        #region Propriedades

        public int Numero
        {
            get { return numero; }
            set { this.numero  = value; }
        }
        public string Curso
        {
            get { return curso; }
            set { this.curso = value; }
        }
        public bool Estado
        {
            get { return estado; }
            set { this.estado = value; }
        }
        public int Ano
        {
            get { return ano; }
            set { this.ano= value; }
        }
        public string Estatuto
        {
            get { return estatuto; }
            set { this.estatuto = value; }
        }

        #endregion

        #region Metodos
        /// <summary>
        /// Metodo DaTipo (override)
        /// Este metodo devolve o tipo de utilizador. Este metodo é obrigatório para responder
        /// ao metodo Abstrato da SuperClasse User
        /// </summary>
        /// <returns>(Int), 1- Aluno</returns>
        /// <example>
        /// 
        ///     Aluno obj = new Aluno()
        ///     int tipo = obj.DaTipo();
        ///     
        ///     // tipo == 1
        ///     
        /// </example>
        public override int DaTipo()
        { return 1; }

        /// <summary>
        /// Metodo static EditaAluno
        /// Este metodo recebe um numero de aluno e devolve o objecto aluno preenchido.
        /// </summary>
        /// <returns>(Aluno)</returns>
        /// <example>
        /// 
        ///     Aluno obj = new Aluno();
        ///     obj = Aluno.EditaAluno(1);
        ///     
        /// </example>
        static public Aluno EditaAluno(int numero)
        {
            Aluno obj = new Aluno();

            return obj;
        }

        /// <summary>
        /// Metodo static GravaAluno
        /// Este metodo recebe um objecto aluno grava a informação num ficheiro. devolve verdadeiro ou false caso tenha ou não sucesso
        /// na gravação
        /// </summary>
        /// <returns>(bool)0 - Não gravou, 1 - Gravou correctamente</returns>
        /// <example>
        /// 
        ///     Aluno obj = new Aluno();
        ///     
        ///     obj.Codigo = ....
        ///     obj.Nome = ...
        ///     
        ///     bool sucesso;
        ///     sucesso = Aluno.GravaAluno(obj);
        ///     
        /// </example>
        static public bool GravaAluno(Aluno obj)
        {

            return true;
        }

        /// <summary>
        /// Metodo static RemoveAluno
        /// Este metodo recebe um objecto aluno remove a informação do ficheiro. devolve verdadeiro ou false caso tenha ou não sucesso
        /// na gravação
        /// </summary>
        /// <returns>(bool)0 - Não removeu , 1 - Removeu correctamente</returns>
        /// <example>
        /// 
        ///     Aluno obj = new Aluno();
        ///     bool sucesso;
        ///     
        ///     sucesso =Aluno.RemoveAluno(1);
        ///     
        /// </example>
        static public bool RemoveAluno(int numero)
        {

            return true;
        }

        #endregion

        #region Construtor
        public Aluno()
        { 
        
        
        }
        #endregion

        #region Destructor 
        ~Aluno()
        { 
        
        
        }
        #endregion

    }
}
