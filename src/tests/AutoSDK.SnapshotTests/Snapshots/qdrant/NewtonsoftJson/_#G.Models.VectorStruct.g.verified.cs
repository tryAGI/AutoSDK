//HintName: G.Models.VectorStruct.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Full vector data per point separator with single and multiple vector modes
    /// </summary>
    public readonly partial struct VectorStruct : global::System.IEquatable<VectorStruct>
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
        /// WARN: Work-in-progress, unimplemented<br/>
        /// Text document for embedding. Requires inference infrastructure, unimplemented.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.Document? Value4 { get; init; }
#else
        public global::G.Document? Value4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value4))]
#endif
        public bool IsValue4 => Value4 != null;

        /// <summary>
        /// WARN: Work-in-progress, unimplemented<br/>
        /// Image object for embedding. Requires inference infrastructure, unimplemented.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.Image? Value5 { get; init; }
#else
        public global::G.Image? Value5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value5))]
#endif
        public bool IsValue5 => Value5 != null;

        /// <summary>
        /// WARN: Work-in-progress, unimplemented<br/>
        /// Custom object for embedding. Requires inference infrastructure, unimplemented.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.InferenceObject? Value6 { get; init; }
#else
        public global::G.InferenceObject? Value6 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value6))]
#endif
        public bool IsValue6 => Value6 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VectorStruct(global::G.Document value) => new VectorStruct((global::G.Document?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.Document?(VectorStruct @this) => @this.Value4;

        /// <summary>
        /// 
        /// </summary>
        public VectorStruct(global::G.Document? value)
        {
            Value4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VectorStruct(global::G.Image value) => new VectorStruct((global::G.Image?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.Image?(VectorStruct @this) => @this.Value5;

        /// <summary>
        /// 
        /// </summary>
        public VectorStruct(global::G.Image? value)
        {
            Value5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VectorStruct(global::G.InferenceObject value) => new VectorStruct((global::G.InferenceObject?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InferenceObject?(VectorStruct @this) => @this.Value6;

        /// <summary>
        /// 
        /// </summary>
        public VectorStruct(global::G.InferenceObject? value)
        {
            Value6 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public VectorStruct(
            global::System.Collections.Generic.IList<float>? value1,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>? value2,
            object? value3,
            global::G.Document? value4,
            global::G.Image? value5,
            global::G.InferenceObject? value6
            )
        {
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
            Value4 = value4;
            Value5 = value5;
            Value6 = value6;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value6 as object ??
            Value5 as object ??
            Value4 as object ??
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
            Value3?.ToString() ??
            Value4?.ToString() ??
            Value5?.ToString() ??
            Value6?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 || IsValue2 || IsValue3 || IsValue4 || IsValue5 || IsValue6;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.Collections.Generic.IList<float>?, TResult>? value1 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>?, TResult>? value2 = null,
            global::System.Func<object?, TResult>? value3 = null,
            global::System.Func<global::G.Document?, TResult>? value4 = null,
            global::System.Func<global::G.Image?, TResult>? value5 = null,
            global::System.Func<global::G.InferenceObject?, TResult>? value6 = null,
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
            else if (IsValue4 && value4 != null)
            {
                return value4(Value4!);
            }
            else if (IsValue5 && value5 != null)
            {
                return value5(Value5!);
            }
            else if (IsValue6 && value6 != null)
            {
                return value6(Value6!);
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
            global::System.Action<global::G.Document?>? value4 = null,
            global::System.Action<global::G.Image?>? value5 = null,
            global::System.Action<global::G.InferenceObject?>? value6 = null,
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
            else if (IsValue4)
            {
                value4?.Invoke(Value4!);
            }
            else if (IsValue5)
            {
                value5?.Invoke(Value5!);
            }
            else if (IsValue6)
            {
                value6?.Invoke(Value6!);
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
                Value4,
                typeof(global::G.Document),
                Value5,
                typeof(global::G.Image),
                Value6,
                typeof(global::G.InferenceObject),
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
        public bool Equals(VectorStruct other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<float>?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(Value3, other.Value3) &&
                global::System.Collections.Generic.EqualityComparer<global::G.Document?>.Default.Equals(Value4, other.Value4) &&
                global::System.Collections.Generic.EqualityComparer<global::G.Image?>.Default.Equals(Value5, other.Value5) &&
                global::System.Collections.Generic.EqualityComparer<global::G.InferenceObject?>.Default.Equals(Value6, other.Value6) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(VectorStruct obj1, VectorStruct obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<VectorStruct>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(VectorStruct obj1, VectorStruct obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is VectorStruct o && Equals(o);
        }
    }
}
