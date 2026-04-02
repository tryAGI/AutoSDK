//HintName: G.Models.RecommendExample.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct RecommendExample : global::System.IEquatable<RecommendExample>
    {
        /// <summary>
        /// Type, used for specifying point ID in user interface
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ExtendedPointId? ExtendedPointId { get; init; }
#else
        public global::G.ExtendedPointId? ExtendedPointId { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ExtendedPointId))]
#endif
        public bool IsExtendedPointId => ExtendedPointId != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<float>? RecommendExampleVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<float>? RecommendExampleVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RecommendExampleVariant2))]
#endif
        public bool IsRecommendExampleVariant2 => RecommendExampleVariant2 != null;

        /// <summary>
        /// Sparse vector structure
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SparseVector? SparseVector { get; init; }
#else
        public global::G.SparseVector? SparseVector { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SparseVector))]
#endif
        public bool IsSparseVector => SparseVector != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RecommendExample(global::G.ExtendedPointId value) => new RecommendExample((global::G.ExtendedPointId?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ExtendedPointId?(RecommendExample @this) => @this.ExtendedPointId;

        /// <summary>
        /// 
        /// </summary>
        public RecommendExample(global::G.ExtendedPointId? value)
        {
            ExtendedPointId = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RecommendExample(global::G.SparseVector value) => new RecommendExample((global::G.SparseVector?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SparseVector?(RecommendExample @this) => @this.SparseVector;

        /// <summary>
        /// 
        /// </summary>
        public RecommendExample(global::G.SparseVector? value)
        {
            SparseVector = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RecommendExample(
            global::G.ExtendedPointId? extendedPointId,
            global::System.Collections.Generic.IList<float>? recommendExampleVariant2,
            global::G.SparseVector? sparseVector
            )
        {
            ExtendedPointId = extendedPointId;
            RecommendExampleVariant2 = recommendExampleVariant2;
            SparseVector = sparseVector;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SparseVector as object ??
            RecommendExampleVariant2 as object ??
            ExtendedPointId as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ExtendedPointId?.ToString() ??
            RecommendExampleVariant2?.ToString() ??
            SparseVector?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsExtendedPointId || IsRecommendExampleVariant2 || IsSparseVector;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ExtendedPointId?, TResult>? extendedPointId = null,
            global::System.Func<global::System.Collections.Generic.IList<float>?, TResult>? recommendExampleVariant2 = null,
            global::System.Func<global::G.SparseVector?, TResult>? sparseVector = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsExtendedPointId && extendedPointId != null)
            {
                return extendedPointId(ExtendedPointId!);
            }
            else if (IsRecommendExampleVariant2 && recommendExampleVariant2 != null)
            {
                return recommendExampleVariant2(RecommendExampleVariant2!);
            }
            else if (IsSparseVector && sparseVector != null)
            {
                return sparseVector(SparseVector!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ExtendedPointId?>? extendedPointId = null,
            global::System.Action<global::System.Collections.Generic.IList<float>?>? recommendExampleVariant2 = null,
            global::System.Action<global::G.SparseVector?>? sparseVector = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsExtendedPointId)
            {
                extendedPointId?.Invoke(ExtendedPointId!);
            }
            else if (IsRecommendExampleVariant2)
            {
                recommendExampleVariant2?.Invoke(RecommendExampleVariant2!);
            }
            else if (IsSparseVector)
            {
                sparseVector?.Invoke(SparseVector!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ExtendedPointId,
                typeof(global::G.ExtendedPointId),
                RecommendExampleVariant2,
                typeof(global::System.Collections.Generic.IList<float>),
                SparseVector,
                typeof(global::G.SparseVector),
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
        public bool Equals(RecommendExample other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ExtendedPointId?>.Default.Equals(ExtendedPointId, other.ExtendedPointId) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<float>?>.Default.Equals(RecommendExampleVariant2, other.RecommendExampleVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SparseVector?>.Default.Equals(SparseVector, other.SparseVector) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RecommendExample obj1, RecommendExample obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RecommendExample>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RecommendExample obj1, RecommendExample obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RecommendExample o && Equals(o);
        }
    }
}
