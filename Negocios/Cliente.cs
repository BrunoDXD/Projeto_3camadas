using AcessoBD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class Cliente
    {
        public string cpf { get; set; }
        public string nome { get; set; }
        public string endereco { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        Conexao con;

        public bool Salvar()
        {
            con = new Conexao();
            string insere = $"insert into tb04_cliente values (" +
                $"'{cpf}', '{nome}', '{endereco}', '{telefone}', '{email}')";

            return con.Executa(insere);

        }

        public bool Atualizar()
        {
            con = new Conexao();
            string atualiza = $"update tb04_cliente set tb04_nome= '{nome}', " +
                $"tb03_endereco='{endereco}', tb03_telefone='{telefone}', tb03_email='{email}'," +
                $" where tb03_cpf={cpf}";
            return con.Executa(atualiza);

        }

        public bool Excluir()
        {
            con = new Conexao();
            string excluir = $"delete from tb04_cliente where tb04_cpf={cpf}";
            return con.Executa(excluir);

        }

        public DataTable Pesquisar()
        {
            con = new Conexao();
            string pesquisa = $"select * from tb04_cliente where tb04_cpf='{cpf}'";
            return con.Retorna(pesquisa);
        }

        public DataTable PesquisarTodos()
        {
            con = new Conexao();
            string pesquisa = $"select * from tb04_cliente";
            return con.Retorna(pesquisa);
        }
    }

   
}
