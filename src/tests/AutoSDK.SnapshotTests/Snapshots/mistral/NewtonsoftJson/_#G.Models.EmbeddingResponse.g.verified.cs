//HintName: G.Models.EmbeddingResponse.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct EmbeddingResponse : global::System.IEquatable<EmbeddingResponse>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseBase? ResponseBase { get; init; }
#else
        public global::G.ResponseBase? ResponseBase { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseBase))]
#endif
        public bool IsResponseBase => ResponseBase != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.EmbeddingResponseVariant2? EmbeddingResponseVariant2 { get; init; }
#else
        public global::G.EmbeddingResponseVariant2? EmbeddingResponseVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EmbeddingResponseVariant2))]
#endif
        public bool IsEmbeddingResponseVariant2 => EmbeddingResponseVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EmbeddingResponse(global::G.ResponseBase value) => new EmbeddingResponse((global::G.ResponseBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseBase?(EmbeddingResponse @this) => @this.ResponseBase;

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingResponse(global::G.ResponseBase? value)
        {
            ResponseBase = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EmbeddingResponse(global::G.EmbeddingResponseVariant2 value) => new EmbeddingResponse((global::G.EmbeddingResponseVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.EmbeddingResponseVariant2?(EmbeddingResponse @this) => @this.EmbeddingResponseVariant2;

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingResponse(global::G.EmbeddingResponseVariant2? value)
        {
            EmbeddingResponseVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingResponse(
            global::G.ResponseBase? responseBase,
            global::G.EmbeddingResponseVariant2? embeddingResponseVariant2
            )
        {
            ResponseBase = responseBase;
            EmbeddingResponseVariant2 = embeddingResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            EmbeddingResponseVariant2 as object ??
            ResponseBase as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ResponseBase?.ToString() ??
            EmbeddingResponseVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsResponseBase && IsEmbeddingResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ResponseBase?, TResult>? responseBase = null,
            global::System.Func<global::G.EmbeddingResponseVariant2?, TResult>? embeddingResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResponseBase && responseBase != null)
            {
                return responseBase(ResponseBase!);
            }
            else if (IsEmbeddingResponseVariant2 && embeddingResponseVariant2 != null)
            {
                return embeddingResponseVariant2(EmbeddingResponseVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ResponseBase?>? responseBase = null,
            global::System.Action<global::G.EmbeddingResponseVariant2?>? embeddingResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResponseBase)
            {
                responseBase?.Invoke(ResponseBase!);
            }
            else if (IsEmbeddingResponseVariant2)
            {
                embeddingResponseVariant2?.Invoke(EmbeddingResponseVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ResponseBase,
                typeof(global::G.ResponseBase),
                EmbeddingResponseVariant2,
                typeof(global::G.EmbeddingResponseVariant2),
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
        public bool Equals(EmbeddingResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseBase?>.Default.Equals(ResponseBase, other.ResponseBase) &&
                global::System.Collections.Generic.EqualityComparer<global::G.EmbeddingResponseVariant2?>.Default.Equals(EmbeddingResponseVariant2, other.EmbeddingResponseVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(EmbeddingResponse obj1, EmbeddingResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EmbeddingResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(EmbeddingResponse obj1, EmbeddingResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EmbeddingResponse o && Equals(o);
        }
    }
}
