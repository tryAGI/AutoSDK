//HintName: G.Models.DocumentOptions.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Option variants for text documents. Ether general-purpose options or BM25-specific options. BM25-specific will only take effect if the `qdrant/bm25` is specified as a model.
    /// </summary>
    public readonly partial struct DocumentOptions : global::System.IEquatable<DocumentOptions>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public object? DocumentOptionsVariant1 { get; init; }
#else
        public object? DocumentOptionsVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DocumentOptionsVariant1))]
#endif
        public bool IsDocumentOptionsVariant1 => DocumentOptionsVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDocumentOptionsVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = DocumentOptionsVariant1;
            return IsDocumentOptionsVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object PickDocumentOptionsVariant1() => IsDocumentOptionsVariant1
            ? DocumentOptionsVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DocumentOptionsVariant1' but the value was {ToString()}.");

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
        public bool TryPickBm25Config(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.Bm25Config? value)
        {
            value = Bm25Config;
            return IsBm25Config;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.Bm25Config PickBm25Config() => IsBm25Config
            ? Bm25Config!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Bm25Config' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DocumentOptions(global::G.Bm25Config value) => new DocumentOptions((global::G.Bm25Config?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.Bm25Config?(DocumentOptions @this) => @this.Bm25Config;

        /// <summary>
        /// 
        /// </summary>
        public DocumentOptions(global::G.Bm25Config? value)
        {
            Bm25Config = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static DocumentOptions FromBm25Config(global::G.Bm25Config? value) => new DocumentOptions(value);

        /// <summary>
        /// 
        /// </summary>
        public DocumentOptions(
            object? documentOptionsVariant1,
            global::G.Bm25Config? bm25Config
            )
        {
            DocumentOptionsVariant1 = documentOptionsVariant1;
            Bm25Config = bm25Config;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Bm25Config as object ??
            DocumentOptionsVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            DocumentOptionsVariant1?.ToString() ??
            Bm25Config?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsDocumentOptionsVariant1 || IsBm25Config;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<object, TResult>? documentOptionsVariant1 = null,
            global::System.Func<global::G.Bm25Config, TResult>? bm25Config = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDocumentOptionsVariant1 && documentOptionsVariant1 != null)
            {
                return documentOptionsVariant1(DocumentOptionsVariant1!);
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
            global::System.Action<object>? documentOptionsVariant1 = null,

            global::System.Action<global::G.Bm25Config>? bm25Config = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDocumentOptionsVariant1)
            {
                documentOptionsVariant1?.Invoke(DocumentOptionsVariant1!);
            }
            else if (IsBm25Config)
            {
                bm25Config?.Invoke(Bm25Config!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<object>? documentOptionsVariant1 = null,
            global::System.Action<global::G.Bm25Config>? bm25Config = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDocumentOptionsVariant1)
            {
                documentOptionsVariant1?.Invoke(DocumentOptionsVariant1!);
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
                DocumentOptionsVariant1,
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
        public bool Equals(DocumentOptions other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(DocumentOptionsVariant1, other.DocumentOptionsVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.Bm25Config?>.Default.Equals(Bm25Config, other.Bm25Config) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(DocumentOptions obj1, DocumentOptions obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DocumentOptions>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(DocumentOptions obj1, DocumentOptions obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DocumentOptions o && Equals(o);
        }
    }
}
