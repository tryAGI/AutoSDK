//HintName: G.Models.ChunkingStrategyRequestParam.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The chunking strategy used to chunk the file(s). If not set, will use the `auto` strategy.
    /// </summary>
    public readonly partial struct ChunkingStrategyRequestParam : global::System.IEquatable<ChunkingStrategyRequestParam>
    {
        /// <summary>
        /// The default strategy. This strategy currently uses a `max_chunk_size_tokens` of `800` and `chunk_overlap_tokens` of `400`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AutoChunkingStrategyRequestParam? AutoChunkingStrategy { get; init; }
#else
        public global::G.AutoChunkingStrategyRequestParam? AutoChunkingStrategy { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AutoChunkingStrategy))]
#endif
        public bool IsAutoChunkingStrategy => AutoChunkingStrategy != null;

        /// <summary>
        /// Customize your own chunking strategy by setting chunk size and chunk overlap.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.StaticChunkingStrategyRequestParam? StaticChunkingStrategy { get; init; }
#else
        public global::G.StaticChunkingStrategyRequestParam? StaticChunkingStrategy { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StaticChunkingStrategy))]
#endif
        public bool IsStaticChunkingStrategy => StaticChunkingStrategy != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChunkingStrategyRequestParam(global::G.AutoChunkingStrategyRequestParam value) => new ChunkingStrategyRequestParam((global::G.AutoChunkingStrategyRequestParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AutoChunkingStrategyRequestParam?(ChunkingStrategyRequestParam @this) => @this.AutoChunkingStrategy;

        /// <summary>
        /// 
        /// </summary>
        public ChunkingStrategyRequestParam(global::G.AutoChunkingStrategyRequestParam? value)
        {
            AutoChunkingStrategy = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChunkingStrategyRequestParam(global::G.StaticChunkingStrategyRequestParam value) => new ChunkingStrategyRequestParam((global::G.StaticChunkingStrategyRequestParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.StaticChunkingStrategyRequestParam?(ChunkingStrategyRequestParam @this) => @this.StaticChunkingStrategy;

        /// <summary>
        /// 
        /// </summary>
        public ChunkingStrategyRequestParam(global::G.StaticChunkingStrategyRequestParam? value)
        {
            StaticChunkingStrategy = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChunkingStrategyRequestParam(
            global::G.AutoChunkingStrategyRequestParam? autoChunkingStrategy,
            global::G.StaticChunkingStrategyRequestParam? staticChunkingStrategy
            )
        {
            AutoChunkingStrategy = autoChunkingStrategy;
            StaticChunkingStrategy = staticChunkingStrategy;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            StaticChunkingStrategy as object ??
            AutoChunkingStrategy as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AutoChunkingStrategy?.ToString() ??
            StaticChunkingStrategy?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAutoChunkingStrategy && !IsStaticChunkingStrategy || !IsAutoChunkingStrategy && IsStaticChunkingStrategy;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.AutoChunkingStrategyRequestParam?, TResult>? autoChunkingStrategy = null,
            global::System.Func<global::G.StaticChunkingStrategyRequestParam?, TResult>? staticChunkingStrategy = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAutoChunkingStrategy && autoChunkingStrategy != null)
            {
                return autoChunkingStrategy(AutoChunkingStrategy!);
            }
            else if (IsStaticChunkingStrategy && staticChunkingStrategy != null)
            {
                return staticChunkingStrategy(StaticChunkingStrategy!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.AutoChunkingStrategyRequestParam?>? autoChunkingStrategy = null,
            global::System.Action<global::G.StaticChunkingStrategyRequestParam?>? staticChunkingStrategy = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAutoChunkingStrategy)
            {
                autoChunkingStrategy?.Invoke(AutoChunkingStrategy!);
            }
            else if (IsStaticChunkingStrategy)
            {
                staticChunkingStrategy?.Invoke(StaticChunkingStrategy!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AutoChunkingStrategy,
                typeof(global::G.AutoChunkingStrategyRequestParam),
                StaticChunkingStrategy,
                typeof(global::G.StaticChunkingStrategyRequestParam),
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
        public bool Equals(ChunkingStrategyRequestParam other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.AutoChunkingStrategyRequestParam?>.Default.Equals(AutoChunkingStrategy, other.AutoChunkingStrategy) &&
                global::System.Collections.Generic.EqualityComparer<global::G.StaticChunkingStrategyRequestParam?>.Default.Equals(StaticChunkingStrategy, other.StaticChunkingStrategy) 
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
