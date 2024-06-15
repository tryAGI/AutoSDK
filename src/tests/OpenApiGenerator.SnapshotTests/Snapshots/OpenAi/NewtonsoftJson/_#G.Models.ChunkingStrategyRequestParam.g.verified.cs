//HintName: G.Models.ChunkingStrategyRequestParam.g.cs
using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The chunking strategy used to chunk the file(s). If not set, will use the `auto` strategy.
    /// </summary>
    public readonly struct ChunkingStrategyRequestParam : global::System.IEquatable<ChunkingStrategyRequestParam>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AutoChunkingStrategyRequestParam? Value1 { get; init; }
#else
        public global::G.AutoChunkingStrategyRequestParam? Value1 { get; }
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
        public static implicit operator ChunkingStrategyRequestParam(global::G.AutoChunkingStrategyRequestParam value) => new ChunkingStrategyRequestParam(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AutoChunkingStrategyRequestParam?(ChunkingStrategyRequestParam @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public ChunkingStrategyRequestParam(global::G.AutoChunkingStrategyRequestParam? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.StaticChunkingStrategyRequestParam? Value2 { get; init; }
#else
        public global::G.StaticChunkingStrategyRequestParam? Value2 { get; }
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
        public static implicit operator ChunkingStrategyRequestParam(global::G.StaticChunkingStrategyRequestParam value) => new ChunkingStrategyRequestParam(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.StaticChunkingStrategyRequestParam?(ChunkingStrategyRequestParam @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public ChunkingStrategyRequestParam(global::G.StaticChunkingStrategyRequestParam? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChunkingStrategyRequestParam(
            global::G.AutoChunkingStrategyRequestParam? value1,
            global::G.StaticChunkingStrategyRequestParam? value2
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
        public bool Validate()
        {
            return !IsValue1 && IsValue2 || IsValue1 && !IsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::G.AutoChunkingStrategyRequestParam),
                Value2,
                typeof(global::G.StaticChunkingStrategyRequestParam),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;
            return fields.Aggregate(offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ChunkingStrategyRequestParam other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.AutoChunkingStrategyRequestParam?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.StaticChunkingStrategyRequestParam?>.Default.Equals(Value2, other.Value2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChunkingStrategyRequestParam obj1, ChunkingStrategyRequestParam obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChunkingStrategyRequestParam>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChunkingStrategyRequestParam obj1, ChunkingStrategyRequestParam obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChunkingStrategyRequestParam o && Equals(o);
        }
    }
}
