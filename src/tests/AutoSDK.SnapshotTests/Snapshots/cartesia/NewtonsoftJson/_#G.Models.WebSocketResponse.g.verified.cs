//HintName: G.Models.WebSocketResponse.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct WebSocketResponse : global::System.IEquatable<WebSocketResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.WebSocketResponseDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.WebSocketResponseVariant1? Chunk { get; init; }
#else
        public global::G.WebSocketResponseVariant1? Chunk { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Chunk))]
#endif
        public bool IsChunk => Chunk != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickChunk(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.WebSocketResponseVariant1? value)
        {
            value = Chunk;
            return IsChunk;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.WebSocketResponseVariant2? FlushDone { get; init; }
#else
        public global::G.WebSocketResponseVariant2? FlushDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FlushDone))]
#endif
        public bool IsFlushDone => FlushDone != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickFlushDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.WebSocketResponseVariant2? value)
        {
            value = FlushDone;
            return IsFlushDone;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.WebSocketResponseVariant3? Done { get; init; }
#else
        public global::G.WebSocketResponseVariant3? Done { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Done))]
#endif
        public bool IsDone => Done != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.WebSocketResponseVariant3? value)
        {
            value = Done;
            return IsDone;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.WebSocketResponseVariant4? Timestamps { get; init; }
#else
        public global::G.WebSocketResponseVariant4? Timestamps { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Timestamps))]
#endif
        public bool IsTimestamps => Timestamps != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTimestamps(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.WebSocketResponseVariant4? value)
        {
            value = Timestamps;
            return IsTimestamps;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.WebSocketResponseVariant5? Error { get; init; }
#else
        public global::G.WebSocketResponseVariant5? Error { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Error))]
#endif
        public bool IsError => Error != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.WebSocketResponseVariant5? value)
        {
            value = Error;
            return IsError;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.WebSocketResponseVariant6? PhonemeTimestamps { get; init; }
#else
        public global::G.WebSocketResponseVariant6? PhonemeTimestamps { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PhonemeTimestamps))]
#endif
        public bool IsPhonemeTimestamps => PhonemeTimestamps != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickPhonemeTimestamps(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.WebSocketResponseVariant6? value)
        {
            value = PhonemeTimestamps;
            return IsPhonemeTimestamps;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebSocketResponse(global::G.WebSocketResponseVariant1 value) => new WebSocketResponse((global::G.WebSocketResponseVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.WebSocketResponseVariant1?(WebSocketResponse @this) => @this.Chunk;

        /// <summary>
        /// 
        /// </summary>
        public WebSocketResponse(global::G.WebSocketResponseVariant1? value)
        {
            Chunk = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static WebSocketResponse FromChunk(global::G.WebSocketResponseVariant1? value) => new WebSocketResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebSocketResponse(global::G.WebSocketResponseVariant2 value) => new WebSocketResponse((global::G.WebSocketResponseVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.WebSocketResponseVariant2?(WebSocketResponse @this) => @this.FlushDone;

        /// <summary>
        /// 
        /// </summary>
        public WebSocketResponse(global::G.WebSocketResponseVariant2? value)
        {
            FlushDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static WebSocketResponse FromFlushDone(global::G.WebSocketResponseVariant2? value) => new WebSocketResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebSocketResponse(global::G.WebSocketResponseVariant3 value) => new WebSocketResponse((global::G.WebSocketResponseVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.WebSocketResponseVariant3?(WebSocketResponse @this) => @this.Done;

        /// <summary>
        /// 
        /// </summary>
        public WebSocketResponse(global::G.WebSocketResponseVariant3? value)
        {
            Done = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static WebSocketResponse FromDone(global::G.WebSocketResponseVariant3? value) => new WebSocketResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebSocketResponse(global::G.WebSocketResponseVariant4 value) => new WebSocketResponse((global::G.WebSocketResponseVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.WebSocketResponseVariant4?(WebSocketResponse @this) => @this.Timestamps;

        /// <summary>
        /// 
        /// </summary>
        public WebSocketResponse(global::G.WebSocketResponseVariant4? value)
        {
            Timestamps = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static WebSocketResponse FromTimestamps(global::G.WebSocketResponseVariant4? value) => new WebSocketResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebSocketResponse(global::G.WebSocketResponseVariant5 value) => new WebSocketResponse((global::G.WebSocketResponseVariant5?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.WebSocketResponseVariant5?(WebSocketResponse @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public WebSocketResponse(global::G.WebSocketResponseVariant5? value)
        {
            Error = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static WebSocketResponse FromError(global::G.WebSocketResponseVariant5? value) => new WebSocketResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebSocketResponse(global::G.WebSocketResponseVariant6 value) => new WebSocketResponse((global::G.WebSocketResponseVariant6?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.WebSocketResponseVariant6?(WebSocketResponse @this) => @this.PhonemeTimestamps;

        /// <summary>
        /// 
        /// </summary>
        public WebSocketResponse(global::G.WebSocketResponseVariant6? value)
        {
            PhonemeTimestamps = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static WebSocketResponse FromPhonemeTimestamps(global::G.WebSocketResponseVariant6? value) => new WebSocketResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public WebSocketResponse(
            global::G.WebSocketResponseDiscriminatorType? type,
            global::G.WebSocketResponseVariant1? chunk,
            global::G.WebSocketResponseVariant2? flushDone,
            global::G.WebSocketResponseVariant3? done,
            global::G.WebSocketResponseVariant4? timestamps,
            global::G.WebSocketResponseVariant5? error,
            global::G.WebSocketResponseVariant6? phonemeTimestamps
            )
        {
            Type = type;

            Chunk = chunk;
            FlushDone = flushDone;
            Done = done;
            Timestamps = timestamps;
            Error = error;
            PhonemeTimestamps = phonemeTimestamps;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            PhonemeTimestamps as object ??
            Error as object ??
            Timestamps as object ??
            Done as object ??
            FlushDone as object ??
            Chunk as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Chunk?.ToString() ??
            FlushDone?.ToString() ??
            Done?.ToString() ??
            Timestamps?.ToString() ??
            Error?.ToString() ??
            PhonemeTimestamps?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsChunk && !IsFlushDone && !IsDone && !IsTimestamps && !IsError && !IsPhonemeTimestamps || !IsChunk && IsFlushDone && !IsDone && !IsTimestamps && !IsError && !IsPhonemeTimestamps || !IsChunk && !IsFlushDone && IsDone && !IsTimestamps && !IsError && !IsPhonemeTimestamps || !IsChunk && !IsFlushDone && !IsDone && IsTimestamps && !IsError && !IsPhonemeTimestamps || !IsChunk && !IsFlushDone && !IsDone && !IsTimestamps && IsError && !IsPhonemeTimestamps || !IsChunk && !IsFlushDone && !IsDone && !IsTimestamps && !IsError && IsPhonemeTimestamps;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.WebSocketResponseVariant1, TResult>? chunk = null,
            global::System.Func<global::G.WebSocketResponseVariant2, TResult>? flushDone = null,
            global::System.Func<global::G.WebSocketResponseVariant3, TResult>? done = null,
            global::System.Func<global::G.WebSocketResponseVariant4, TResult>? timestamps = null,
            global::System.Func<global::G.WebSocketResponseVariant5, TResult>? error = null,
            global::System.Func<global::G.WebSocketResponseVariant6, TResult>? phonemeTimestamps = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChunk && chunk != null)
            {
                return chunk(Chunk!);
            }
            else if (IsFlushDone && flushDone != null)
            {
                return flushDone(FlushDone!);
            }
            else if (IsDone && done != null)
            {
                return done(Done!);
            }
            else if (IsTimestamps && timestamps != null)
            {
                return timestamps(Timestamps!);
            }
            else if (IsError && error != null)
            {
                return error(Error!);
            }
            else if (IsPhonemeTimestamps && phonemeTimestamps != null)
            {
                return phonemeTimestamps(PhonemeTimestamps!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.WebSocketResponseVariant1>? chunk = null,

            global::System.Action<global::G.WebSocketResponseVariant2>? flushDone = null,

            global::System.Action<global::G.WebSocketResponseVariant3>? done = null,

            global::System.Action<global::G.WebSocketResponseVariant4>? timestamps = null,

            global::System.Action<global::G.WebSocketResponseVariant5>? error = null,

            global::System.Action<global::G.WebSocketResponseVariant6>? phonemeTimestamps = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChunk)
            {
                chunk?.Invoke(Chunk!);
            }
            else if (IsFlushDone)
            {
                flushDone?.Invoke(FlushDone!);
            }
            else if (IsDone)
            {
                done?.Invoke(Done!);
            }
            else if (IsTimestamps)
            {
                timestamps?.Invoke(Timestamps!);
            }
            else if (IsError)
            {
                error?.Invoke(Error!);
            }
            else if (IsPhonemeTimestamps)
            {
                phonemeTimestamps?.Invoke(PhonemeTimestamps!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::G.WebSocketResponseVariant1>? chunk = null,
            global::System.Action<global::G.WebSocketResponseVariant2>? flushDone = null,
            global::System.Action<global::G.WebSocketResponseVariant3>? done = null,
            global::System.Action<global::G.WebSocketResponseVariant4>? timestamps = null,
            global::System.Action<global::G.WebSocketResponseVariant5>? error = null,
            global::System.Action<global::G.WebSocketResponseVariant6>? phonemeTimestamps = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChunk)
            {
                chunk?.Invoke(Chunk!);
            }
            else if (IsFlushDone)
            {
                flushDone?.Invoke(FlushDone!);
            }
            else if (IsDone)
            {
                done?.Invoke(Done!);
            }
            else if (IsTimestamps)
            {
                timestamps?.Invoke(Timestamps!);
            }
            else if (IsError)
            {
                error?.Invoke(Error!);
            }
            else if (IsPhonemeTimestamps)
            {
                phonemeTimestamps?.Invoke(PhonemeTimestamps!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Chunk,
                typeof(global::G.WebSocketResponseVariant1),
                FlushDone,
                typeof(global::G.WebSocketResponseVariant2),
                Done,
                typeof(global::G.WebSocketResponseVariant3),
                Timestamps,
                typeof(global::G.WebSocketResponseVariant4),
                Error,
                typeof(global::G.WebSocketResponseVariant5),
                PhonemeTimestamps,
                typeof(global::G.WebSocketResponseVariant6),
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
        public bool Equals(WebSocketResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.WebSocketResponseVariant1?>.Default.Equals(Chunk, other.Chunk) &&
                global::System.Collections.Generic.EqualityComparer<global::G.WebSocketResponseVariant2?>.Default.Equals(FlushDone, other.FlushDone) &&
                global::System.Collections.Generic.EqualityComparer<global::G.WebSocketResponseVariant3?>.Default.Equals(Done, other.Done) &&
                global::System.Collections.Generic.EqualityComparer<global::G.WebSocketResponseVariant4?>.Default.Equals(Timestamps, other.Timestamps) &&
                global::System.Collections.Generic.EqualityComparer<global::G.WebSocketResponseVariant5?>.Default.Equals(Error, other.Error) &&
                global::System.Collections.Generic.EqualityComparer<global::G.WebSocketResponseVariant6?>.Default.Equals(PhonemeTimestamps, other.PhonemeTimestamps) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(WebSocketResponse obj1, WebSocketResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<WebSocketResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(WebSocketResponse obj1, WebSocketResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WebSocketResponse o && Equals(o);
        }
    }
}
