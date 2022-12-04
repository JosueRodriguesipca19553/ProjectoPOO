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
*	    Classe Automovel.
*	    	    
*	    Esta classe é uma subclasse da classe veiculo com informação exclusiva para automoveis.
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
    class Automovel : Veiculo
    {

        #region Atributos

        private string potencia;
        private string autonomia;
        private string lugares;
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
        public string Lugares
        {
            get { return lugares; }
            set { this.lugares  = value; }
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Metodo static EditaAutomovel
        /// Este metodo recebe um numero de automovel e devolve o objecto automovel preenchido.
        /// </summary>
        /// <returns>(Automovel)</returns>
        /// <example>
        /// 
        ///     Automovel obj = new Automovel();
        ///     obj = Automovel.EditaAutomovel(1);
        ///     
        /// </example>
        static public Automovel EditaAutomovel(int numero)
        {
            Automovel obj = new Automovel();

            return obj;
        }

        /// <summary>
        /// Metodo static GravaAutomovel
        /// Este metodo recebe um objecto Automovel grava a informação num ficheiro. devolve verdadeiro ou false caso tenha ou não sucesso
        /// na gravação
        /// </summary>
        /// <returns>(bool)0 - Não gravou, 1 - Gravou correctamente</returns>
        /// <example>
        /// 
        ///     Automovel obj = new Automovel();
        ///     
        ///     obj.Codigo = ....
        ///     
        ///     bool sucesso;
        ///     sucesso = Automovel.GravaAutomovel(obj);
        ///     
        /// </example>
        static public bool GravaAutomovel(Automovel obj)
        {

            return true;
        }

        /// <summary>
        /// Metodo static RemoveAutomovel
        /// Este metodo recebe um objecto Automovel remove a informação do ficheiro. devolve verdadeiro ou false caso tenha ou não sucesso
        /// na gravação
        /// </summary>
        /// <returns>(bool)0 - Não removeu , 1 - Removeu correctamente</returns>
        /// <example>
        /// 
        ///     Automovel obj = new Automovel();
        ///     bool sucesso;
        ///     
        ///     sucesso = Automovel.RemoveAutomovel(1);
        ///     
        /// </example>
        static public bool RemoveAutomovel(int numero)
        {

            return true;
        }
        #endregion

        #region Construtor
        public Automovel()
        {


        }
        #endregion

        #region Destructor 
        ~Automovel()
        {


        }
        #endregion

    }
}
