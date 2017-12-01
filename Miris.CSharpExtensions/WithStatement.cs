using System;

namespace Miris.CSharpExtensions
{
    public static partial class CSharpExtensions
    {
        /// <summary>
        ///     VB-like With Statement.
        /// </summary>
        /// <example>
        /// with(new List(), _ => {
        ///     _.Add(1);
        ///     _.Add(2);
        /// });
        /// </example>
        public static T with<T>(T Object, Action<T> then)
        {
            then(Object);
            return Object;
        }

        /// <summary>
        ///     VB-like With Statement.
        /// </summary>
        /// <example>
        /// var qtd = with(new List(), _ => {
        ///     _.Add(1);
        ///     return _.Count;
        /// });
        /// </example>
        public static TReturn with<T, TReturn>(T Object, Func<T, TReturn> then)
            => then(Object);

    }
}
