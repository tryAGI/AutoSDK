//HintName: G.Models.GenerateStreamedResponse.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Response in content type stream when `stream` is `true` in the request parameters. Generation tokens are streamed with the GenerationStream response. The final response is of type GenerationFinalResponse.
    /// </summary>
    public readonly partial struct GenerateStreamedResponse : global::System.IEquatable<GenerateStreamedResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.GenerateStreamedResponseDiscriminatorEventType? EventType { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GenerateStreamText? TextGeneration { get; init; }
#else
        public global::G.GenerateStreamText? TextGeneration { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextGeneration))]
#endif
        public bool IsTextGeneration => TextGeneration != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GenerateStreamEnd? StreamEnd { get; init; }
#else
        public global::G.GenerateStreamEnd? StreamEnd { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StreamEnd))]
#endif
        public bool IsStreamEnd => StreamEnd != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GenerateStreamError? StreamError { get; init; }
#else
        public global::G.GenerateStreamError? StreamError { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StreamError))]
#endif
        public bool IsStreamError => StreamError != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GenerateStreamedResponse(global::G.GenerateStreamText value) => new GenerateStreamedResponse((global::G.GenerateStreamText?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GenerateStreamText?(GenerateStreamedResponse @this) => @this.TextGeneration;

        /// <summary>
        /// 
        /// </summary>
        public GenerateStreamedResponse(global::G.GenerateStreamText? value)
        {
            TextGeneration = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GenerateStreamedResponse(global::G.GenerateStreamEnd value) => new GenerateStreamedResponse((global::G.GenerateStreamEnd?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GenerateStreamEnd?(GenerateStreamedResponse @this) => @this.StreamEnd;

        /// <summary>
        /// 
        /// </summary>
        public GenerateStreamedResponse(global::G.GenerateStreamEnd? value)
        {
            StreamEnd = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GenerateStreamedResponse(global::G.GenerateStreamError value) => new GenerateStreamedResponse((global::G.GenerateStreamError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GenerateStreamError?(GenerateStreamedResponse @this) => @this.StreamError;

        /// <summary>
        /// 
        /// </summary>
        public GenerateStreamedResponse(global::G.GenerateStreamError? value)
        {
            StreamError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public GenerateStreamedResponse(
            global::G.GenerateStreamedResponseDiscriminatorEventType? eventType,
            global::G.GenerateStreamText? textGeneration,
            global::G.GenerateStreamEnd? streamEnd,
            global::G.GenerateStreamError? streamError
            )
        {
            EventType = eventType;

            TextGeneration = textGeneration;
            StreamEnd = streamEnd;
            StreamError = streamError;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            StreamError as object ??
            StreamEnd as object ??
            TextGeneration as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TextGeneration?.ToString() ??
            StreamEnd?.ToString() ??
            StreamError?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTextGeneration && !IsStreamEnd && !IsStreamError || !IsTextGeneration && IsStreamEnd && !IsStreamError || !IsTextGeneration && !IsStreamEnd && IsStreamError;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.GenerateStreamText?, TResult>? textGeneration = null,
            global::System.Func<global::G.GenerateStreamEnd?, TResult>? streamEnd = null,
            global::System.Func<global::G.GenerateStreamError?, TResult>? streamError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTextGeneration && textGeneration != null)
            {
                return textGeneration(TextGeneration!);
            }
            else if (IsStreamEnd && streamEnd != null)
            {
                return streamEnd(StreamEnd!);
            }
            else if (IsStreamError && streamError != null)
            {
                return streamError(StreamError!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.GenerateStreamText?>? textGeneration = null,
            global::System.Action<global::G.GenerateStreamEnd?>? streamEnd = null,
            global::System.Action<global::G.GenerateStreamError?>? streamError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTextGeneration)
            {
                textGeneration?.Invoke(TextGeneration!);
            }
            else if (IsStreamEnd)
            {
                streamEnd?.Invoke(StreamEnd!);
            }
            else if (IsStreamError)
            {
                streamError?.Invoke(StreamError!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TextGeneration,
                typeof(global::G.GenerateStreamText),
                StreamEnd,
                typeof(global::G.GenerateStreamEnd),
                StreamError,
                typeof(global::G.GenerateStreamError),
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
        public bool Equals(GenerateStreamedResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.GenerateStreamText?>.Default.Equals(TextGeneration, other.TextGeneration) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GenerateStreamEnd?>.Default.Equals(StreamEnd, other.StreamEnd) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GenerateStreamError?>.Default.Equals(StreamError, other.StreamError) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(GenerateStreamedResponse obj1, GenerateStreamedResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<GenerateStreamedResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(GenerateStreamedResponse obj1, GenerateStreamedResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GenerateStreamedResponse o && Equals(o);
        }
    }
}
