//HintName: G.Models.EmbeddingsPayload.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct EmbeddingsPayload : global::System.IEquatable<EmbeddingsPayload>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>? EmbeddingsPayloadVariant1 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>? EmbeddingsPayloadVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EmbeddingsPayloadVariant1))]
#endif
        public bool IsEmbeddingsPayloadVariant1 => EmbeddingsPayloadVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<string>? EmbeddingsPayloadVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<string>? EmbeddingsPayloadVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EmbeddingsPayloadVariant2))]
#endif
        public bool IsEmbeddingsPayloadVariant2 => EmbeddingsPayloadVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingsPayload(
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>? embeddingsPayloadVariant1,
            global::System.Collections.Generic.IList<string>? embeddingsPayloadVariant2
            )
        {
            EmbeddingsPayloadVariant1 = embeddingsPayloadVariant1;
            EmbeddingsPayloadVariant2 = embeddingsPayloadVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            EmbeddingsPayloadVariant2 as object ??
            EmbeddingsPayloadVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            EmbeddingsPayloadVariant1?.ToString() ??
            EmbeddingsPayloadVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsEmbeddingsPayloadVariant1 && !IsEmbeddingsPayloadVariant2 || !IsEmbeddingsPayloadVariant1 && IsEmbeddingsPayloadVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>?, TResult>? embeddingsPayloadVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<string>?, TResult>? embeddingsPayloadVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEmbeddingsPayloadVariant1 && embeddingsPayloadVariant1 != null)
            {
                return embeddingsPayloadVariant1(EmbeddingsPayloadVariant1!);
            }
            else if (IsEmbeddingsPayloadVariant2 && embeddingsPayloadVariant2 != null)
            {
                return embeddingsPayloadVariant2(EmbeddingsPayloadVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>?>? embeddingsPayloadVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<string>?>? embeddingsPayloadVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEmbeddingsPayloadVariant1)
            {
                embeddingsPayloadVariant1?.Invoke(EmbeddingsPayloadVariant1!);
            }
            else if (IsEmbeddingsPayloadVariant2)
            {
                embeddingsPayloadVariant2?.Invoke(EmbeddingsPayloadVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                EmbeddingsPayloadVariant1,
                typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>),
                EmbeddingsPayloadVariant2,
                typeof(global::System.Collections.Generic.IList<string>),
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
        public bool Equals(EmbeddingsPayload other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>?>.Default.Equals(EmbeddingsPayloadVariant1, other.EmbeddingsPayloadVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<string>?>.Default.Equals(EmbeddingsPayloadVariant2, other.EmbeddingsPayloadVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(EmbeddingsPayload obj1, EmbeddingsPayload obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EmbeddingsPayload>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(EmbeddingsPayload obj1, EmbeddingsPayload obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EmbeddingsPayload o && Equals(o);
        }
    }
}
