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
        public global::G.TranscriptionChunkingStrategyEnum? Value1 { get; init; }
#else
        public global::G.TranscriptionChunkingStrategyEnum? Value1 { get; }
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
        public global::G.VadConfig? Value2 { get; init; }
#else
        public global::G.VadConfig? Value2 { get; }
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
        public static implicit operator TranscriptionChunkingStrategy(global::G.TranscriptionChunkingStrategyEnum value) => new TranscriptionChunkingStrategy((global::G.TranscriptionChunkingStrategyEnum?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TranscriptionChunkingStrategyEnum?(TranscriptionChunkingStrategy @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public TranscriptionChunkingStrategy(global::G.TranscriptionChunkingStrategyEnum? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TranscriptionChunkingStrategy(global::G.VadConfig value) => new TranscriptionChunkingStrategy((global::G.VadConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.VadConfig?(TranscriptionChunkingStrategy @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public TranscriptionChunkingStrategy(global::G.VadConfig? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TranscriptionChunkingStrategy(
            global::G.TranscriptionChunkingStrategyEnum? value1,
            global::G.VadConfig? value2
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
            Value1?.ToValueString() ??
            Value2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && !IsValue2 || !IsValue1 && IsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.TranscriptionChunkingStrategyEnum?, TResult>? value1 = null,
            global::System.Func<global::G.VadConfig?, TResult>? value2 = null,
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
            global::System.Action<global::G.TranscriptionChunkingStrategyEnum?>? value1 = null,
            global::System.Action<global::G.VadConfig?>? value2 = null,
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
                typeof(global::G.TranscriptionChunkingStrategyEnum),
                Value2,
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
                global::System.Collections.Generic.EqualityComparer<global::G.TranscriptionChunkingStrategyEnum?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.VadConfig?>.Default.Equals(Value2, other.Value2) 
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
