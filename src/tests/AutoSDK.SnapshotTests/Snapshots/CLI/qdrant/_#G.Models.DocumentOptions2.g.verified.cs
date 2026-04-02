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
        public object? OptionsVariant1 { get; init; }
#else
        public object? OptionsVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OptionsVariant1))]
#endif
        public bool IsOptionsVariant1 => OptionsVariant1 != null;

        /// <summary>
        /// Configuration of the local bm25 models.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.Bm25Config? Bm25Config { get; init; }
#else
        public global::G.Bm25Config? Bm25Config { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Bm25Config))]
#endif
        public bool IsBm25Config => Bm25Config != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DocumentOptions2(global::G.Bm25Config value) => new DocumentOptions2((global::G.Bm25Config?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.Bm25Config?(DocumentOptions2 @this) => @this.Bm25Config;

        /// <summary>
        /// 
        /// </summary>
        public DocumentOptions2(global::G.Bm25Config? value)
        {
            Bm25Config = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public DocumentOptions2(
            object? optionsVariant1,
            global::G.Bm25Config? bm25Config
            )
        {
            OptionsVariant1 = optionsVariant1;
            Bm25Config = bm25Config;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Bm25Config as object ??
            OptionsVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            OptionsVariant1?.ToString() ??
            Bm25Config?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsOptionsVariant1 || IsBm25Config;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<object?, TResult>? optionsVariant1 = null,
            global::System.Func<global::G.Bm25Config?, TResult>? bm25Config = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOptionsVariant1 && optionsVariant1 != null)
            {
                return optionsVariant1(OptionsVariant1!);
            }
            else if (IsBm25Config && bm25Config != null)
            {
                return bm25Config(Bm25Config!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<object?>? optionsVariant1 = null,
            global::System.Action<global::G.Bm25Config?>? bm25Config = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOptionsVariant1)
            {
                optionsVariant1?.Invoke(OptionsVariant1!);
            }
            else if (IsBm25Config)
            {
                bm25Config?.Invoke(Bm25Config!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                OptionsVariant1,
                typeof(object),
                Bm25Config,
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
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(OptionsVariant1, other.OptionsVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.Bm25Config?>.Default.Equals(Bm25Config, other.Bm25Config) 
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
