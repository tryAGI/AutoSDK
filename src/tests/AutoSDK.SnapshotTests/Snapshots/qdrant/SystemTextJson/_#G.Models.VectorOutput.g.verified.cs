//HintName: G.Models.VectorOutput.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Vector Data stored in Point
    /// </summary>
    public readonly partial struct VectorOutput : global::System.IEquatable<VectorOutput>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<float>? VectorOutputVariant1 { get; init; }
#else
        public global::System.Collections.Generic.IList<float>? VectorOutputVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VectorOutputVariant1))]
#endif
        public bool IsVectorOutputVariant1 => VectorOutputVariant1 != null;

        /// <summary>
        /// Sparse vector structure
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SparseVector? Sparse { get; init; }
#else
        public global::G.SparseVector? Sparse { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Sparse))]
#endif
        public bool IsSparse => Sparse != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>? VectorOutputVariant3 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>? VectorOutputVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VectorOutputVariant3))]
#endif
        public bool IsVectorOutputVariant3 => VectorOutputVariant3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VectorOutput(global::G.SparseVector value) => new VectorOutput((global::G.SparseVector?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SparseVector?(VectorOutput @this) => @this.Sparse;

        /// <summary>
        /// 
        /// </summary>
        public VectorOutput(global::G.SparseVector? value)
        {
            Sparse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public VectorOutput(
            global::System.Collections.Generic.IList<float>? vectorOutputVariant1,
            global::G.SparseVector? sparse,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>? vectorOutputVariant3
            )
        {
            VectorOutputVariant1 = vectorOutputVariant1;
            Sparse = sparse;
            VectorOutputVariant3 = vectorOutputVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            VectorOutputVariant3 as object ??
            Sparse as object ??
            VectorOutputVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            VectorOutputVariant1?.ToString() ??
            Sparse?.ToString() ??
            VectorOutputVariant3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsVectorOutputVariant1 || IsSparse || IsVectorOutputVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.Collections.Generic.IList<float>?, TResult>? vectorOutputVariant1 = null,
            global::System.Func<global::G.SparseVector?, TResult>? sparse = null,
            global::System.Func<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>?, TResult>? vectorOutputVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVectorOutputVariant1 && vectorOutputVariant1 != null)
            {
                return vectorOutputVariant1(VectorOutputVariant1!);
            }
            else if (IsSparse && sparse != null)
            {
                return sparse(Sparse!);
            }
            else if (IsVectorOutputVariant3 && vectorOutputVariant3 != null)
            {
                return vectorOutputVariant3(VectorOutputVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::System.Collections.Generic.IList<float>?>? vectorOutputVariant1 = null,
            global::System.Action<global::G.SparseVector?>? sparse = null,
            global::System.Action<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>?>? vectorOutputVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVectorOutputVariant1)
            {
                vectorOutputVariant1?.Invoke(VectorOutputVariant1!);
            }
            else if (IsSparse)
            {
                sparse?.Invoke(Sparse!);
            }
            else if (IsVectorOutputVariant3)
            {
                vectorOutputVariant3?.Invoke(VectorOutputVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                VectorOutputVariant1,
                typeof(global::System.Collections.Generic.IList<float>),
                Sparse,
                typeof(global::G.SparseVector),
                VectorOutputVariant3,
                typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>),
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
        public bool Equals(VectorOutput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<float>?>.Default.Equals(VectorOutputVariant1, other.VectorOutputVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SparseVector?>.Default.Equals(Sparse, other.Sparse) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>?>.Default.Equals(VectorOutputVariant3, other.VectorOutputVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(VectorOutput obj1, VectorOutput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<VectorOutput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(VectorOutput obj1, VectorOutput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is VectorOutput o && Equals(o);
        }
    }
}
