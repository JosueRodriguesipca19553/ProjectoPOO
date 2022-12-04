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
*	    Classe Motivo.
*	    	    
*	    Esta classe serve para gerir os motivos de reparação.
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
    class Motivo
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
        /// Metodo static EditaMotivo
        /// Este metodo recebe um numero de Motivo e devolve o objecto Motivo preenchido.
        /// </summary>
        /// <returns>(Motivo)</returns>
        /// <example>
        /// 
        ///     Motivo obj = new Motivo();
        ///     obj = Motivo.EditaMotivo(1);
        ///     
        /// </example>
        static public Motivo EditaMotivo(int numero)
        {
            Motivo obj = new Motivo();

            return obj;
        }

        /// <summary>
        /// Metodo static GravaMotivo
        /// Este metodo recebe um objecto Motivo grava a informação num ficheiro. devolve verdadeiro ou false caso tenha ou não sucesso
        /// na gravação
        /// </summary>
        /// <returns>(bool)0 - Não gravou, 1 - Gravou correctamente</returns>
        /// <example>
        /// 
        ///     Motivo obj = new Motivo();
        ///     
        ///     obj.Codigo = ....
        ///     
        ///     bool sucesso;
        ///     sucesso = Motivo.GravaMotivo(obj);
        ///     
        /// </example>
        static public bool GravaMotivo(Motivo obj)
        {

            return true;
        }

        /// <summary>
        /// Metodo static RemoveMotivo
        /// Este metodo recebe um objecto Motivo remove a informação do ficheiro. devolve verdadeiro ou false caso tenha ou não sucesso
        /// na gravação
        /// </summary>
        /// <returns>(bool)0 - Não removeu , 1 - Removeu correctamente</returns>
        /// <example>
        /// 
        ///     Motivo obj = new Motivo();
        ///     bool sucesso;
        ///     
        ///     sucesso = Motivo.RemoveMotivo(1);
        ///     
        /// </example>
        static public bool RemoveMotivo(int numero)
        {

            return true;
        }
        #endregion

        #region Construtor
        public Motivo()
        {


        }
        #endregion

        #region Destructor 
        ~Motivo()
        {


        }
        #endregion

    }
}
