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
*	    Classe Trotinete.
*	    	    
*	    Esta classe é uma subclasse da classe veiculo com informação exclusiva para trotinetes.
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
    class Trotinete : Veiculo
    {

        #region Atributos

        private string potencia;
        private string autonomia;
        private string numeroserie;

        #endregion

        #region Propriedades

        public string Autonomia
        {
            get { return autonomia; }
            set { this.autonomia = value; }
        }

        public string Potencia
        {
            get { return potencia; }
            set { this.potencia = value; }
        }
        public string NumeroSerie
        {
            get { return numeroserie; }
            set { this.numeroserie = value; }
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Metodo static EditaTrotinete
        /// Este metodo recebe um numero de Trotinete e devolve o objecto Trotinete preenchido.
        /// </summary>
        /// <returns>(Trotinete)</returns>
        /// <example>
        /// 
        ///     Trotinete obj = new Trotinete();
        ///     obj = Reparacao.EditaTrotinete(1);
        ///     
        /// </example>
        static public Trotinete EditaTrotinete(int numero)
        {
            Trotinete obj = new Trotinete();

            return obj;
        }

        /// <summary>
        /// Metodo static GravaTrotinete
        /// Este metodo recebe um objecto Reparacao grava a informação num ficheiro. devolve verdadeiro ou false caso tenha ou não sucesso
        /// na gravação
        /// </summary>
        /// <returns>(bool)0 - Não gravou, 1 - Gravou correctamente</returns>
        /// <example>
        /// 
        ///     Trotinete obj = new Trotinete();
        ///     
        ///     obj.Codigo = ....
        ///     
        ///     bool sucesso;
        ///     sucesso = Motivo.GravaTrotinete(obj);
        ///     
        /// </example>
        static public bool GravaTrotinete(Trotinete obj)
        {

            return true;
        }

        /// <summary>
        /// Metodo static RemoveTrotinete
        /// Este metodo recebe um objecto Trotinete remove a informação do ficheiro. devolve verdadeiro ou false caso tenha ou não sucesso
        /// na gravação
        /// </summary>
        /// <returns>(bool)0 - Não removeu , 1 - Removeu correctamente</returns>
        /// <example>
        /// 
        ///     Trotinete obj = new Trotinete();
        ///     bool sucesso;
        ///     
        ///     sucesso = Reserva.RemoveTrotinete(1);
        ///     
        /// </example>
        static public bool RemoveTrotinete(int numero)
        {

            return true;
        }
        #endregion

        #region Construtor
        public Trotinete()
        {


        }
        #endregion

        #region Destructor 
        ~Trotinete()
        {


        }
        #endregion

    }
}
