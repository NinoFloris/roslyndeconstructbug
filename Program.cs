using System;

namespace CSharp
{
    class Program
    {
        static void Error()
        {
            foreach (var (x, y) in Lib.Foo.Bar()) { }
        }

        static ValueTuple<Type, Type>[] HelloSameAssembly()
            => new[] { (typeof(int), typeof(int)) };

        static void Success()
        {
            foreach (var (x, y) in HelloSameAssembly()) { }
            foreach (var (x, y) in Lib.Foo.WorkingBar()) { }
        }

        static void Main(string[] args)
        {
        }
    }
}
