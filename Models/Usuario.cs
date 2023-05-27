namespace gestaodeprojetos.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Apelido { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataExpiracaoSenha { get; set; }
        public DateTime? DataBloqueio { get; set; }
        public int IdUsuarioCadastro { get; set; }
        public DateTime DataCadastro { get; set; }
        public int? IdUsuarioUltimaAlteracao { get; set; }
        public DateTime? DataUltimaAlteracao { get; set; }
    }
}