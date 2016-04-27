using static System.Console;

namespace DependencyInjection
{
    public class MyService : IMyService
    {
        public void Foo() => WriteLine($"{nameof(MyService)}.{nameof(Foo)}");
    }
}
