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
*	    Classe eBike.
*	    	    
*	    Esta classe é uma subclasse da classe veiculo com informação exclusiva para bicicletas eletricas.
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
    class eBike : Veiculo
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
        /// Metodo static EditaeBike
        /// Este metodo recebe um numero de eBike e devolve o objecto eBike preenchido.
        /// </summary>
        /// <returns>(eBike)</returns>
        /// <example>
        /// 
        ///     eBike obj = new eBike();
        ///     obj = eBike.EditaeBike(1);
        ///     
        /// </example>
        static public eBike EditaeBike(int numero)
        {
            eBike obj = new eBike();

            return obj;
        }

        /// <summary>
        /// Metodo static GravaeBike
        /// Este metodo recebe um objecto eBike grava a informação num ficheiro. devolve verdadeiro ou false caso tenha ou não sucesso
        /// na gravação
        /// </summary>
        /// <returns>(bool)0 - Não gravou, 1 - Gravou correctamente</returns>
        /// <example>
        /// 
        ///     eBike obj = new eBike();
        ///     
        ///     obj.Codigo = ....
        ///     
        ///     bool sucesso;
        ///     sucesso = Docente.GravaeBike(obj);
        ///     
        /// </example>
        static public bool GravaeBike(eBike obj)
        {

            return true;
        }

        /// <summary>
        /// Metodo static RemoveeBike
        /// Este metodo recebe um objecto eBike remove a informação do ficheiro. devolve verdadeiro ou false caso tenha ou não sucesso
        /// na gravação
        /// </summary>
        /// <returns>(bool)0 - Não removeu , 1 - Removeu correctamente</returns>
        /// <example>
        /// 
        ///     eBike obj = new eBike();
        ///     bool sucesso;
        ///     
        ///     sucesso = eBike.RemoveeBike(1);
        ///     
        /// </example>
        static public bool RemoveeBike(int numero)
        {

            return true;
        }
        #endregion

        #region Construtor
        public eBike()
        {


        }
        #endregion

        #region Destructor 
        ~eBike()
        {


        }
        #endregion
    }
}
