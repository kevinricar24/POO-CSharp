namespace POO_CSharp.ReflectionExample
{
    class ReflectionClass
    {
        public readonly string Url;

        public string Topic
        {
            get
            {
                return topic;
            }
            set
            {
                topic = value;
            }
        }
        public ReflectionClass(string url)
        {
            this.Url = url;
        }
        private string topic;
    }
}
