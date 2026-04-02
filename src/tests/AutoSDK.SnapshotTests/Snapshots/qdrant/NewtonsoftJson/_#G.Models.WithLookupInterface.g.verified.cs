//HintName: G.Models.WithLookupInterface.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct WithLookupInterface : global::System.IEquatable<WithLookupInterface>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? WithLookupInterfaceVariant1 { get; init; }
#else
        public string? WithLookupInterfaceVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WithLookupInterfaceVariant1))]
#endif
        public bool IsWithLookupInterfaceVariant1 => WithLookupInterfaceVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.WithLookup? WithLookup { get; init; }
#else
        public global::G.WithLookup? WithLookup { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WithLookup))]
#endif
        public bool IsWithLookup => WithLookup != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WithLookupInterface(string value) => new WithLookupInterface((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(WithLookupInterface @this) => @this.WithLookupInterfaceVariant1;

        /// <summary>
        /// 
        /// </summary>
        public WithLookupInterface(string? value)
        {
            WithLookupInterfaceVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WithLookupInterface(global::G.WithLookup value) => new WithLookupInterface((global::G.WithLookup?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.WithLookup?(WithLookupInterface @this) => @this.WithLookup;

        /// <summary>
        /// 
        /// </summary>
        public WithLookupInterface(global::G.WithLookup? value)
        {
            WithLookup = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public WithLookupInterface(
            string? withLookupInterfaceVariant1,
            global::G.WithLookup? withLookup
            )
        {
            WithLookupInterfaceVariant1 = withLookupInterfaceVariant1;
            WithLookup = withLookup;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            WithLookup as object ??
            WithLookupInterfaceVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            WithLookupInterfaceVariant1?.ToString() ??
            WithLookup?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsWithLookupInterfaceVariant1 || IsWithLookup;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? withLookupInterfaceVariant1 = null,
            global::System.Func<global::G.WithLookup?, TResult>? withLookup = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWithLookupInterfaceVariant1 && withLookupInterfaceVariant1 != null)
            {
                return withLookupInterfaceVariant1(WithLookupInterfaceVariant1!);
            }
            else if (IsWithLookup && withLookup != null)
            {
                return withLookup(WithLookup!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? withLookupInterfaceVariant1 = null,
            global::System.Action<global::G.WithLookup?>? withLookup = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWithLookupInterfaceVariant1)
            {
                withLookupInterfaceVariant1?.Invoke(WithLookupInterfaceVariant1!);
            }
            else if (IsWithLookup)
            {
                withLookup?.Invoke(WithLookup!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                WithLookupInterfaceVariant1,
                typeof(string),
                WithLookup,
                typeof(global::G.WithLookup),
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
        public bool Equals(WithLookupInterface other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(WithLookupInterfaceVariant1, other.WithLookupInterfaceVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.WithLookup?>.Default.Equals(WithLookup, other.WithLookup) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(WithLookupInterface obj1, WithLookupInterface obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<WithLookupInterface>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(WithLookupInterface obj1, WithLookupInterface obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WithLookupInterface o && Equals(o);
        }
    }
}
