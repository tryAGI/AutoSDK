//HintName: G.Models.TranscriptionChunkingStrategy.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Controls how the audio is cut into chunks. When set to `"auto"`, the<br/>
    /// server first normalizes loudness and then uses voice activity detection (VAD) to<br/>
    /// choose boundaries. `server_vad` object can be provided to tweak VAD detection<br/>
    /// parameters manually. If unset, the audio is transcribed as a single block. 
    /// </summary>
    public readonly partial struct TranscriptionChunkingStrategy : global::System.IEquatable<TranscriptionChunkingStrategy>
    {
        /// <summary>
        /// Automatically set chunking parameters based on the audio. Must be set to `"auto"`.<br/>
        /// Default Value: [auto]
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TranscriptionChunkingStrategyEnum? Enum { get; init; }
#else
        public global::G.TranscriptionChunkingStrategyEnum? Enum { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Enum))]
#endif
        public bool IsEnum => Enum != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.VadConfig? VadConfig { get; init; }
#else
        public global::G.VadConfig? VadConfig { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VadConfig))]
#endif
        public bool IsVadConfig => VadConfig != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TranscriptionChunkingStrategy(global::G.TranscriptionChunkingStrategyEnum value) => new TranscriptionChunkingStrategy((global::G.TranscriptionChunkingStrategyEnum?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TranscriptionChunkingStrategyEnum?(TranscriptionChunkingStrategy @this) => @this.Enum;

        /// <summary>
        /// 
        /// </summary>
        public TranscriptionChunkingStrategy(global::G.TranscriptionChunkingStrategyEnum? value)
        {
            Enum = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TranscriptionChunkingStrategy(global::G.VadConfig value) => new TranscriptionChunkingStrategy((global::G.VadConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.VadConfig?(TranscriptionChunkingStrategy @this) => @this.VadConfig;

        /// <summary>
        /// 
        /// </summary>
        public TranscriptionChunkingStrategy(global::G.VadConfig? value)
        {
            VadConfig = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TranscriptionChunkingStrategy(
            global::G.TranscriptionChunkingStrategyEnum? @enum,
            global::G.VadConfig? vadConfig
            )
        {
            Enum = @enum;
            VadConfig = vadConfig;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            VadConfig as object ??
            Enum as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Enum?.ToValueString() ??
            VadConfig?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsEnum && !IsVadConfig || !IsEnum && IsVadConfig;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.TranscriptionChunkingStrategyEnum?, TResult>? @enum = null,
            global::System.Func<global::G.VadConfig?, TResult>? vadConfig = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEnum && @enum != null)
            {
                return @enum(Enum!);
            }
            else if (IsVadConfig && vadConfig != null)
            {
                return vadConfig(VadConfig!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.TranscriptionChunkingStrategyEnum?>? @enum = null,
            global::System.Action<global::G.VadConfig?>? vadConfig = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEnum)
            {
                @enum?.Invoke(Enum!);
            }
            else if (IsVadConfig)
            {
                vadConfig?.Invoke(VadConfig!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Enum,
                typeof(global::G.TranscriptionChunkingStrategyEnum),
                VadConfig,
                typeof(global::G.VadConfig),
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
        public bool Equals(TranscriptionChunkingStrategy other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.TranscriptionChunkingStrategyEnum?>.Default.Equals(Enum, other.Enum) &&
                global::System.Collections.Generic.EqualityComparer<global::G.VadConfig?>.Default.Equals(VadConfig, other.VadConfig) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TranscriptionChunkingStrategy obj1, TranscriptionChunkingStrategy obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TranscriptionChunkingStrategy>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TranscriptionChunkingStrategy obj1, TranscriptionChunkingStrategy obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TranscriptionChunkingStrategy o && Equals(o);
        }
    }
}
