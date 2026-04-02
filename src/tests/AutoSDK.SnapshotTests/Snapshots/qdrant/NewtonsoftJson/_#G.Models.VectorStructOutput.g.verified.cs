//HintName: G.Models.VectorStructOutput.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Vector data stored in Point
    /// </summary>
    public readonly partial struct VectorStructOutput : global::System.IEquatable<VectorStructOutput>
    {
        /// <summary>
        /// Example: [0.875F, 0.140625F, 0.8976F]
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<float>? VectorStructOutputVariant1 { get; init; }
#else
        public global::System.Collections.Generic.IList<float>? VectorStructOutputVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VectorStructOutputVariant1))]
#endif
        public bool IsVectorStructOutputVariant1 => VectorStructOutputVariant1 != null;

        /// <summary>
        /// Example: [[0.875F, 0.140625F, 0.1102F], [0.758F, 0.28126F, 0.96871F], [0.621F, 0.421878F, 0.9375F]]
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>? VectorStructOutputVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>? VectorStructOutputVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VectorStructOutputVariant2))]
#endif
        public bool IsVectorStructOutputVariant2 => VectorStructOutputVariant2 != null;

        /// <summary>
        /// Example: {"image-embeddings":[0.8730000257492065,0.140625,0.897599995136261]}
        /// </summary>
#if NET6_0_OR_GREATER
        public object? VectorStructOutputVariant3 { get; init; }
#else
        public object? VectorStructOutputVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VectorStructOutputVariant3))]
#endif
        public bool IsVectorStructOutputVariant3 => VectorStructOutputVariant3 != null;

        /// <summary>
        /// 
        /// </summary>
        public VectorStructOutput(
            global::System.Collections.Generic.IList<float>? vectorStructOutputVariant1,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>? vectorStructOutputVariant2,
            object? vectorStructOutputVariant3
            )
        {
            VectorStructOutputVariant1 = vectorStructOutputVariant1;
            VectorStructOutputVariant2 = vectorStructOutputVariant2;
            VectorStructOutputVariant3 = vectorStructOutputVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            VectorStructOutputVariant3 as object ??
            VectorStructOutputVariant2 as object ??
            VectorStructOutputVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            VectorStructOutputVariant1?.ToString() ??
            VectorStructOutputVariant2?.ToString() ??
            VectorStructOutputVariant3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsVectorStructOutputVariant1 || IsVectorStructOutputVariant2 || IsVectorStructOutputVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.Collections.Generic.IList<float>?, TResult>? vectorStructOutputVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>?, TResult>? vectorStructOutputVariant2 = null,
            global::System.Func<object?, TResult>? vectorStructOutputVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVectorStructOutputVariant1 && vectorStructOutputVariant1 != null)
            {
                return vectorStructOutputVariant1(VectorStructOutputVariant1!);
            }
            else if (IsVectorStructOutputVariant2 && vectorStructOutputVariant2 != null)
            {
                return vectorStructOutputVariant2(VectorStructOutputVariant2!);
            }
            else if (IsVectorStructOutputVariant3 && vectorStructOutputVariant3 != null)
            {
                return vectorStructOutputVariant3(VectorStructOutputVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::System.Collections.Generic.IList<float>?>? vectorStructOutputVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>?>? vectorStructOutputVariant2 = null,
            global::System.Action<object?>? vectorStructOutputVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVectorStructOutputVariant1)
            {
                vectorStructOutputVariant1?.Invoke(VectorStructOutputVariant1!);
            }
            else if (IsVectorStructOutputVariant2)
            {
                vectorStructOutputVariant2?.Invoke(VectorStructOutputVariant2!);
            }
            else if (IsVectorStructOutputVariant3)
            {
                vectorStructOutputVariant3?.Invoke(VectorStructOutputVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                VectorStructOutputVariant1,
                typeof(global::System.Collections.Generic.IList<float>),
                VectorStructOutputVariant2,
                typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>),
                VectorStructOutputVariant3,
                typeof(object),
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
        public bool Equals(VectorStructOutput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<float>?>.Default.Equals(VectorStructOutputVariant1, other.VectorStructOutputVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>?>.Default.Equals(VectorStructOutputVariant2, other.VectorStructOutputVariant2) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(VectorStructOutputVariant3, other.VectorStructOutputVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(VectorStructOutput obj1, VectorStructOutput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<VectorStructOutput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(VectorStructOutput obj1, VectorStructOutput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is VectorStructOutput o && Equals(o);
        }
    }
}
