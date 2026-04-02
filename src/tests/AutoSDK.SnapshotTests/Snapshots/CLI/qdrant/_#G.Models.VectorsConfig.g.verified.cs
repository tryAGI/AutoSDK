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
        public global::G.VectorParams? VectorParams { get; init; }
#else
        public global::G.VectorParams? VectorParams { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VectorParams))]
#endif
        public bool IsVectorParams => VectorParams != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.Dictionary<string, global::G.VectorParams>? VectorsConfigVariant2 { get; init; }
#else
        public global::System.Collections.Generic.Dictionary<string, global::G.VectorParams>? VectorsConfigVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VectorsConfigVariant2))]
#endif
        public bool IsVectorsConfigVariant2 => VectorsConfigVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VectorsConfig(global::G.VectorParams value) => new VectorsConfig((global::G.VectorParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.VectorParams?(VectorsConfig @this) => @this.VectorParams;

        /// <summary>
        /// 
        /// </summary>
        public VectorsConfig(global::G.VectorParams? value)
        {
            VectorParams = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VectorsConfig(global::System.Collections.Generic.Dictionary<string, global::G.VectorParams> value) => new VectorsConfig((global::System.Collections.Generic.Dictionary<string, global::G.VectorParams>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::System.Collections.Generic.Dictionary<string, global::G.VectorParams>?(VectorsConfig @this) => @this.VectorsConfigVariant2;

        /// <summary>
        /// 
        /// </summary>
        public VectorsConfig(global::System.Collections.Generic.Dictionary<string, global::G.VectorParams>? value)
        {
            VectorsConfigVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public VectorsConfig(
            global::G.VectorParams? vectorParams,
            global::System.Collections.Generic.Dictionary<string, global::G.VectorParams>? vectorsConfigVariant2
            )
        {
            VectorParams = vectorParams;
            VectorsConfigVariant2 = vectorsConfigVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            VectorsConfigVariant2 as object ??
            VectorParams as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            VectorParams?.ToString() ??
            VectorsConfigVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsVectorParams || IsVectorsConfigVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.VectorParams?, TResult>? vectorParams = null,
            global::System.Func<global::System.Collections.Generic.Dictionary<string, global::G.VectorParams>?, TResult>? vectorsConfigVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVectorParams && vectorParams != null)
            {
                return vectorParams(VectorParams!);
            }
            else if (IsVectorsConfigVariant2 && vectorsConfigVariant2 != null)
            {
                return vectorsConfigVariant2(VectorsConfigVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.VectorParams?>? vectorParams = null,
            global::System.Action<global::System.Collections.Generic.Dictionary<string, global::G.VectorParams>?>? vectorsConfigVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVectorParams)
            {
                vectorParams?.Invoke(VectorParams!);
            }
            else if (IsVectorsConfigVariant2)
            {
                vectorsConfigVariant2?.Invoke(VectorsConfigVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                VectorParams,
                typeof(global::G.VectorParams),
                VectorsConfigVariant2,
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
                global::System.Collections.Generic.EqualityComparer<global::G.VectorParams?>.Default.Equals(VectorParams, other.VectorParams) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.Dictionary<string, global::G.VectorParams>?>.Default.Equals(VectorsConfigVariant2, other.VectorsConfigVariant2) 
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
