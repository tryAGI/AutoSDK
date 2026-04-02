//HintName: G.Models.EmbeddingItem.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The encoded embedding data by encoding format.
    /// </summary>
    public readonly partial struct EmbeddingItem : global::System.IEquatable<EmbeddingItem>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<double>? EmbeddingItemVariant1 { get; init; }
#else
        public global::System.Collections.Generic.IList<double>? EmbeddingItemVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EmbeddingItemVariant1))]
#endif
        public bool IsEmbeddingItemVariant1 => EmbeddingItemVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<int>? EmbeddingItemVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<int>? EmbeddingItemVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EmbeddingItemVariant2))]
#endif
        public bool IsEmbeddingItemVariant2 => EmbeddingItemVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? EmbeddingItemVariant3 { get; init; }
#else
        public string? EmbeddingItemVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EmbeddingItemVariant3))]
#endif
        public bool IsEmbeddingItemVariant3 => EmbeddingItemVariant3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EmbeddingItem(string value) => new EmbeddingItem((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(EmbeddingItem @this) => @this.EmbeddingItemVariant3;

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingItem(string? value)
        {
            EmbeddingItemVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingItem(
            global::System.Collections.Generic.IList<double>? embeddingItemVariant1,
            global::System.Collections.Generic.IList<int>? embeddingItemVariant2,
            string? embeddingItemVariant3
            )
        {
            EmbeddingItemVariant1 = embeddingItemVariant1;
            EmbeddingItemVariant2 = embeddingItemVariant2;
            EmbeddingItemVariant3 = embeddingItemVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            EmbeddingItemVariant3 as object ??
            EmbeddingItemVariant2 as object ??
            EmbeddingItemVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            EmbeddingItemVariant1?.ToString() ??
            EmbeddingItemVariant2?.ToString() ??
            EmbeddingItemVariant3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsEmbeddingItemVariant1 || IsEmbeddingItemVariant2 || IsEmbeddingItemVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.Collections.Generic.IList<double>?, TResult>? embeddingItemVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<int>?, TResult>? embeddingItemVariant2 = null,
            global::System.Func<string?, TResult>? embeddingItemVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEmbeddingItemVariant1 && embeddingItemVariant1 != null)
            {
                return embeddingItemVariant1(EmbeddingItemVariant1!);
            }
            else if (IsEmbeddingItemVariant2 && embeddingItemVariant2 != null)
            {
                return embeddingItemVariant2(EmbeddingItemVariant2!);
            }
            else if (IsEmbeddingItemVariant3 && embeddingItemVariant3 != null)
            {
                return embeddingItemVariant3(EmbeddingItemVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::System.Collections.Generic.IList<double>?>? embeddingItemVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<int>?>? embeddingItemVariant2 = null,
            global::System.Action<string?>? embeddingItemVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEmbeddingItemVariant1)
            {
                embeddingItemVariant1?.Invoke(EmbeddingItemVariant1!);
            }
            else if (IsEmbeddingItemVariant2)
            {
                embeddingItemVariant2?.Invoke(EmbeddingItemVariant2!);
            }
            else if (IsEmbeddingItemVariant3)
            {
                embeddingItemVariant3?.Invoke(EmbeddingItemVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                EmbeddingItemVariant1,
                typeof(global::System.Collections.Generic.IList<double>),
                EmbeddingItemVariant2,
                typeof(global::System.Collections.Generic.IList<int>),
                EmbeddingItemVariant3,
                typeof(string),
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
        public bool Equals(EmbeddingItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<double>?>.Default.Equals(EmbeddingItemVariant1, other.EmbeddingItemVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<int>?>.Default.Equals(EmbeddingItemVariant2, other.EmbeddingItemVariant2) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(EmbeddingItemVariant3, other.EmbeddingItemVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(EmbeddingItem obj1, EmbeddingItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EmbeddingItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(EmbeddingItem obj1, EmbeddingItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EmbeddingItem o && Equals(o);
        }
    }
}
