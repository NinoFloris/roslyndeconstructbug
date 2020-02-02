using System;
using System.Collections.Generic;

namespace Lib
{
    public class Foo
    {
        public static ValueTuple<Type, Type>[] BarProp = new[] { (typeof(int), typeof(int)) };

        public static ValueTuple<Type, Type>[] Bar()
            => new[] { (typeof(int), typeof(int)) };

        public static IEnumerable<ValueTuple<Type, Type>> WorkingBar()
            => new[] { (typeof(int), typeof(int)) };
    }
}
