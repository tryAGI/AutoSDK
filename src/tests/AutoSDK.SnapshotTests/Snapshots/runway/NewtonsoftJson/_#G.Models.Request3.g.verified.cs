//HintName: G.Models.Request3.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Request3 : global::System.IEquatable<Request3>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RequestGen4Aleph? Gen4Aleph { get; init; }
#else
        public global::G.RequestGen4Aleph? Gen4Aleph { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Gen4Aleph))]
#endif
        public bool IsGen4Aleph => Gen4Aleph != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Request3(global::G.RequestGen4Aleph value) => new Request3((global::G.RequestGen4Aleph?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RequestGen4Aleph?(Request3 @this) => @this.Gen4Aleph;

        /// <summary>
        /// 
        /// </summary>
        public Request3(global::G.RequestGen4Aleph? value)
        {
            Gen4Aleph = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Gen4Aleph as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Gen4Aleph?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsGen4Aleph;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.RequestGen4Aleph?, TResult>? gen4Aleph = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGen4Aleph && gen4Aleph != null)
            {
                return gen4Aleph(Gen4Aleph!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.RequestGen4Aleph?>? gen4Aleph = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGen4Aleph)
            {
                gen4Aleph?.Invoke(Gen4Aleph!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Gen4Aleph,
                typeof(global::G.RequestGen4Aleph),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(Request3 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.RequestGen4Aleph?>.Default.Equals(Gen4Aleph, other.Gen4Aleph) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Request3 obj1, Request3 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Request3>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Request3 obj1, Request3 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Request3 o && Equals(o);
        }
    }
}
