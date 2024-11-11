//HintName: G.Models.GenerateStreamedResponse.g.cs
using System.Linq;
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
#if NET6_0_OR_GREATER
        public global::G.GenerateStreamText? StreamText { get; init; }
#else
        public global::G.GenerateStreamText? StreamText { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StreamText))]
#endif
        public bool IsStreamText => StreamText != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GenerateStreamedResponse(global::G.GenerateStreamText value) => new GenerateStreamedResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GenerateStreamText?(GenerateStreamedResponse @this) => @this.StreamText;

        /// <summary>
        /// 
        /// </summary>
        public GenerateStreamedResponse(global::G.GenerateStreamText? value)
        {
            StreamText = value;
        }

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
        public static implicit operator GenerateStreamedResponse(global::G.GenerateStreamEnd value) => new GenerateStreamedResponse(value);

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
        public static implicit operator GenerateStreamedResponse(global::G.GenerateStreamError value) => new GenerateStreamedResponse(value);

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
            global::G.GenerateStreamText? streamText,
            global::G.GenerateStreamEnd? streamEnd,
            global::G.GenerateStreamError? streamError
            )
        {
            StreamText = streamText;
            StreamEnd = streamEnd;
            StreamError = streamError;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            StreamError as object ??
            StreamEnd as object ??
            StreamText as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStreamText && !IsStreamEnd && !IsStreamError || !IsStreamText && IsStreamEnd && !IsStreamError || !IsStreamText && !IsStreamEnd && IsStreamError;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.GenerateStreamText?, TResult>? streamText = null,
            global::System.Func<global::G.GenerateStreamEnd?, TResult>? streamEnd = null,
            global::System.Func<global::G.GenerateStreamError?, TResult>? streamError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStreamText && streamText != null)
            {
                return streamText(StreamText!);
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
            global::System.Action<global::G.GenerateStreamText?>? streamText = null,
            global::System.Action<global::G.GenerateStreamEnd?>? streamEnd = null,
            global::System.Action<global::G.GenerateStreamError?>? streamError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStreamText)
            {
                streamText?.Invoke(StreamText!);
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
                StreamText,
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
            return fields.Aggregate(offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(GenerateStreamedResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.GenerateStreamText?>.Default.Equals(StreamText, other.StreamText) &&
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
