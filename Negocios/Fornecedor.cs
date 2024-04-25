using AcessoBD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public string Razao { get; set; }
        public string Cnpj { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        Conexao con;

        public bool Salvar()
        {
            con = new Conexao();
            string insere = $"insert into tb03_fornecedor values (" +
                $"null, '{Razao}', '{Cnpj}', '{Telefone}', '{Email}')";

            return con.Executa(insere);

        }

        public bool Atualizar()
        {
            con = new Conexao();
            string atualiza = $"update tb03_fornecedor set tb03_razao= '{Razao}', " +
                $"tb03_cnpj='{Cnpj}', tb03_telefone='{Telefone}', tb03_email='{Email}'," +
                $" where tb03_id={Id}";
            return con.Executa(atualiza);

        }

        public bool Excluir()
        {
            con = new Conexao();
            string excluir = $"delete from tb03_fornecedor where tb03_id={Id}";
            return con.Executa(excluir);

        }

        public DataTable Pesquisar()
        {
            con = new Conexao();
            string pesquisa = $"select * from tb03_fornecedor where tb03_cnpj='{Cnpj}'";
            return con.Retorna(pesquisa);
        }

        public DataTable PesquisarTodos()
        {
            con = new Conexao();
            string pesquisa = $"select * from tb03_fornecedor";
            return con.Retorna(pesquisa);
        }
    }
}
