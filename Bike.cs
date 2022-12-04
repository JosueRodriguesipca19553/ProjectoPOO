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
*	    Classe Bike.
*	    	    
*	    Esta classe é uma subclasse da classe veiculo com informação exclusiva para bicicletas.
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
    class Bike : Veiculo
    {

        #region Atributos

        private string qr;
        private string numeroserie;

        #endregion

        #region Propriedades

        public string Qr
        {
            get { return qr; }
            set { this.qr = value; }
        }
        public string NumeroSerie
        {
            get { return numeroserie; }
            set { this.numeroserie = value; }
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Metodo static EditaBike
        /// Este metodo recebe um numero de Bike e devolve o objecto Bike preenchido.
        /// </summary>
        /// <returns>(Bike)</returns>
        /// <example>
        /// 
        ///     Bike obj = new Bike();
        ///     obj = Bike.EditaBike(1);
        ///     
        /// </example>
        static public Bike EditaBike(int numero)
        {
            Bike obj = new Bike();

            return obj;
        }

        /// <summary>
        /// Metodo static GravaBike
        /// Este metodo recebe um objecto Bike grava a informação num ficheiro. devolve verdadeiro ou false caso tenha ou não sucesso
        /// na gravação
        /// </summary>
        /// <returns>(bool)0 - Não gravou, 1 - Gravou correctamente</returns>
        /// <example>
        /// 
        ///     Bike obj = new Bike();
        ///     
        ///     obj.Codigo = ....
        ///     
        ///     bool sucesso;
        ///     sucesso = Bike.GravaBike(obj);
        ///     
        /// </example>
        static public bool GravaBike(Bike obj)
        {

            return true;
        }

        /// <summary>
        /// Metodo static RemoveBike
        /// Este metodo recebe um objecto Bike remove a informação do ficheiro. devolve verdadeiro ou false caso tenha ou não sucesso
        /// na gravação
        /// </summary>
        /// <returns>(bool)0 - Não removeu , 1 - Removeu correctamente</returns>
        /// <example>
        /// 
        ///     Bike obj = new Bike();
        ///     bool sucesso;
        ///     
        ///     sucesso = Bike.RemoveBike(1);
        ///     
        /// </example>
        static public bool RemoveBike(int numero)
        {

            return true;
        }
        #endregion

        #region Construtor
        public Bike()
        {


        }
        #endregion

        #region Destructor 
        ~Bike()
        {


        }
        #endregion

    }
}
