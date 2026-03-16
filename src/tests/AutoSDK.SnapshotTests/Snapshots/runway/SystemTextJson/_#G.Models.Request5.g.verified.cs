//HintName: G.Models.Request5.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Request5 : global::System.IEquatable<Request5>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RequestActTwo? ActTwo { get; init; }
#else
        public global::G.RequestActTwo? ActTwo { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ActTwo))]
#endif
        public bool IsActTwo => ActTwo != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Request5(global::G.RequestActTwo value) => new Request5((global::G.RequestActTwo?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RequestActTwo?(Request5 @this) => @this.ActTwo;

        /// <summary>
        /// 
        /// </summary>
        public Request5(global::G.RequestActTwo? value)
        {
            ActTwo = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ActTwo as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ActTwo?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsActTwo;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.RequestActTwo?, TResult>? actTwo = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsActTwo && actTwo != null)
            {
                return actTwo(ActTwo!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.RequestActTwo?>? actTwo = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsActTwo)
            {
                actTwo?.Invoke(ActTwo!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ActTwo,
                typeof(global::G.RequestActTwo),
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
        public bool Equals(Request5 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.RequestActTwo?>.Default.Equals(ActTwo, other.ActTwo) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Request5 obj1, Request5 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Request5>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Request5 obj1, Request5 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Request5 o && Equals(o);
        }
    }
}
