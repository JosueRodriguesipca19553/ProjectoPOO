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
*	    Classe Reserva.
*	    	    
*	    Esta classe gere as reservas e faz a ligação entre o utuilizador e o veiculo.
*	    
*	</description>
*	<email>
*	    Josué Rodrigues : a19553@alunos.ipca.pt
*	    Fernando Moura  :  a1154@alunos.ipca.pt
*	    Gil Oliveira    :  a5606@alunos.ipca.pt
*	</email>
**/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace POO_TrabalhoPratico
{
    class Reserva
    {

        #region Atributos

        private int codigo;
        private Object user;
        private Object veiculo;
        private DateTime data;
        private DateTime datafim;
        private bool fechado;

        #endregion

        #region Propriedades

        public int Codigo
        {
            get { return codigo; }
            set { this.codigo = value; }
        }
        public Object User
        {
            get { return user; }
            set { this.user = value; }
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
        public bool Fechado
        {
            get { return fechado; }
            set { this.fechado = value; }
        }
        #endregion

        #region Metodos

        /// <summary>
        /// Metodo static EditaReserva
        /// Este metodo recebe um numero de Reserva e devolve o objecto Reserva preenchido.
        /// </summary>
        /// <returns>(Reserva)</returns>
        /// <example>
        /// 
        ///     Reserva obj = new Reserva();
        ///     obj = Reparacao.EditaReserva(1);
        ///     
        /// </example>
        static public Reserva EditaReserva(int numero)
        {
            Reserva obj = new Reserva();

            return obj;
        }

        /// <summary>
        /// Metodo static GravaReserva
        /// Este metodo recebe um objecto Reparacao grava a informação num ficheiro. devolve verdadeiro ou false caso tenha ou não sucesso
        /// na gravação
        /// </summary>
        /// <returns>(bool)0 - Não gravou, 1 - Gravou correctamente</returns>
        /// <example>
        /// 
        ///     Reserva obj = new Reserva();
        ///     
        ///     obj.Codigo = ....
        ///     
        ///     bool sucesso;
        ///     sucesso = Motivo.GravaReserva(obj);
        ///     
        /// </example>
        static public bool GravaReserva(Reserva obj)
        {

            return true;
        }

        /// <summary>
        /// Metodo static RemoveReserva
        /// Este metodo recebe um objecto Reserva remove a informação do ficheiro. devolve verdadeiro ou false caso tenha ou não sucesso
        /// na gravação
        /// </summary>
        /// <returns>(bool)0 - Não removeu , 1 - Removeu correctamente</returns>
        /// <example>
        /// 
        ///     Reserva obj = new Reserva();
        ///     bool sucesso;
        ///     
        ///     sucesso = Reserva.RemoveReserva(1);
        ///     
        /// </example>
        static public bool RemoveReserva(int numero)
        {

            return true;
        }

        /// <summary>
        /// Metodo static GetReservas
        /// Este metodo recebe um tipo de user e devolve uma colletion com todas as reservas efectuadas
        /// </summary>
        /// <returns>(ArrayList)</returns>
        /// <example>
        /// 
        ///     Reserva obj = new Reserva();
        ///     ArrayList aList = new ArrayList();
        ///     
        ///     aList = Reserva.GetReservas(1,1);
        ///     // Reserva do Aluno (1) com o codigo 1
        ///     
        ///     aList = Reserva.GetReservas(2,1);
        ///     // Reserva do Funcionario (2) com o codigo 1
        ///     
        /// </example>

        static public ArrayList GetReservas(int tipo, int codigo)
        {
            ArrayList aList = new ArrayList();


            return aList;
        }

        #endregion

        #region Construtor
        public Reserva()
        {


        }
        #endregion

        #region Destructor 
        ~Reserva()
        {


        }
        #endregion

    }
}
