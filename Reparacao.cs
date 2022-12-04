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
*	    Classe Reparacao.
*	    	    
*	    Esta classe serve para gerir as instancias de reperação, fazendo a ligação entre os veiculos, e os parceiros.
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
    class Reparacao
    {

        #region Atributos

        private int codigo;
        private string parceiro;
        private Object veiculo;
        private DateTime data;
        private DateTime datafim;
        private string motivo;

        #endregion

        #region Propriedades

        public int Codigo
        {
            get { return codigo; }
            set { this.codigo = value; }
        }
        public string Parceiro
        {
            get { return parceiro; }
            set { this.parceiro = value; }
        }
        public Object Veiculo
        {
            get { return veiculo; }
            set { this.veiculo = value; }
        }
        public DateTime Data
        {
            get { return data; }
            set { this.data = value; }
        }
        public DateTime DataFim
        {
            get { return datafim; }
            set { this.datafim = value; }
        }
        public string Motivo
        {
            get { return motivo; }
            set { this.motivo = value; }
        }
        #endregion

        #region Metodos

        /// <summary>
        /// Metodo static EditaReparacao
        /// Este metodo recebe um numero de Reparacao e devolve o objecto Reparacao preenchido.
        /// </summary>
        /// <returns>(Reparacao)</returns>
        /// <example>
        /// 
        ///     Reparacao obj = new Reparacao();
        ///     obj = Reparacao.EditaReparacao(1);
        ///     
        /// </example>
        static public Reparacao EditaReparacao(int numero)
        {
            Reparacao obj = new Reparacao();

            return obj;
        }

        /// <summary>
        /// Metodo static GravaReparacao
        /// Este metodo recebe um objecto Reparacao grava a informação num ficheiro. devolve verdadeiro ou false caso tenha ou não sucesso
        /// na gravação
        /// </summary>
        /// <returns>(bool)0 - Não gravou, 1 - Gravou correctamente</returns>
        /// <example>
        /// 
        ///     Reparacao obj = new Reparacao();
        ///     
        ///     obj.Codigo = ....
        ///     
        ///     bool sucesso;
        ///     sucesso = Motivo.GravaReparacao(obj);
        ///     
        /// </example>
        static public bool GravaReparacao(Reparacao obj)
        {

            return true;
        }

        /// <summary>
        /// Metodo static RemoveReparacao
        /// Este metodo recebe um objecto Reparacao remove a informação do ficheiro. devolve verdadeiro ou false caso tenha ou não sucesso
        /// na gravação
        /// </summary>
        /// <returns>(bool)0 - Não removeu , 1 - Removeu correctamente</returns>
        /// <example>
        /// 
        ///     Reparacao obj = new Reparacao();
        ///     bool sucesso;
        ///     
        ///     sucesso = Reparacao.RemoveReparacao(1);
        ///     
        /// </example>
        static public bool RemoveReparacao(int numero)
        {

            return true;
        }
        #endregion

        #region Construtor
        public Reparacao()
        {


        }
        #endregion

        #region Destructor 
        ~Reparacao()
        {


        }
        #endregion

    }
}
