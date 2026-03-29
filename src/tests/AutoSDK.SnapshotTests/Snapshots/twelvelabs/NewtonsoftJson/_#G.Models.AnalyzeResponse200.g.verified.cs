//HintName: G.Models.AnalyzeResponse200.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct AnalyzeResponse200 : global::System.IEquatable<AnalyzeResponse200>
    {
        /// <summary>
        /// When the value of the `stream` parameter is set to `true`, the platform provides a streaming response in the NDJSON format.<br/>
        /// The stream contains three types of events:<br/>
        /// 1. Stream start<br/>
        /// 2. Text generation<br/>
        /// 3. Stream end<br/>
        /// To integrate the response into your application, follow the guidelines below:<br/>
        /// - Parse each line of the response as a separate JSON object.<br/>
        /// - Check the `event_type` field to determine how to handle the event.<br/>
        /// - For `text_generation` events, process the `text` field as it arrives. Depending on your application's requirements, this may involve displaying the text incrementally, storing it for later use, or performing any tasks.<br/>
        /// - Use the `stream_start` and `stream_end` events to manage the lifecycle of your streaming session.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.StreamAnalyzeResponse? StreamAnalyzeResponse { get; init; }
#else
        public global::G.StreamAnalyzeResponse? StreamAnalyzeResponse { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StreamAnalyzeResponse))]
#endif
        public bool IsStreamAnalyzeResponse => StreamAnalyzeResponse != null;

        /// <summary>
        /// When the value of the `stream` parameter is set to `false`, the response is as follows:
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.NonStreamAnalyzeResponse? NonStreamAnalyzeResponse { get; init; }
#else
        public global::G.NonStreamAnalyzeResponse? NonStreamAnalyzeResponse { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NonStreamAnalyzeResponse))]
#endif
        public bool IsNonStreamAnalyzeResponse => NonStreamAnalyzeResponse != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnalyzeResponse200(global::G.StreamAnalyzeResponse value) => new AnalyzeResponse200((global::G.StreamAnalyzeResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.StreamAnalyzeResponse?(AnalyzeResponse200 @this) => @this.StreamAnalyzeResponse;

        /// <summary>
        /// 
        /// </summary>
        public AnalyzeResponse200(global::G.StreamAnalyzeResponse? value)
        {
            StreamAnalyzeResponse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnalyzeResponse200(global::G.NonStreamAnalyzeResponse value) => new AnalyzeResponse200((global::G.NonStreamAnalyzeResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.NonStreamAnalyzeResponse?(AnalyzeResponse200 @this) => @this.NonStreamAnalyzeResponse;

        /// <summary>
        /// 
        /// </summary>
        public AnalyzeResponse200(global::G.NonStreamAnalyzeResponse? value)
        {
            NonStreamAnalyzeResponse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AnalyzeResponse200(
            global::G.StreamAnalyzeResponse? streamAnalyzeResponse,
            global::G.NonStreamAnalyzeResponse? nonStreamAnalyzeResponse
            )
        {
            StreamAnalyzeResponse = streamAnalyzeResponse;
            NonStreamAnalyzeResponse = nonStreamAnalyzeResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            NonStreamAnalyzeResponse as object ??
            StreamAnalyzeResponse as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            StreamAnalyzeResponse?.ToString() ??
            NonStreamAnalyzeResponse?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStreamAnalyzeResponse && !IsNonStreamAnalyzeResponse || !IsStreamAnalyzeResponse && IsNonStreamAnalyzeResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.StreamAnalyzeResponse?, TResult>? streamAnalyzeResponse = null,
            global::System.Func<global::G.NonStreamAnalyzeResponse?, TResult>? nonStreamAnalyzeResponse = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStreamAnalyzeResponse && streamAnalyzeResponse != null)
            {
                return streamAnalyzeResponse(StreamAnalyzeResponse!);
            }
            else if (IsNonStreamAnalyzeResponse && nonStreamAnalyzeResponse != null)
            {
                return nonStreamAnalyzeResponse(NonStreamAnalyzeResponse!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.StreamAnalyzeResponse?>? streamAnalyzeResponse = null,
            global::System.Action<global::G.NonStreamAnalyzeResponse?>? nonStreamAnalyzeResponse = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStreamAnalyzeResponse)
            {
                streamAnalyzeResponse?.Invoke(StreamAnalyzeResponse!);
            }
            else if (IsNonStreamAnalyzeResponse)
            {
                nonStreamAnalyzeResponse?.Invoke(NonStreamAnalyzeResponse!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                StreamAnalyzeResponse,
                typeof(global::G.StreamAnalyzeResponse),
                NonStreamAnalyzeResponse,
                typeof(global::G.NonStreamAnalyzeResponse),
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
        public bool Equals(AnalyzeResponse200 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.StreamAnalyzeResponse?>.Default.Equals(StreamAnalyzeResponse, other.StreamAnalyzeResponse) &&
                global::System.Collections.Generic.EqualityComparer<global::G.NonStreamAnalyzeResponse?>.Default.Equals(NonStreamAnalyzeResponse, other.NonStreamAnalyzeResponse) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AnalyzeResponse200 obj1, AnalyzeResponse200 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AnalyzeResponse200>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AnalyzeResponse200 obj1, AnalyzeResponse200 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AnalyzeResponse200 o && Equals(o);
        }
    }
}
