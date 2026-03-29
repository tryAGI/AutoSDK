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
        public global::System.Collections.Generic.IList<float>? Value1 { get; init; }
#else
        public global::System.Collections.Generic.IList<float>? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// Example: [[0.875F, 0.140625F, 0.1102F], [0.758F, 0.28126F, 0.96871F], [0.621F, 0.421878F, 0.9375F]]
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>? Value2 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;

        /// <summary>
        /// Example: {"image-embeddings":[0.8730000257492065,0.140625,0.897599995136261]}
        /// </summary>
#if NET6_0_OR_GREATER
        public object? Value3 { get; init; }
#else
        public object? Value3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value3))]
#endif
        public bool IsValue3 => Value3 != null;

        /// <summary>
        /// 
        /// </summary>
        public VectorStructOutput(
            global::System.Collections.Generic.IList<float>? value1,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>? value2,
            object? value3
            )
        {
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value3 as object ??
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            Value2?.ToString() ??
            Value3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 || IsValue2 || IsValue3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.Collections.Generic.IList<float>?, TResult>? value1 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>?, TResult>? value2 = null,
            global::System.Func<object?, TResult>? value3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1 && value1 != null)
            {
                return value1(Value1!);
            }
            else if (IsValue2 && value2 != null)
            {
                return value2(Value2!);
            }
            else if (IsValue3 && value3 != null)
            {
                return value3(Value3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::System.Collections.Generic.IList<float>?>? value1 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>?>? value2 = null,
            global::System.Action<object?>? value3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1)
            {
                value1?.Invoke(Value1!);
            }
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
            }
            else if (IsValue3)
            {
                value3?.Invoke(Value3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::System.Collections.Generic.IList<float>),
                Value2,
                typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>),
                Value3,
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
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<float>?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(Value3, other.Value3) 
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
