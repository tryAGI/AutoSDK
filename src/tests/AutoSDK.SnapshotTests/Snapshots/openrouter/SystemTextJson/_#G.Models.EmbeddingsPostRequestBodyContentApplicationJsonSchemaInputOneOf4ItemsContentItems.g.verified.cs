//HintName: G.Models.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems : global::System.IEquatable<EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0? EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0 { get; init; }
#else
        public global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0? EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0))]
#endif
        public bool IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0 => EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1? EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1 { get; init; }
#else
        public global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1? EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1))]
#endif
        public bool IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1 => EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems(global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0 value) => new EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems((global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0?(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems @this) => @this.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0;

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems(global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0? value)
        {
            EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems(global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1 value) => new EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems((global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1?(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems @this) => @this.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1;

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems(global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1? value)
        {
            EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems(
            global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0? embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0,
            global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1? embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1
            )
        {
            EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0 = embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0;
            EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1 = embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1 as object ??
            EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0?.ToString() ??
            EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0 && !IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1 || !IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0 && IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0?, TResult>? embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0 = null,
            global::System.Func<global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1?, TResult>? embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0 && embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0 != null)
            {
                return embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0!);
            }
            else if (IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1 && embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1 != null)
            {
                return embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0?>? embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0 = null,
            global::System.Action<global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1?>? embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0)
            {
                embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0?.Invoke(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0!);
            }
            else if (IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1)
            {
                embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1?.Invoke(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0,
                typeof(global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0),
                EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1,
                typeof(global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1),
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
        public bool Equals(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0?>.Default.Equals(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0, other.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0) &&
                global::System.Collections.Generic.EqualityComparer<global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1?>.Default.Equals(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1, other.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems obj1, EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems obj1, EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems o && Equals(o);
        }
    }
}
