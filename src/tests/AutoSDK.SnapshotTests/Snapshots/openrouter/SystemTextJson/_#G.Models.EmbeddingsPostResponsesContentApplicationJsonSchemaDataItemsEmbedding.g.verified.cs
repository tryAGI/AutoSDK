//HintName: G.Models.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbedding.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbedding : global::System.IEquatable<EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbedding>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<double>? EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbeddingVariant1 { get; init; }
#else
        public global::System.Collections.Generic.IList<double>? EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbeddingVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbeddingVariant1))]
#endif
        public bool IsEmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbeddingVariant1 => EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbeddingVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbeddingVariant2 { get; init; }
#else
        public string? EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbeddingVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbeddingVariant2))]
#endif
        public bool IsEmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbeddingVariant2 => EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbeddingVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbedding(string value) => new EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbedding((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbedding @this) => @this.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbeddingVariant2;

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbedding(string? value)
        {
            EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbeddingVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbedding(
            global::System.Collections.Generic.IList<double>? embeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbeddingVariant1,
            string? embeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbeddingVariant2
            )
        {
            EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbeddingVariant1 = embeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbeddingVariant1;
            EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbeddingVariant2 = embeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbeddingVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbeddingVariant2 as object ??
            EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbeddingVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbeddingVariant1?.ToString() ??
            EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbeddingVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsEmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbeddingVariant1 && !IsEmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbeddingVariant2 || !IsEmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbeddingVariant1 && IsEmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbeddingVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.Collections.Generic.IList<double>?, TResult>? embeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbeddingVariant1 = null,
            global::System.Func<string?, TResult>? embeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbeddingVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbeddingVariant1 && embeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbeddingVariant1 != null)
            {
                return embeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbeddingVariant1(EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbeddingVariant1!);
            }
            else if (IsEmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbeddingVariant2 && embeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbeddingVariant2 != null)
            {
                return embeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbeddingVariant2(EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbeddingVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::System.Collections.Generic.IList<double>?>? embeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbeddingVariant1 = null,
            global::System.Action<string?>? embeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbeddingVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbeddingVariant1)
            {
                embeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbeddingVariant1?.Invoke(EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbeddingVariant1!);
            }
            else if (IsEmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbeddingVariant2)
            {
                embeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbeddingVariant2?.Invoke(EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbeddingVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbeddingVariant1,
                typeof(global::System.Collections.Generic.IList<double>),
                EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbeddingVariant2,
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
        public bool Equals(EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbedding other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<double>?>.Default.Equals(EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbeddingVariant1, other.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbeddingVariant1) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbeddingVariant2, other.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbeddingVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbedding obj1, EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbedding obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbedding>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbedding obj1, EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbedding obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbedding o && Equals(o);
        }
    }
}
