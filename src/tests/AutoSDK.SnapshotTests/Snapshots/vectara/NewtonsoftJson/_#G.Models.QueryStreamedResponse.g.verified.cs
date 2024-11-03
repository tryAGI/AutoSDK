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
        /// 
        /// </summary>
        public global::G.QueryStreamedResponseDiscriminatorType? Type { get; }

        /// <summary>
        /// The search response results.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.StreamSearchResponse? SearchResults { get; init; }
#else
        public global::G.StreamSearchResponse? SearchResults { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SearchResults))]
#endif
        public bool IsSearchResults => SearchResults != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator QueryStreamedResponse(global::G.StreamSearchResponse value) => new QueryStreamedResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.StreamSearchResponse?(QueryStreamedResponse @this) => @this.SearchResults;

        /// <summary>
        /// 
        /// </summary>
        public QueryStreamedResponse(global::G.StreamSearchResponse? value)
        {
            SearchResults = value;
        }

        /// <summary>
        /// The chunk response from the generation, which may be a partial generation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.StreamGenerationChunk? GenerationChunk { get; init; }
#else
        public global::G.StreamGenerationChunk? GenerationChunk { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GenerationChunk))]
#endif
        public bool IsGenerationChunk => GenerationChunk != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator QueryStreamedResponse(global::G.StreamGenerationChunk value) => new QueryStreamedResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.StreamGenerationChunk?(QueryStreamedResponse @this) => @this.GenerationChunk;

        /// <summary>
        /// 
        /// </summary>
        public QueryStreamedResponse(global::G.StreamGenerationChunk? value)
        {
            GenerationChunk = value;
        }

        /// <summary>
        /// The end of generation. There may still be more information such as the<br/>
        /// factual consistency score, but generation has stopped.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.StreamGenerationEnd? GenerationEnd { get; init; }
#else
        public global::G.StreamGenerationEnd? GenerationEnd { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GenerationEnd))]
#endif
        public bool IsGenerationEnd => GenerationEnd != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator QueryStreamedResponse(global::G.StreamGenerationEnd value) => new QueryStreamedResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.StreamGenerationEnd?(QueryStreamedResponse @this) => @this.GenerationEnd;

        /// <summary>
        /// 
        /// </summary>
        public QueryStreamedResponse(global::G.StreamGenerationEnd? value)
        {
            GenerationEnd = value;
        }

        /// <summary>
        /// The end of a query response stream.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.StreamResponseEnd? End { get; init; }
#else
        public global::G.StreamResponseEnd? End { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(End))]
#endif
        public bool IsEnd => End != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator QueryStreamedResponse(global::G.StreamResponseEnd value) => new QueryStreamedResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.StreamResponseEnd?(QueryStreamedResponse @this) => @this.End;

        /// <summary>
        /// 
        /// </summary>
        public QueryStreamedResponse(global::G.StreamResponseEnd? value)
        {
            End = value;
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
        public global::G.StreamError? Error { get; init; }
#else
        public global::G.StreamError? Error { get; }
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
        public static implicit operator QueryStreamedResponse(global::G.StreamError value) => new QueryStreamedResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.StreamError?(QueryStreamedResponse @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public QueryStreamedResponse(global::G.StreamError? value)
        {
            Error = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public QueryStreamedResponse(
            global::G.QueryStreamedResponseDiscriminatorType? type,
            global::G.StreamSearchResponse? searchResults,
            global::G.StreamGenerationChunk? generationChunk,
            global::G.StreamGenerationEnd? generationEnd,
            global::G.StreamResponseEnd? end,
            global::G.FactualConsistencyScore? factualConsistencyScore,
            global::G.GenerationInfo? generationInfo,
            global::G.StreamError? error
            )
        {
            Type = type;

            SearchResults = searchResults;
            GenerationChunk = generationChunk;
            GenerationEnd = generationEnd;
            End = end;
            FactualConsistencyScore = factualConsistencyScore;
            GenerationInfo = generationInfo;
            Error = error;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Error as object ??
            GenerationInfo as object ??
            FactualConsistencyScore as object ??
            End as object ??
            GenerationEnd as object ??
            GenerationChunk as object ??
            SearchResults as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSearchResults && !IsGenerationChunk && !IsGenerationEnd && !IsEnd && !IsFactualConsistencyScore && !IsGenerationInfo && !IsError || !IsSearchResults && IsGenerationChunk && !IsGenerationEnd && !IsEnd && !IsFactualConsistencyScore && !IsGenerationInfo && !IsError || !IsSearchResults && !IsGenerationChunk && IsGenerationEnd && !IsEnd && !IsFactualConsistencyScore && !IsGenerationInfo && !IsError || !IsSearchResults && !IsGenerationChunk && !IsGenerationEnd && IsEnd && !IsFactualConsistencyScore && !IsGenerationInfo && !IsError || !IsSearchResults && !IsGenerationChunk && !IsGenerationEnd && !IsEnd && IsFactualConsistencyScore && !IsGenerationInfo && !IsError || !IsSearchResults && !IsGenerationChunk && !IsGenerationEnd && !IsEnd && !IsFactualConsistencyScore && IsGenerationInfo && !IsError || !IsSearchResults && !IsGenerationChunk && !IsGenerationEnd && !IsEnd && !IsFactualConsistencyScore && !IsGenerationInfo && IsError;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.StreamSearchResponse?, TResult>? searchResults = null,
            global::System.Func<global::G.StreamGenerationChunk?, TResult>? generationChunk = null,
            global::System.Func<global::G.StreamGenerationEnd?, TResult>? generationEnd = null,
            global::System.Func<global::G.StreamResponseEnd?, TResult>? end = null,
            global::System.Func<global::G.FactualConsistencyScore?, TResult>? factualConsistencyScore = null,
            global::System.Func<global::G.GenerationInfo?, TResult>? generationInfo = null,
            global::System.Func<global::G.StreamError?, TResult>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSearchResults && searchResults != null)
            {
                return searchResults(SearchResults!);
            }
            else if (IsGenerationChunk && generationChunk != null)
            {
                return generationChunk(GenerationChunk!);
            }
            else if (IsGenerationEnd && generationEnd != null)
            {
                return generationEnd(GenerationEnd!);
            }
            else if (IsEnd && end != null)
            {
                return end(End!);
            }
            else if (IsFactualConsistencyScore && factualConsistencyScore != null)
            {
                return factualConsistencyScore(FactualConsistencyScore!);
            }
            else if (IsGenerationInfo && generationInfo != null)
            {
                return generationInfo(GenerationInfo!);
            }
            else if (IsError && error != null)
            {
                return error(Error!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.StreamSearchResponse?>? searchResults = null,
            global::System.Action<global::G.StreamGenerationChunk?>? generationChunk = null,
            global::System.Action<global::G.StreamGenerationEnd?>? generationEnd = null,
            global::System.Action<global::G.StreamResponseEnd?>? end = null,
            global::System.Action<global::G.FactualConsistencyScore?>? factualConsistencyScore = null,
            global::System.Action<global::G.GenerationInfo?>? generationInfo = null,
            global::System.Action<global::G.StreamError?>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSearchResults)
            {
                searchResults?.Invoke(SearchResults!);
            }
            else if (IsGenerationChunk)
            {
                generationChunk?.Invoke(GenerationChunk!);
            }
            else if (IsGenerationEnd)
            {
                generationEnd?.Invoke(GenerationEnd!);
            }
            else if (IsEnd)
            {
                end?.Invoke(End!);
            }
            else if (IsFactualConsistencyScore)
            {
                factualConsistencyScore?.Invoke(FactualConsistencyScore!);
            }
            else if (IsGenerationInfo)
            {
                generationInfo?.Invoke(GenerationInfo!);
            }
            else if (IsError)
            {
                error?.Invoke(Error!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SearchResults,
                typeof(global::G.StreamSearchResponse),
                GenerationChunk,
                typeof(global::G.StreamGenerationChunk),
                GenerationEnd,
                typeof(global::G.StreamGenerationEnd),
                End,
                typeof(global::G.StreamResponseEnd),
                FactualConsistencyScore,
                typeof(global::G.FactualConsistencyScore),
                GenerationInfo,
                typeof(global::G.GenerationInfo),
                Error,
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
                global::System.Collections.Generic.EqualityComparer<global::G.StreamSearchResponse?>.Default.Equals(SearchResults, other.SearchResults) &&
                global::System.Collections.Generic.EqualityComparer<global::G.StreamGenerationChunk?>.Default.Equals(GenerationChunk, other.GenerationChunk) &&
                global::System.Collections.Generic.EqualityComparer<global::G.StreamGenerationEnd?>.Default.Equals(GenerationEnd, other.GenerationEnd) &&
                global::System.Collections.Generic.EqualityComparer<global::G.StreamResponseEnd?>.Default.Equals(End, other.End) &&
                global::System.Collections.Generic.EqualityComparer<global::G.FactualConsistencyScore?>.Default.Equals(FactualConsistencyScore, other.FactualConsistencyScore) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GenerationInfo?>.Default.Equals(GenerationInfo, other.GenerationInfo) &&
                global::System.Collections.Generic.EqualityComparer<global::G.StreamError?>.Default.Equals(Error, other.Error) 
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
#if NET8_0_OR_GREATER
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
#if NET8_0_OR_GREATER
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

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER     
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.QueryStreamedResponse?> FromJsonStream(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.QueryStreamedResponse?>(serializer.Deserialize<global::G.QueryStreamedResponse>(jsonReader));
        }

    }
}
