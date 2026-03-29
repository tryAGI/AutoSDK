//HintName: G.Models.NamedVectorStruct.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Vector data separator for named and unnamed modes Unnamed mode:<br/>
    /// { "vector": [1.0, 2.0, 3.0] }<br/>
    /// or named mode:<br/>
    /// { "vector": { "vector": [1.0, 2.0, 3.0], "name": "image-embeddings" } }
    /// </summary>
    public readonly partial struct NamedVectorStruct : global::System.IEquatable<NamedVectorStruct>
    {
        /// <summary>
        /// 
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
        /// Dense vector data with name
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.NamedVector? Value2 { get; init; }
#else
        public global::G.NamedVector? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;

        /// <summary>
        /// Sparse vector data with name
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.NamedSparseVector? Value3 { get; init; }
#else
        public global::G.NamedSparseVector? Value3 { get; }
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
        public static implicit operator NamedVectorStruct(global::G.NamedVector value) => new NamedVectorStruct((global::G.NamedVector?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.NamedVector?(NamedVectorStruct @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public NamedVectorStruct(global::G.NamedVector? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NamedVectorStruct(global::G.NamedSparseVector value) => new NamedVectorStruct((global::G.NamedSparseVector?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.NamedSparseVector?(NamedVectorStruct @this) => @this.Value3;

        /// <summary>
        /// 
        /// </summary>
        public NamedVectorStruct(global::G.NamedSparseVector? value)
        {
            Value3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public NamedVectorStruct(
            global::System.Collections.Generic.IList<float>? value1,
            global::G.NamedVector? value2,
            global::G.NamedSparseVector? value3
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
            global::System.Func<global::G.NamedVector?, TResult>? value2 = null,
            global::System.Func<global::G.NamedSparseVector?, TResult>? value3 = null,
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
            global::System.Action<global::G.NamedVector?>? value2 = null,
            global::System.Action<global::G.NamedSparseVector?>? value3 = null,
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
                typeof(global::G.NamedVector),
                Value3,
                typeof(global::G.NamedSparseVector),
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
        public bool Equals(NamedVectorStruct other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<float>?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.NamedVector?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.NamedSparseVector?>.Default.Equals(Value3, other.Value3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(NamedVectorStruct obj1, NamedVectorStruct obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<NamedVectorStruct>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(NamedVectorStruct obj1, NamedVectorStruct obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is NamedVectorStruct o && Equals(o);
        }
    }
}
