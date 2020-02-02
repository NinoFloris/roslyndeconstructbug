using System;

namespace CSharp
{
    class Program
    {
        static void Error()
        {
            foreach (var (x, y) in Lib.Foo.Bar()) { }
        }

        static ValueTuple<Type, Type>[] BarSameAssembly()
            => new[] { (typeof(int), typeof(int)) };

        static void Success()
        {
            foreach (var (x, y) in BarSameAssembly()) { }
            foreach (var (x, y) in Lib.Foo.BarProp) { }
            foreach (var (x, y) in Lib.Foo.WorkingBar()) { }
        }

        static void Main(string[] args)
        {
        }
    }
}
