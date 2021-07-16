namespace OOP
{
    //Class definition
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Nacionalidade { get; set; }
        public double Altura { get; set; }
        public double Peso { get; set; }

    }

    public class Object
    {
        public Object()
        {
            //Object definition
            var pessoa = new Pessoa
            {
                Nome = "Willian Chicanoski",
                Idade = 27,
                Nacionalidade = "Brasileiro",
                Altura = 1.76,
                Peso = 90.0
            };
        }
    }
}
