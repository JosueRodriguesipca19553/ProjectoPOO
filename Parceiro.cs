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
*	    Classe Parceiro.
*	    	    
*	    Esta classe para gerir os parceiros que fazem as reparações aos veiculos .
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
    class Parceiro
    {

        #region Atributos

        private string codigo;
        private string descricao;
        private string morada;
        private string local;
        private string nif;
        private string email;

        #endregion

        #region Propriedades

        public string Codigo
        {
            get { return codigo; }
            set { this.codigo = value; }
        }
        public string Descricao
        {
            get { return descricao; }
            set { this.descricao = value; }
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

        #region Metodos

        /// <summary>
        /// Metodo static EditaParceiro
        /// Este metodo recebe um numero de Parceiro e devolve o objecto Parceiro preenchido.
        /// </summary>
        /// <returns>(Parceiro)</returns>
        /// <example>
        /// 
        ///     Parceiro obj = new Parceiro();
        ///     obj = Motivo.EditaParceiro(1);
        ///     
        /// </example>
        static public Parceiro EditaParceiro(int numero)
        {
            Parceiro obj = new Parceiro();

            return obj;
        }

        /// <summary>
        /// Metodo static GravaParceiro
        /// Este metodo recebe um objecto Parceiro grava a informação num ficheiro. devolve verdadeiro ou false caso tenha ou não sucesso
        /// na gravação
        /// </summary>
        /// <returns>(bool)0 - Não gravou, 1 - Gravou correctamente</returns>
        /// <example>
        /// 
        ///     Parceiro obj = new Parceiro();
        ///     
        ///     obj.Codigo = ....
        ///     
        ///     bool sucesso;
        ///     sucesso = Motivo.GravaParceiro(obj);
        ///     
        /// </example>
        static public bool GravaParceiro(Parceiro obj)
        {

            return true;
        }

        /// <summary>
        /// Metodo static RemoveParceiro
        /// Este metodo recebe um objecto Parceiro remove a informação do ficheiro. devolve verdadeiro ou false caso tenha ou não sucesso
        /// na gravação
        /// </summary>
        /// <returns>(bool)0 - Não removeu , 1 - Removeu correctamente</returns>
        /// <example>
        /// 
        ///     Parceiro obj = new Parceiro();
        ///     bool sucesso;
        ///     
        ///     sucesso = Parceiro.RemoveParceiro(1);
        ///     
        /// </example>
        static public bool RemoveParceiro(int numero)
        {

            return true;
        }
        #endregion

        #region Construtor
        public Parceiro()
        {


        }
        #endregion

        #region Destructor 
        ~Parceiro()
        {


        }
        #endregion
        
    }
}
