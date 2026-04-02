//HintName: G.Models.BatchReferenceResponse.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BatchReferenceResponse : global::System.IEquatable<BatchReferenceResponse>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BatchReference? BatchReference { get; init; }
#else
        public global::G.BatchReference? BatchReference { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BatchReference))]
#endif
        public bool IsBatchReference => BatchReference != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BatchReferenceResponseVariant2? BatchReferenceResponseVariant2 { get; init; }
#else
        public global::G.BatchReferenceResponseVariant2? BatchReferenceResponseVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BatchReferenceResponseVariant2))]
#endif
        public bool IsBatchReferenceResponseVariant2 => BatchReferenceResponseVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BatchReferenceResponse(global::G.BatchReference value) => new BatchReferenceResponse((global::G.BatchReference?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BatchReference?(BatchReferenceResponse @this) => @this.BatchReference;

        /// <summary>
        /// 
        /// </summary>
        public BatchReferenceResponse(global::G.BatchReference? value)
        {
            BatchReference = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BatchReferenceResponse(global::G.BatchReferenceResponseVariant2 value) => new BatchReferenceResponse((global::G.BatchReferenceResponseVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BatchReferenceResponseVariant2?(BatchReferenceResponse @this) => @this.BatchReferenceResponseVariant2;

        /// <summary>
        /// 
        /// </summary>
        public BatchReferenceResponse(global::G.BatchReferenceResponseVariant2? value)
        {
            BatchReferenceResponseVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BatchReferenceResponse(
            global::G.BatchReference? batchReference,
            global::G.BatchReferenceResponseVariant2? batchReferenceResponseVariant2
            )
        {
            BatchReference = batchReference;
            BatchReferenceResponseVariant2 = batchReferenceResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            BatchReferenceResponseVariant2 as object ??
            BatchReference as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            BatchReference?.ToString() ??
            BatchReferenceResponseVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBatchReference && IsBatchReferenceResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.BatchReference?, TResult>? batchReference = null,
            global::System.Func<global::G.BatchReferenceResponseVariant2?, TResult>? batchReferenceResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBatchReference && batchReference != null)
            {
                return batchReference(BatchReference!);
            }
            else if (IsBatchReferenceResponseVariant2 && batchReferenceResponseVariant2 != null)
            {
                return batchReferenceResponseVariant2(BatchReferenceResponseVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.BatchReference?>? batchReference = null,
            global::System.Action<global::G.BatchReferenceResponseVariant2?>? batchReferenceResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBatchReference)
            {
                batchReference?.Invoke(BatchReference!);
            }
            else if (IsBatchReferenceResponseVariant2)
            {
                batchReferenceResponseVariant2?.Invoke(BatchReferenceResponseVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                BatchReference,
                typeof(global::G.BatchReference),
                BatchReferenceResponseVariant2,
                typeof(global::G.BatchReferenceResponseVariant2),
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
        public bool Equals(BatchReferenceResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.BatchReference?>.Default.Equals(BatchReference, other.BatchReference) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BatchReferenceResponseVariant2?>.Default.Equals(BatchReferenceResponseVariant2, other.BatchReferenceResponseVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BatchReferenceResponse obj1, BatchReferenceResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BatchReferenceResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BatchReferenceResponse obj1, BatchReferenceResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BatchReferenceResponse o && Equals(o);
        }
    }
}
