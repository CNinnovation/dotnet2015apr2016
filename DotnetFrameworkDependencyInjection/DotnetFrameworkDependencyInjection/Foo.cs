using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DotnetFrameworkDependencyInjection
{
    public class Foo : IFoo
    {
        private readonly IBar _bar;
        public Foo(IBar bar)
        {
            _bar = bar;
        }
        void IFoo.Foo()
        {
            WriteLine(nameof(Foo));
            _bar.Bar();
        }
    }

    public class Bar : IBar
    {
        void IBar.Bar()
        {
            WriteLine(nameof(Bar));
        }
    }
}
