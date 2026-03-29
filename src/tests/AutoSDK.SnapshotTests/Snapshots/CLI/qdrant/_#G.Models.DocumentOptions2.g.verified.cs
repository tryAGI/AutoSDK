//HintName: G.Models.DocumentOptions2.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Option variants for text documents. Ether general-purpose options or BM25-specific options. BM25-specific will only take effect if the `qdrant/bm25` is specified as a model.
    /// </summary>
    public readonly partial struct DocumentOptions2 : global::System.IEquatable<DocumentOptions2>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public object? Value1 { get; init; }
#else
        public object? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// Configuration of the local bm25 models.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.Bm25Config? Value2 { get; init; }
#else
        public global::G.Bm25Config? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DocumentOptions2(global::G.Bm25Config value) => new DocumentOptions2((global::G.Bm25Config?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.Bm25Config?(DocumentOptions2 @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public DocumentOptions2(global::G.Bm25Config? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public DocumentOptions2(
            object? value1,
            global::G.Bm25Config? value2
            )
        {
            Value1 = value1;
            Value2 = value2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            Value2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 || IsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<object?, TResult>? value1 = null,
            global::System.Func<global::G.Bm25Config?, TResult>? value2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1 && value1 != null)
            {
                return value1(Value1!);
            }
            else if (IsValue2 && value2 != null)
            {
                return value2(Value2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<object?>? value1 = null,
            global::System.Action<global::G.Bm25Config?>? value2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1)
            {
                value1?.Invoke(Value1!);
            }
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(object),
                Value2,
                typeof(global::G.Bm25Config),
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
        public bool Equals(DocumentOptions2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.Bm25Config?>.Default.Equals(Value2, other.Value2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(DocumentOptions2 obj1, DocumentOptions2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DocumentOptions2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(DocumentOptions2 obj1, DocumentOptions2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DocumentOptions2 o && Equals(o);
        }
    }
}
