//HintName: G.Models.QueryStreamedResponse.g.cs
using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// An individual event sent with Server-sent Events (SSE) when the query request is streamed.
    /// </summary>
    public readonly partial struct QueryStreamedResponse : global::System.IEquatable<QueryStreamedResponse>
    {
        /// <summary>
        /// The search response results.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.StreamSearchResponse? StreamSearch { get; init; }
#else
        public global::G.StreamSearchResponse? StreamSearch { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StreamSearch))]
#endif
        public bool IsStreamSearch => StreamSearch != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator QueryStreamedResponse(global::G.StreamSearchResponse value) => new QueryStreamedResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.StreamSearchResponse?(QueryStreamedResponse @this) => @this.StreamSearch;

        /// <summary>
        /// 
        /// </summary>
        public QueryStreamedResponse(global::G.StreamSearchResponse? value)
        {
            StreamSearch = value;
        }

        /// <summary>
        /// The chunk response from the generation, which may be a partial generation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.StreamGenerationChunk? StreamGenerationChunk { get; init; }
#else
        public global::G.StreamGenerationChunk? StreamGenerationChunk { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StreamGenerationChunk))]
#endif
        public bool IsStreamGenerationChunk => StreamGenerationChunk != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator QueryStreamedResponse(global::G.StreamGenerationChunk value) => new QueryStreamedResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.StreamGenerationChunk?(QueryStreamedResponse @this) => @this.StreamGenerationChunk;

        /// <summary>
        /// 
        /// </summary>
        public QueryStreamedResponse(global::G.StreamGenerationChunk? value)
        {
            StreamGenerationChunk = value;
        }

        /// <summary>
        /// The end of generation. There may still be more information such as the<br/>
        /// factual consistency score, but generation has stopped.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.StreamGenerationEnd? StreamGenerationEnd { get; init; }
#else
        public global::G.StreamGenerationEnd? StreamGenerationEnd { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StreamGenerationEnd))]
#endif
        public bool IsStreamGenerationEnd => StreamGenerationEnd != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator QueryStreamedResponse(global::G.StreamGenerationEnd value) => new QueryStreamedResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.StreamGenerationEnd?(QueryStreamedResponse @this) => @this.StreamGenerationEnd;

        /// <summary>
        /// 
        /// </summary>
        public QueryStreamedResponse(global::G.StreamGenerationEnd? value)
        {
            StreamGenerationEnd = value;
        }

        /// <summary>
        /// The end of a query response stream.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.StreamResponseEnd? StreamEnd { get; init; }
#else
        public global::G.StreamResponseEnd? StreamEnd { get; }
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
        public static implicit operator QueryStreamedResponse(global::G.StreamResponseEnd value) => new QueryStreamedResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.StreamResponseEnd?(QueryStreamedResponse @this) => @this.StreamEnd;

        /// <summary>
        /// 
        /// </summary>
        public QueryStreamedResponse(global::G.StreamResponseEnd? value)
        {
            StreamEnd = value;
        }

        /// <summary>
        /// Event containing the factual consistency score.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.FactualConsistencyScore? FactualConsistencyScore { get; init; }
#else
        public global::G.FactualConsistencyScore? FactualConsistencyScore { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FactualConsistencyScore))]
#endif
        public bool IsFactualConsistencyScore => FactualConsistencyScore != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator QueryStreamedResponse(global::G.FactualConsistencyScore value) => new QueryStreamedResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FactualConsistencyScore?(QueryStreamedResponse @this) => @this.FactualConsistencyScore;

        /// <summary>
        /// 
        /// </summary>
        public QueryStreamedResponse(global::G.FactualConsistencyScore? value)
        {
            FactualConsistencyScore = value;
        }

        /// <summary>
        /// Event containing information on how the generation was accomplished.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GenerationInfo? GenerationInfo { get; init; }
#else
        public global::G.GenerationInfo? GenerationInfo { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GenerationInfo))]
#endif
        public bool IsGenerationInfo => GenerationInfo != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator QueryStreamedResponse(global::G.GenerationInfo value) => new QueryStreamedResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GenerationInfo?(QueryStreamedResponse @this) => @this.GenerationInfo;

        /// <summary>
        /// 
        /// </summary>
        public QueryStreamedResponse(global::G.GenerationInfo? value)
        {
            GenerationInfo = value;
        }

        /// <summary>
        /// Event signaling there was an error with the request.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.StreamError? StreamError { get; init; }
#else
        public global::G.StreamError? StreamError { get; }
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
        public static implicit operator QueryStreamedResponse(global::G.StreamError value) => new QueryStreamedResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.StreamError?(QueryStreamedResponse @this) => @this.StreamError;

        /// <summary>
        /// 
        /// </summary>
        public QueryStreamedResponse(global::G.StreamError? value)
        {
            StreamError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public QueryStreamedResponse(
            global::G.StreamSearchResponse? streamSearch,
            global::G.StreamGenerationChunk? streamGenerationChunk,
            global::G.StreamGenerationEnd? streamGenerationEnd,
            global::G.StreamResponseEnd? streamEnd,
            global::G.FactualConsistencyScore? factualConsistencyScore,
            global::G.GenerationInfo? generationInfo,
            global::G.StreamError? streamError
            )
        {
            StreamSearch = streamSearch;
            StreamGenerationChunk = streamGenerationChunk;
            StreamGenerationEnd = streamGenerationEnd;
            StreamEnd = streamEnd;
            FactualConsistencyScore = factualConsistencyScore;
            GenerationInfo = generationInfo;
            StreamError = streamError;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            StreamError as object ??
            GenerationInfo as object ??
            FactualConsistencyScore as object ??
            StreamEnd as object ??
            StreamGenerationEnd as object ??
            StreamGenerationChunk as object ??
            StreamSearch as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStreamSearch && !IsStreamGenerationChunk && !IsStreamGenerationEnd && !IsStreamEnd && !IsFactualConsistencyScore && !IsGenerationInfo && !IsStreamError || !IsStreamSearch && IsStreamGenerationChunk && !IsStreamGenerationEnd && !IsStreamEnd && !IsFactualConsistencyScore && !IsGenerationInfo && !IsStreamError || !IsStreamSearch && !IsStreamGenerationChunk && IsStreamGenerationEnd && !IsStreamEnd && !IsFactualConsistencyScore && !IsGenerationInfo && !IsStreamError || !IsStreamSearch && !IsStreamGenerationChunk && !IsStreamGenerationEnd && IsStreamEnd && !IsFactualConsistencyScore && !IsGenerationInfo && !IsStreamError || !IsStreamSearch && !IsStreamGenerationChunk && !IsStreamGenerationEnd && !IsStreamEnd && IsFactualConsistencyScore && !IsGenerationInfo && !IsStreamError || !IsStreamSearch && !IsStreamGenerationChunk && !IsStreamGenerationEnd && !IsStreamEnd && !IsFactualConsistencyScore && IsGenerationInfo && !IsStreamError || !IsStreamSearch && !IsStreamGenerationChunk && !IsStreamGenerationEnd && !IsStreamEnd && !IsFactualConsistencyScore && !IsGenerationInfo && IsStreamError;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.StreamSearchResponse?, TResult>? streamSearch = null,
            global::System.Func<global::G.StreamGenerationChunk?, TResult>? streamGenerationChunk = null,
            global::System.Func<global::G.StreamGenerationEnd?, TResult>? streamGenerationEnd = null,
            global::System.Func<global::G.StreamResponseEnd?, TResult>? streamEnd = null,
            global::System.Func<global::G.FactualConsistencyScore?, TResult>? factualConsistencyScore = null,
            global::System.Func<global::G.GenerationInfo?, TResult>? generationInfo = null,
            global::System.Func<global::G.StreamError?, TResult>? streamError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStreamSearch && streamSearch != null)
            {
                return streamSearch(StreamSearch!);
            }
            else if (IsStreamGenerationChunk && streamGenerationChunk != null)
            {
                return streamGenerationChunk(StreamGenerationChunk!);
            }
            else if (IsStreamGenerationEnd && streamGenerationEnd != null)
            {
                return streamGenerationEnd(StreamGenerationEnd!);
            }
            else if (IsStreamEnd && streamEnd != null)
            {
                return streamEnd(StreamEnd!);
            }
            else if (IsFactualConsistencyScore && factualConsistencyScore != null)
            {
                return factualConsistencyScore(FactualConsistencyScore!);
            }
            else if (IsGenerationInfo && generationInfo != null)
            {
                return generationInfo(GenerationInfo!);
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
            global::System.Action<global::G.StreamSearchResponse?>? streamSearch = null,
            global::System.Action<global::G.StreamGenerationChunk?>? streamGenerationChunk = null,
            global::System.Action<global::G.StreamGenerationEnd?>? streamGenerationEnd = null,
            global::System.Action<global::G.StreamResponseEnd?>? streamEnd = null,
            global::System.Action<global::G.FactualConsistencyScore?>? factualConsistencyScore = null,
            global::System.Action<global::G.GenerationInfo?>? generationInfo = null,
            global::System.Action<global::G.StreamError?>? streamError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStreamSearch)
            {
                streamSearch?.Invoke(StreamSearch!);
            }
            else if (IsStreamGenerationChunk)
            {
                streamGenerationChunk?.Invoke(StreamGenerationChunk!);
            }
            else if (IsStreamGenerationEnd)
            {
                streamGenerationEnd?.Invoke(StreamGenerationEnd!);
            }
            else if (IsStreamEnd)
            {
                streamEnd?.Invoke(StreamEnd!);
            }
            else if (IsFactualConsistencyScore)
            {
                factualConsistencyScore?.Invoke(FactualConsistencyScore!);
            }
            else if (IsGenerationInfo)
            {
                generationInfo?.Invoke(GenerationInfo!);
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
                StreamSearch,
                typeof(global::G.StreamSearchResponse),
                StreamGenerationChunk,
                typeof(global::G.StreamGenerationChunk),
                StreamGenerationEnd,
                typeof(global::G.StreamGenerationEnd),
                StreamEnd,
                typeof(global::G.StreamResponseEnd),
                FactualConsistencyScore,
                typeof(global::G.FactualConsistencyScore),
                GenerationInfo,
                typeof(global::G.GenerationInfo),
                StreamError,
                typeof(global::G.StreamError),
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
        public bool Equals(QueryStreamedResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.StreamSearchResponse?>.Default.Equals(StreamSearch, other.StreamSearch) &&
                global::System.Collections.Generic.EqualityComparer<global::G.StreamGenerationChunk?>.Default.Equals(StreamGenerationChunk, other.StreamGenerationChunk) &&
                global::System.Collections.Generic.EqualityComparer<global::G.StreamGenerationEnd?>.Default.Equals(StreamGenerationEnd, other.StreamGenerationEnd) &&
                global::System.Collections.Generic.EqualityComparer<global::G.StreamResponseEnd?>.Default.Equals(StreamEnd, other.StreamEnd) &&
                global::System.Collections.Generic.EqualityComparer<global::G.FactualConsistencyScore?>.Default.Equals(FactualConsistencyScore, other.FactualConsistencyScore) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GenerationInfo?>.Default.Equals(GenerationInfo, other.GenerationInfo) &&
                global::System.Collections.Generic.EqualityComparer<global::G.StreamError?>.Default.Equals(StreamError, other.StreamError) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(QueryStreamedResponse obj1, QueryStreamedResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<QueryStreamedResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(QueryStreamedResponse obj1, QueryStreamedResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is QueryStreamedResponse o && Equals(o);
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
    #if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
    #endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.QueryStreamedResponse? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.QueryStreamedResponse>(
                json,
                jsonSerializerOptions);
        }

    }
}
