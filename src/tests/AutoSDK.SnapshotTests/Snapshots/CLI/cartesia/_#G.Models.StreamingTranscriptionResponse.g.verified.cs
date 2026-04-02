//HintName: G.Models.StreamingTranscriptionResponse.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The server sends transcription results, control messages, or error messages. Each message has a `type` field to distinguish between different message types.
    /// </summary>
    public readonly partial struct StreamingTranscriptionResponse : global::System.IEquatable<StreamingTranscriptionResponse>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AllOf<global::G.StreamingTranscriptionResponseVariant12, global::G.TranscriptMessage>? StreamingTranscriptionResponseVariant1 { get; init; }
#else
        public global::G.AllOf<global::G.StreamingTranscriptionResponseVariant12, global::G.TranscriptMessage>? StreamingTranscriptionResponseVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StreamingTranscriptionResponseVariant1))]
#endif
        public bool IsStreamingTranscriptionResponseVariant1 => StreamingTranscriptionResponseVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AllOf<global::G.StreamingTranscriptionResponseVariant22, global::G.FlushDoneMessage>? StreamingTranscriptionResponseVariant2 { get; init; }
#else
        public global::G.AllOf<global::G.StreamingTranscriptionResponseVariant22, global::G.FlushDoneMessage>? StreamingTranscriptionResponseVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StreamingTranscriptionResponseVariant2))]
#endif
        public bool IsStreamingTranscriptionResponseVariant2 => StreamingTranscriptionResponseVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AllOf<global::G.StreamingTranscriptionResponseVariant32, global::G.DoneMessage>? StreamingTranscriptionResponseVariant3 { get; init; }
#else
        public global::G.AllOf<global::G.StreamingTranscriptionResponseVariant32, global::G.DoneMessage>? StreamingTranscriptionResponseVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StreamingTranscriptionResponseVariant3))]
#endif
        public bool IsStreamingTranscriptionResponseVariant3 => StreamingTranscriptionResponseVariant3 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AllOf<global::G.StreamingTranscriptionResponseVariant42, global::G.ErrorMessage>? StreamingTranscriptionResponseVariant4 { get; init; }
#else
        public global::G.AllOf<global::G.StreamingTranscriptionResponseVariant42, global::G.ErrorMessage>? StreamingTranscriptionResponseVariant4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StreamingTranscriptionResponseVariant4))]
#endif
        public bool IsStreamingTranscriptionResponseVariant4 => StreamingTranscriptionResponseVariant4 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamingTranscriptionResponse(global::G.AllOf<global::G.StreamingTranscriptionResponseVariant12, global::G.TranscriptMessage> value) => new StreamingTranscriptionResponse((global::G.AllOf<global::G.StreamingTranscriptionResponseVariant12, global::G.TranscriptMessage>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AllOf<global::G.StreamingTranscriptionResponseVariant12, global::G.TranscriptMessage>?(StreamingTranscriptionResponse @this) => @this.StreamingTranscriptionResponseVariant1;

        /// <summary>
        /// 
        /// </summary>
        public StreamingTranscriptionResponse(global::G.AllOf<global::G.StreamingTranscriptionResponseVariant12, global::G.TranscriptMessage>? value)
        {
            StreamingTranscriptionResponseVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamingTranscriptionResponse(global::G.AllOf<global::G.StreamingTranscriptionResponseVariant22, global::G.FlushDoneMessage> value) => new StreamingTranscriptionResponse((global::G.AllOf<global::G.StreamingTranscriptionResponseVariant22, global::G.FlushDoneMessage>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AllOf<global::G.StreamingTranscriptionResponseVariant22, global::G.FlushDoneMessage>?(StreamingTranscriptionResponse @this) => @this.StreamingTranscriptionResponseVariant2;

        /// <summary>
        /// 
        /// </summary>
        public StreamingTranscriptionResponse(global::G.AllOf<global::G.StreamingTranscriptionResponseVariant22, global::G.FlushDoneMessage>? value)
        {
            StreamingTranscriptionResponseVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamingTranscriptionResponse(global::G.AllOf<global::G.StreamingTranscriptionResponseVariant32, global::G.DoneMessage> value) => new StreamingTranscriptionResponse((global::G.AllOf<global::G.StreamingTranscriptionResponseVariant32, global::G.DoneMessage>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AllOf<global::G.StreamingTranscriptionResponseVariant32, global::G.DoneMessage>?(StreamingTranscriptionResponse @this) => @this.StreamingTranscriptionResponseVariant3;

        /// <summary>
        /// 
        /// </summary>
        public StreamingTranscriptionResponse(global::G.AllOf<global::G.StreamingTranscriptionResponseVariant32, global::G.DoneMessage>? value)
        {
            StreamingTranscriptionResponseVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamingTranscriptionResponse(global::G.AllOf<global::G.StreamingTranscriptionResponseVariant42, global::G.ErrorMessage> value) => new StreamingTranscriptionResponse((global::G.AllOf<global::G.StreamingTranscriptionResponseVariant42, global::G.ErrorMessage>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AllOf<global::G.StreamingTranscriptionResponseVariant42, global::G.ErrorMessage>?(StreamingTranscriptionResponse @this) => @this.StreamingTranscriptionResponseVariant4;

        /// <summary>
        /// 
        /// </summary>
        public StreamingTranscriptionResponse(global::G.AllOf<global::G.StreamingTranscriptionResponseVariant42, global::G.ErrorMessage>? value)
        {
            StreamingTranscriptionResponseVariant4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public StreamingTranscriptionResponse(
            global::G.AllOf<global::G.StreamingTranscriptionResponseVariant12, global::G.TranscriptMessage>? streamingTranscriptionResponseVariant1,
            global::G.AllOf<global::G.StreamingTranscriptionResponseVariant22, global::G.FlushDoneMessage>? streamingTranscriptionResponseVariant2,
            global::G.AllOf<global::G.StreamingTranscriptionResponseVariant32, global::G.DoneMessage>? streamingTranscriptionResponseVariant3,
            global::G.AllOf<global::G.StreamingTranscriptionResponseVariant42, global::G.ErrorMessage>? streamingTranscriptionResponseVariant4
            )
        {
            StreamingTranscriptionResponseVariant1 = streamingTranscriptionResponseVariant1;
            StreamingTranscriptionResponseVariant2 = streamingTranscriptionResponseVariant2;
            StreamingTranscriptionResponseVariant3 = streamingTranscriptionResponseVariant3;
            StreamingTranscriptionResponseVariant4 = streamingTranscriptionResponseVariant4;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            StreamingTranscriptionResponseVariant4 as object ??
            StreamingTranscriptionResponseVariant3 as object ??
            StreamingTranscriptionResponseVariant2 as object ??
            StreamingTranscriptionResponseVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            StreamingTranscriptionResponseVariant1?.ToString() ??
            StreamingTranscriptionResponseVariant2?.ToString() ??
            StreamingTranscriptionResponseVariant3?.ToString() ??
            StreamingTranscriptionResponseVariant4?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStreamingTranscriptionResponseVariant1 && !IsStreamingTranscriptionResponseVariant2 && !IsStreamingTranscriptionResponseVariant3 && !IsStreamingTranscriptionResponseVariant4 || !IsStreamingTranscriptionResponseVariant1 && IsStreamingTranscriptionResponseVariant2 && !IsStreamingTranscriptionResponseVariant3 && !IsStreamingTranscriptionResponseVariant4 || !IsStreamingTranscriptionResponseVariant1 && !IsStreamingTranscriptionResponseVariant2 && IsStreamingTranscriptionResponseVariant3 && !IsStreamingTranscriptionResponseVariant4 || !IsStreamingTranscriptionResponseVariant1 && !IsStreamingTranscriptionResponseVariant2 && !IsStreamingTranscriptionResponseVariant3 && IsStreamingTranscriptionResponseVariant4;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.AllOf<global::G.StreamingTranscriptionResponseVariant12, global::G.TranscriptMessage>?, TResult>? streamingTranscriptionResponseVariant1 = null,
            global::System.Func<global::G.AllOf<global::G.StreamingTranscriptionResponseVariant22, global::G.FlushDoneMessage>?, TResult>? streamingTranscriptionResponseVariant2 = null,
            global::System.Func<global::G.AllOf<global::G.StreamingTranscriptionResponseVariant32, global::G.DoneMessage>?, TResult>? streamingTranscriptionResponseVariant3 = null,
            global::System.Func<global::G.AllOf<global::G.StreamingTranscriptionResponseVariant42, global::G.ErrorMessage>?, TResult>? streamingTranscriptionResponseVariant4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStreamingTranscriptionResponseVariant1 && streamingTranscriptionResponseVariant1 != null)
            {
                return streamingTranscriptionResponseVariant1(StreamingTranscriptionResponseVariant1!);
            }
            else if (IsStreamingTranscriptionResponseVariant2 && streamingTranscriptionResponseVariant2 != null)
            {
                return streamingTranscriptionResponseVariant2(StreamingTranscriptionResponseVariant2!);
            }
            else if (IsStreamingTranscriptionResponseVariant3 && streamingTranscriptionResponseVariant3 != null)
            {
                return streamingTranscriptionResponseVariant3(StreamingTranscriptionResponseVariant3!);
            }
            else if (IsStreamingTranscriptionResponseVariant4 && streamingTranscriptionResponseVariant4 != null)
            {
                return streamingTranscriptionResponseVariant4(StreamingTranscriptionResponseVariant4!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.AllOf<global::G.StreamingTranscriptionResponseVariant12, global::G.TranscriptMessage>?>? streamingTranscriptionResponseVariant1 = null,
            global::System.Action<global::G.AllOf<global::G.StreamingTranscriptionResponseVariant22, global::G.FlushDoneMessage>?>? streamingTranscriptionResponseVariant2 = null,
            global::System.Action<global::G.AllOf<global::G.StreamingTranscriptionResponseVariant32, global::G.DoneMessage>?>? streamingTranscriptionResponseVariant3 = null,
            global::System.Action<global::G.AllOf<global::G.StreamingTranscriptionResponseVariant42, global::G.ErrorMessage>?>? streamingTranscriptionResponseVariant4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStreamingTranscriptionResponseVariant1)
            {
                streamingTranscriptionResponseVariant1?.Invoke(StreamingTranscriptionResponseVariant1!);
            }
            else if (IsStreamingTranscriptionResponseVariant2)
            {
                streamingTranscriptionResponseVariant2?.Invoke(StreamingTranscriptionResponseVariant2!);
            }
            else if (IsStreamingTranscriptionResponseVariant3)
            {
                streamingTranscriptionResponseVariant3?.Invoke(StreamingTranscriptionResponseVariant3!);
            }
            else if (IsStreamingTranscriptionResponseVariant4)
            {
                streamingTranscriptionResponseVariant4?.Invoke(StreamingTranscriptionResponseVariant4!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                StreamingTranscriptionResponseVariant1,
                typeof(global::G.AllOf<global::G.StreamingTranscriptionResponseVariant12, global::G.TranscriptMessage>),
                StreamingTranscriptionResponseVariant2,
                typeof(global::G.AllOf<global::G.StreamingTranscriptionResponseVariant22, global::G.FlushDoneMessage>),
                StreamingTranscriptionResponseVariant3,
                typeof(global::G.AllOf<global::G.StreamingTranscriptionResponseVariant32, global::G.DoneMessage>),
                StreamingTranscriptionResponseVariant4,
                typeof(global::G.AllOf<global::G.StreamingTranscriptionResponseVariant42, global::G.ErrorMessage>),
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
        public bool Equals(StreamingTranscriptionResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.AllOf<global::G.StreamingTranscriptionResponseVariant12, global::G.TranscriptMessage>?>.Default.Equals(StreamingTranscriptionResponseVariant1, other.StreamingTranscriptionResponseVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AllOf<global::G.StreamingTranscriptionResponseVariant22, global::G.FlushDoneMessage>?>.Default.Equals(StreamingTranscriptionResponseVariant2, other.StreamingTranscriptionResponseVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AllOf<global::G.StreamingTranscriptionResponseVariant32, global::G.DoneMessage>?>.Default.Equals(StreamingTranscriptionResponseVariant3, other.StreamingTranscriptionResponseVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AllOf<global::G.StreamingTranscriptionResponseVariant42, global::G.ErrorMessage>?>.Default.Equals(StreamingTranscriptionResponseVariant4, other.StreamingTranscriptionResponseVariant4) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(StreamingTranscriptionResponse obj1, StreamingTranscriptionResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StreamingTranscriptionResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(StreamingTranscriptionResponse obj1, StreamingTranscriptionResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StreamingTranscriptionResponse o && Equals(o);
        }
    }
}
