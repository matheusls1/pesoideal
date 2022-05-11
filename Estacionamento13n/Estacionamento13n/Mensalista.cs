using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamentoExercicio
{
    class Mensalista
    {
        private int codigo;
        private string nome;
        private string telefone;
        private string endereco;
        private DateTime dataDePagamento;
        private double valorMensal;



        //declaro o métado construtor



        public Mensalista()
        {



            //Instaciando as variáveis
            this.codigo = 0;
            this.nome = "";
            this.telefone = "";
            this.endereco = "";
            this.dataDePagamento = new DateTime();
            this.valorMensal = 0;



        }//Fim do construtor



        //Métos de acesso
        public int ConsultarCodigo
        {
            get
            {
                return codigo;



            }
            set
            {
                this.codigo = value;



            }



        }//Fim do Métado de consultar codigo



        public string ConsultarNome
        {
            get
            {
                return nome;
            }
            set
            {
                this.nome = value;
            }



        }//Fim do Métodos de Consultar Nome



        public string ConsultarTelefone
        {
            get
            {
                return telefone;
            }



            set
            {
                this.telefone = value;
            }



        }//Fim do Métodos de consultar Telefone



        public string ConsultarEndereco
        {
            get
            {
                return endereco;
            }
            set
            {
                this.endereco = value;
            }



        }//Fim do Métodos consultar endereço



        public DateTime ConsultarDataDepagmento
        {
            get
            {
                return DataDePagamento;
            }
            set
            {
                this.dataDePagamento = 0;

            }
            //Fim do Método consultar DataDePagamento
             public double valorMensal
        {
            get
            {
                return valorMensal;
            }
            set
            {
                this.valorMensal = value;

            }



        }//Fim do Método consultar valor mensal
        public void Cadastrar(int codigo, string nome, string telefone, string endereco, DateTime dataDePagamento, double valorMensal)
        {
            ConsultarCodigo = codigo;
            ConsultarNome = Nome;
            ConsultarTelefone = Telefone;
            ConsultarEndereco = Endereco;
            ConsultarDataDePagamento = DataDePagamento;
            ConsultarValorTotal = ValorTotal;

        }//fim do metodo cadastrar

        //metodo consultar
        public string ConsultarTudo()
        {

          string msg = "------ Resultado da Consulta ------"+
          "/nCódigo: " +ConsultarCodigo+
          "/nNome:   " +ConsultarNome+
          "/nTelefone" +ConsultarTelefone+
          "/nEndereco" +ConsultarEndereco+
          "/nDataDepagamento " +ConsultarDataDepagmento+
          "/nValorTotal "     +ConsultarTudo
        }




    }
}
