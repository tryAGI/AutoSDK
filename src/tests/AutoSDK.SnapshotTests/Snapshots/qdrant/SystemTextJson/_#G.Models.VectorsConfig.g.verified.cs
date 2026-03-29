//HintName: G.Models.VectorsConfig.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Vector params separator for single and multiple vector modes Single mode:<br/>
    /// { "size": 128, "distance": "Cosine" }<br/>
    /// or multiple mode:<br/>
    /// { "default": { "size": 128, "distance": "Cosine" } }
    /// </summary>
    public readonly partial struct VectorsConfig : global::System.IEquatable<VectorsConfig>
    {
        /// <summary>
        /// Params of single vector data storage
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.VectorParams? Value1 { get; init; }
#else
        public global::G.VectorParams? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.Dictionary<string, global::G.VectorParams>? Value2 { get; init; }
#else
        public global::System.Collections.Generic.Dictionary<string, global::G.VectorParams>? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VectorsConfig(global::G.VectorParams value) => new VectorsConfig((global::G.VectorParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.VectorParams?(VectorsConfig @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public VectorsConfig(global::G.VectorParams? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VectorsConfig(global::System.Collections.Generic.Dictionary<string, global::G.VectorParams> value) => new VectorsConfig((global::System.Collections.Generic.Dictionary<string, global::G.VectorParams>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::System.Collections.Generic.Dictionary<string, global::G.VectorParams>?(VectorsConfig @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public VectorsConfig(global::System.Collections.Generic.Dictionary<string, global::G.VectorParams>? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public VectorsConfig(
            global::G.VectorParams? value1,
            global::System.Collections.Generic.Dictionary<string, global::G.VectorParams>? value2
            )
        {
            Value1 = value1;
            Value2 = value2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            Value2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 || IsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.VectorParams?, TResult>? value1 = null,
            global::System.Func<global::System.Collections.Generic.Dictionary<string, global::G.VectorParams>?, TResult>? value2 = null,
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.VectorParams?>? value1 = null,
            global::System.Action<global::System.Collections.Generic.Dictionary<string, global::G.VectorParams>?>? value2 = null,
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
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::G.VectorParams),
                Value2,
                typeof(global::System.Collections.Generic.Dictionary<string, global::G.VectorParams>),
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
        public bool Equals(VectorsConfig other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.VectorParams?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.Dictionary<string, global::G.VectorParams>?>.Default.Equals(Value2, other.Value2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(VectorsConfig obj1, VectorsConfig obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<VectorsConfig>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(VectorsConfig obj1, VectorsConfig obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is VectorsConfig o && Equals(o);
        }
    }
}
