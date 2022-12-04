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
*	    Classe Funcionario.
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
    class Funcionario : User
    {
        #region Atributos

        private int numero;
        private string departamento;
        private bool estado;
        private string reporta;

        #endregion

        #region Propriedades

        public int Numero
        {
            get { return numero; }
            set { this.numero = value; }
        }
        public string Departamento
        {
            get { return departamento; }
            set { this.departamento = value; }
        }
        public bool Estado
        {
            get { return estado; }
            set { this.estado = value; }
        }

        public string Reporta
        {
            get { return reporta; }
            set { this.reporta = value; }
        }

        #endregion

        #region Metodos
        /// <summary>
        /// Metodo DaTipo (override)
        /// Este metodo devolve o tipo de utilizador. Este metodo é obrigatório para responder
        /// ao metodo Abstrato da SuperClasse User
        /// </summary>
        /// <returns>(Int), 3- Funcionario</returns>
        /// <example>
        /// 
        ///     Funcionario obj = new Funcionario()
        ///     int tipo = obj.DaTipo();
        ///     
        ///     // tipo == 3
        ///     
        /// </example>
        public override int DaTipo()
        { return 3; }

        /// <summary>
        /// Metodo static EditaFuncionario
        /// Este metodo recebe um numero de Funcionario e devolve o objecto Funcionario preenchido.
        /// </summary>
        /// <returns>(Funcionario)</returns>
        /// <example>
        /// 
        ///     Funcionario obj = new Funcionario();
        ///     obj = Funcionario.EditaFuncionario(1);
        ///     
        /// </example>
        static public Funcionario EditaFuncionario(int numero)
        {
            Funcionario obj = new Funcionario();

            return obj;
        }

        /// <summary>
        /// Metodo static GravaFuncionario
        /// Este metodo recebe um objecto Funcionario grava a informação num ficheiro. devolve verdadeiro ou false caso tenha ou não sucesso
        /// na gravação
        /// </summary>
        /// <returns>(bool)0 - Não gravou, 1 - Gravou correctamente</returns>
        /// <example>
        /// 
        ///     Funcionario obj = new Funcionario();
        ///     
        ///     obj.Codigo = ....
        ///     
        ///     bool sucesso;
        ///     sucesso = Funcionario.GravaFuncionario(obj);
        ///     
        /// </example>
        static public bool GravaFuncionario(Funcionario obj)
        {

            return true;
        }

        /// <summary>
        /// Metodo static RemoveFuncionario
        /// Este metodo recebe um objecto Funcionario remove a informação do ficheiro. devolve verdadeiro ou false caso tenha ou não sucesso
        /// na gravação
        /// </summary>
        /// <returns>(bool)0 - Não removeu , 1 - Removeu correctamente</returns>
        /// <example>
        /// 
        ///     Funcionario obj = new Funcionario();
        ///     bool sucesso;
        ///     
        ///     sucesso = Funcionario.RemoveFuncionario(1);
        ///     
        /// </example>
        static public bool RemoveFuncionario(int numero)
        {

            return true;
        }
        #endregion

        #region Construtor
        public Funcionario()
        {


        }
        #endregion

        #region Destructor 
        ~Funcionario()
        {


        }
        #endregion

    }
}
