namespace AgeOfTechAPI.Controllers.Entities
{
    public class Endereço
    {
        public string id { get; set; }

        public string Logradouro { get; set; }

        public string Numero { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public string CEP { get; set; }

        public string ClienteId { get; set; }
        
    }
}