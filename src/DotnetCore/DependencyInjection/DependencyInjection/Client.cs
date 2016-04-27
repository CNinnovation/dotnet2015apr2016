namespace DependencyInjection
{
    public class Client
    {
        private readonly IMyService _service;
        public Client(IMyService service)
        {
            _service = service;
        }

        public void Doit()
        {
            _service.Foo();
        }
    }
}
