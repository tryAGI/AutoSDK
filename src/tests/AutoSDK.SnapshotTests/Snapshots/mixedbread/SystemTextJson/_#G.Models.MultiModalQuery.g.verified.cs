//HintName: G.Models.MultiModalQuery.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct MultiModalQuery : global::System.IEquatable<MultiModalQuery>
    {
        /// <summary>
        /// The text input document to create embeddings for.
        /// </summary>
#if NET6_0_OR_GREATER
        public string? MultiModalQueryVariant1 { get; init; }
#else
        public string? MultiModalQueryVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MultiModalQueryVariant1))]
#endif
        public bool IsMultiModalQueryVariant1 => MultiModalQueryVariant1 != null;

        /// <summary>
        /// The input to create embeddings for.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MultiModalQueryVariant2? MultiModalQueryVariant2 { get; init; }
#else
        public global::G.MultiModalQueryVariant2? MultiModalQueryVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MultiModalQueryVariant2))]
#endif
        public bool IsMultiModalQueryVariant2 => MultiModalQueryVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MultiModalQuery(string value) => new MultiModalQuery((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(MultiModalQuery @this) => @this.MultiModalQueryVariant1;

        /// <summary>
        /// 
        /// </summary>
        public MultiModalQuery(string? value)
        {
            MultiModalQueryVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MultiModalQuery(global::G.MultiModalQueryVariant2 value) => new MultiModalQuery((global::G.MultiModalQueryVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MultiModalQueryVariant2?(MultiModalQuery @this) => @this.MultiModalQueryVariant2;

        /// <summary>
        /// 
        /// </summary>
        public MultiModalQuery(global::G.MultiModalQueryVariant2? value)
        {
            MultiModalQueryVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public MultiModalQuery(
            string? multiModalQueryVariant1,
            global::G.MultiModalQueryVariant2? multiModalQueryVariant2
            )
        {
            MultiModalQueryVariant1 = multiModalQueryVariant1;
            MultiModalQueryVariant2 = multiModalQueryVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MultiModalQueryVariant2 as object ??
            MultiModalQueryVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            MultiModalQueryVariant1?.ToString() ??
            MultiModalQueryVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMultiModalQueryVariant1 || IsMultiModalQueryVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? multiModalQueryVariant1 = null,
            global::System.Func<global::G.MultiModalQueryVariant2?, TResult>? multiModalQueryVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMultiModalQueryVariant1 && multiModalQueryVariant1 != null)
            {
                return multiModalQueryVariant1(MultiModalQueryVariant1!);
            }
            else if (IsMultiModalQueryVariant2 && multiModalQueryVariant2 != null)
            {
                return multiModalQueryVariant2(MultiModalQueryVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? multiModalQueryVariant1 = null,
            global::System.Action<global::G.MultiModalQueryVariant2?>? multiModalQueryVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMultiModalQueryVariant1)
            {
                multiModalQueryVariant1?.Invoke(MultiModalQueryVariant1!);
            }
            else if (IsMultiModalQueryVariant2)
            {
                multiModalQueryVariant2?.Invoke(MultiModalQueryVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                MultiModalQueryVariant1,
                typeof(string),
                MultiModalQueryVariant2,
                typeof(global::G.MultiModalQueryVariant2),
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
        public bool Equals(MultiModalQuery other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(MultiModalQueryVariant1, other.MultiModalQueryVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MultiModalQueryVariant2?>.Default.Equals(MultiModalQueryVariant2, other.MultiModalQueryVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(MultiModalQuery obj1, MultiModalQuery obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MultiModalQuery>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(MultiModalQuery obj1, MultiModalQuery obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MultiModalQuery o && Equals(o);
        }
    }
}
