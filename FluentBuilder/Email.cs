namespace FluentBuilder
{
    public class Email
    {
        public string Body { get; set; }
        public string From { get; set; }
        public string Subject { get; set; }
        public string To { get; set; }

        public override string ToString()
        {
            return ($"Destino : {To} - Origem:{From}\nAssunto:{Subject}\n \t{Body}\n");
        }
    }
}