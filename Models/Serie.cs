namespace ProjetoCadastroDio
{
    public class Serie : EntidadeBase
    {
        private string Genero { get; set; }
        private string Titulo { get; set; }

        private string Descricao { get; set; }
        private int Ano { get; set; }
        public bool Excluido { get; set; }

        public Serie(int id, Genero genero, string Titulo, string Descricao, int Ano)
        {
            this.Id = id;
            this.Genero = Genero;
            this.Titulo = Titulo;
            this.Descricao = Descricao;
            this.Ano = Ano;
            this.Excluido = false;
        }

        public override string ToString()
        {   
            string retorno = " ";
            retorno += $"Genero: {this.Genero + Environment.NewLine}";
            retorno += $"Título: {this.Titulo + Environment.NewLine}";
            retorno += $"Descrição: {this.Descricao + Environment.NewLine}";
            retorno += $"Ano do Início: {this.Ano + Environment.NewLine}";

            return retorno;
        }
        public string RetornaTitulo()
        {
            return this.Titulo;
        }
        public int RetornaId()
        {
            return this.Id;
        }
        public void Excluir()
        {
            this.Excluido = true;
        }

    }
}